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
    public partial class frmDostavljaci : Form
    {
        string KonekcioniString;
        SqlConnection Konekcija;
        SqlCommand Komanda;

        public frmDostavljaci()
        {
            KonekcioniString = ConfigurationManager.ConnectionStrings["KonekcioniString"].ConnectionString;
            Konekcija = new SqlConnection(KonekcioniString);
            InitializeComponent();
        }

        private void frmDostavljaci_Load(object sender, EventArgs e)
        {
            OsveziEkran();
        }

        private void OsveziEkran()
        {
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Dostavljac.SifraDostavljaca AS [ID], Dostavljac.NazivKompanije AS [Kompanija], Dostavljac.NazivKontakta AS [Kontakt], Dostavljac.Telefon FROM Dostavljac", Konekcija);
            DataSet DostavljacSet = new DataSet();
            DataTable DostavljacTabela = new DataTable();
            Adapter.Fill(DostavljacSet);
            Adapter.Fill(DostavljacTabela);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = DostavljacTabela;
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (txtNazivKompanije.Text == "" || txtNazivKontakta.Text == "" || txtTelefon.Text == "")
            {
                MessageBox.Show("Unesite sve podatke.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    Komanda = new SqlCommand("INSERT INTO Dostavljac(NazivKompanije, NazivKontakta, Telefon) VALUES ('" + txtNazivKompanije.Text + "', '" + txtNazivKontakta.Text + "', '"+txtTelefon.Text+"');", Konekcija);
                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    Adapter.InsertCommand = Komanda;
                    Konekcija.Open();
                    try
                    {
                        Adapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Dostavljač je uspešno unet.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtSifraDostavljaca.Text == "")
            {
                MessageBox.Show("Unesite šifru dostavljača.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    try
                    {
                        string SelectUpit = "SELECT NazivKompanije, NazivKontakta, Telefon FROM Dostavljac WHERE SifraDostavljaca = " + int.Parse(txtSifraDostavljaca.Text);
                        SqlDataAdapter Adapter = new SqlDataAdapter(SelectUpit, Konekcija);
                        DataSet setDostavljac = new DataSet();
                        Adapter.Fill(setDostavljac, "Dostavljac");
                        txtNazivKompanije.Text = setDostavljac.Tables[0].Rows[0]["NazivKompanije"].ToString();
                        txtNazivKontakta.Text = setDostavljac.Tables[0].Rows[0]["NazivKontakta"].ToString();
                        txtTelefon.Text = setDostavljac.Tables[0].Rows[0]["Telefon"].ToString();
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
            if (txtNazivKompanije.Text == "" || txtNazivKontakta.Text == "" || txtTelefon.Text == "" || txtSifraDostavljaca.Text == "")
            {
                MessageBox.Show("Unesite neophodne podatke.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    var PotvrdiIzmenu = MessageBox.Show("Potvrdite izmenu dostavljača " + txtSifraDostavljaca.Text + ".", "Potvrdite izmenu", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                    if (PotvrdiIzmenu == DialogResult.OK)
                    {
                        Komanda = new SqlCommand("UPDATE Dostavljac SET NazivKompanije = '" + txtNazivKompanije.Text + "', NazivKontakta = '" + txtNazivKontakta.Text + "', Telefon = '" + txtTelefon.Text + "' WHERE SifraDostavljaca =" + int.Parse(txtSifraDostavljaca.Text), Konekcija);
                        SqlDataAdapter Adapter = new SqlDataAdapter();
                        Adapter.UpdateCommand = Komanda;
                        Konekcija.Open();
                        try
                        {
                            Adapter.UpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Dostavljač je uspešno ažuriran.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtSifraDostavljaca.Text == "")
            {
                MessageBox.Show("Unesite šifru dostavljača.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    var PotvrdiUklanjanje = MessageBox.Show("Potvrdite uklanjanje dostavljača " + txtSifraDostavljaca.Text + ".", "Potvrdite uklanjanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (PotvrdiUklanjanje == DialogResult.OK)
                    {
                        Komanda = new SqlCommand("DELETE FROM Dostavljac WHERE SifraDostavljaca =" + int.Parse(txtSifraDostavljaca.Text), Konekcija);
                        SqlDataAdapter Adapter = new SqlDataAdapter();
                        Adapter.DeleteCommand = Komanda;
                        Konekcija.Open();
                        try
                        {
                            Adapter.DeleteCommand.ExecuteNonQuery();
                            MessageBox.Show("Dostavljač je uspešno uklonjen.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNazivKompanije.Text = "";
            txtNazivKontakta.Text = "";
            txtSifraDostavljaca.Text = "";
            txtTelefon.Text = "";
        }
    }
}
