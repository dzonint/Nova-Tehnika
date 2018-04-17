using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace NovaTehnika
{
    public partial class frmKategorije : Form
    {
        string KonekcioniString;
        SqlConnection Konekcija;
        SqlCommand Komanda;

        public frmKategorije()
        {
            KonekcioniString = ConfigurationManager.ConnectionStrings["KonekcioniString"].ConnectionString;
            Konekcija = new SqlConnection(KonekcioniString);
            InitializeComponent();
        }

        private void frmKategorije_Load(object sender, EventArgs e)
        {
            OsveziEkran();
        }

        private void OsveziEkran()
        {
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Kategorija.SifraKategorije AS [ID], Kategorija.NazivKategorije AS [Naziv], Kategorija.Opis FROM Kategorija", Konekcija);
            DataSet KategorijaSet = new DataSet();
            DataTable KategorijaTabela = new DataTable();
            Adapter.Fill(KategorijaSet);
            Adapter.Fill(KategorijaTabela);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = KategorijaTabela;
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text == "")
            {
                MessageBox.Show("Morate uneti barem naziv kategorije pre unosa.");
            }
            else
            {
                using(Konekcija = new SqlConnection(KonekcioniString))
                {
                    if(txtOpis.Text == "")
                    {
                        Komanda = new SqlCommand("INSERT INTO Kategorija(NazivKategorije) VALUES ('"+txtNaziv.Text+"');", Konekcija);
                    }
                    else
                    {
                        Komanda = new SqlCommand("INSERT INTO Kategorija(NazivKategorije, Opis) VALUES ('" + txtNaziv.Text + "', '"+txtOpis.Text+"');", Konekcija);
                    }

                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    Adapter.InsertCommand = Komanda;
                    Konekcija.Open();
                    try
                    {
                        Adapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Kategorija je uspešno uneta.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nastala je greška - " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        OsveziEkran();
                        Konekcija.Close();
                    }
                }
            }
        }

        private void btnNadji_Click(object sender, EventArgs e)
        {
            if (txtSifraKategorije.Text == "")
            {
                MessageBox.Show("Unesite šifru kategorije.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    try
                    {
                        string SelectUpit = "SELECT NazivKategorije, Opis FROM Kategorija WHERE SifraKategorije = " + int.Parse(txtSifraKategorije.Text);
                        SqlDataAdapter Adapter = new SqlDataAdapter(SelectUpit, Konekcija);
                        DataSet setKategorija = new DataSet();
                        Adapter.Fill(setKategorija, "Kategorija");
                        txtNaziv.Text = setKategorija.Tables[0].Rows[0]["NazivKategorije"].ToString();
                        txtOpis.Text = setKategorija.Tables[0].Rows[0]["Opis"].ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nastala je greška - " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "" || txtSifraKategorije.Text == "")
            {
                MessageBox.Show("Unesite neophodne podatke.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    var PotvrdiIzmenu = MessageBox.Show("Potvrdite izmenu kategorije " + txtSifraKategorije.Text + ".", "Potvrdite izmenu", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                    if (PotvrdiIzmenu == DialogResult.OK)
                    {
                        if (txtOpis.Text == "")
                        {
                            Komanda = new SqlCommand("UPDATE Kategorija SET NazivKategorije = '" + txtNaziv.Text + "' WHERE SifraKategorije =" + txtSifraKategorije.Text, Konekcija);
                        }
                        else
                        {
                            Komanda = new SqlCommand("UPDATE Kategorija SET NazivKategorije = '" + txtNaziv.Text + "', Opis = '" + txtOpis.Text + "' WHERE SifraKategorije =" + int.Parse(txtSifraKategorije.Text), Konekcija);
                        }

                        SqlDataAdapter Adapter = new SqlDataAdapter();
                        Adapter.UpdateCommand = Komanda;
                        Konekcija.Open();
                        try
                        {
                            Adapter.UpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Kategorija je uspešno ažurirana.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nastala je greška - " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            OsveziEkran();
                            Konekcija.Close();
                        }
                    }
                }
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (txtSifraKategorije.Text == "")
            {
                MessageBox.Show("Unesite šifru kategorije.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    var PotvrdiUklanjanje = MessageBox.Show("Potvrdite uklanjanje kategorije " + txtSifraKategorije.Text + ".", "Potvrdite uklanjanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (PotvrdiUklanjanje == DialogResult.OK)
                    {
                        Komanda = new SqlCommand("DELETE FROM Kategorija WHERE SifraKategorije =" + int.Parse(txtSifraKategorije.Text), Konekcija);
                        SqlDataAdapter Adapter = new SqlDataAdapter();
                        Adapter.DeleteCommand = Komanda;
                        Konekcija.Open();
                        try
                        {
                            Adapter.DeleteCommand.ExecuteNonQuery();
                            MessageBox.Show("Kategorija je uspešno uklonjena.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nastala je greška - " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            OsveziEkran();
                            Konekcija.Close();
                        }
                    }
                }
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            txtNaziv.Text = "";
            txtOpis.Text = "";
            txtSifraKategorije.Text = "";
        }
    }
}
