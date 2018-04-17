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
    public partial class frmProizvodi : Form
    {
        string KonekcioniString;
        SqlConnection Konekcija;
        SqlCommand Komanda;

        public frmProizvodi()
        {
            InitializeComponent();
            KonekcioniString = ConfigurationManager.ConnectionStrings["KonekcioniString"].ConnectionString;
            Konekcija = new SqlConnection(KonekcioniString);
        }

        private void frmProizvodi_Load(object sender, EventArgs e)
        {
            OsveziEkran();
            UcitajKategorije();
            UcitajDobavljace();
        }

        private void OsveziEkran()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                string KomandaTabela = "SELECT Proizvod.SifraProizvoda AS [ID], Proizvod.NazivProizvoda AS [Naziv proizvoda], Proizvod.Cena, Kategorija.NazivKategorije AS [Kategorija], Dobavljac.NazivKompanije AS [Dobavljač] FROM Proizvod INNER JOIN Kategorija ON Proizvod.SifraKategorije = Kategorija.SifraKategorije INNER JOIN Dobavljac on Proizvod.SifraDobavljaca = Dobavljac.SifraDobavljaca";

                Komanda = new SqlCommand(KomandaTabela, Konekcija);
                Konekcija.Open();
                SqlDataReader Reader = Komanda.ExecuteReader();

                if (Reader.HasRows)
                {
                    DataTable Tabela = new DataTable();
                    Tabela.Load(Reader);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.DataSource = Tabela;
                }
            }
        }

        private void UcitajKategorije()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SifraKategorije, NazivKategorije FROM Kategorija";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, Konekcija);
                    DataSet setKategorije = new DataSet();
                    Adapter.Fill(setKategorije, "Kategorije");
                    cmbKategorija.DisplayMember = "NazivKategorije";
                    cmbKategorija.ValueMember = "SifraKategorije";
                    cmbKategorija.DataSource = setKategorije.Tables["Kategorije"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UcitajDobavljace()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SifraDobavljaca, NazivKompanije FROM Dobavljac";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, Konekcija);
                    DataSet setDobavljac = new DataSet();
                    Adapter.Fill(setDobavljac, "Dobavljac");
                    cmbDobavljac.DisplayMember = "NazivKompanije";
                    cmbDobavljac.ValueMember = "SifraDobavljaca";
                    cmbDobavljac.DataSource = setDobavljac.Tables["Dobavljac"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "" || txtCena.Text == "")
            {
                MessageBox.Show("Popunite sva polja pre unosa.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("INSERT INTO Proizvod(NazivProizvoda, Cena, SifraKategorije, SifraDobavljaca) VALUES('" + txtNaziv.Text + "', " + double.Parse(txtCena.Text) + ", " + cmbKategorija.SelectedValue + ", " + cmbDobavljac.SelectedValue + ");", Konekcija);
                    Konekcija.Open();
                    try
                    {
                        Komanda.ExecuteNonQuery();
                        MessageBox.Show("Proizvod je uspešno unet.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            txtNaziv.Text = "";
            txtCena.Text = "";
            txtSifraProizvoda.Text = "";
            cmbDobavljac.SelectedItem = 1;
            cmbKategorija.SelectedItem = 1;
            OsveziEkran();
        }

        private void btnNadji_Click(object sender, EventArgs e)
        {
            if (txtSifraProizvoda.Text == "")
            {
                MessageBox.Show("Polje 'šifra proizvoda' je prazno - unesite šifru proizvoda.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM Proizvod WHERE SifraProizvoda = " + int.Parse(txtSifraProizvoda.Text), Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();

                        if (!Reader.Read() || Reader[1].ToString() == "")
                        {
                            MessageBox.Show("Proizvod sa zadatom šifrom nije pronađen.");
                            
                        }
                        else
                        {
                            // SifraProizvoda, NazivProizvoda, Cena, SifraKategorije, SifraDobavljaca
                            txtNaziv.Text = Reader[1].ToString();
                            txtCena.Text = Reader[2].ToString();
                            cmbKategorija.SelectedValue = Reader[3];
                            cmbDobavljac.SelectedValue = Reader[4];
                        }
                        Reader.Close();
                        txtSifraProizvoda.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dogodila se greška - " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Konekcija.Close();
                    }
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (txtSifraProizvoda.Text == "")
            {
                MessageBox.Show("Polje 'šifra proizvoda' je prazno - unesite šifru proizvoda.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM Proizvod WHERE SifraProizvoda = " + int.Parse(txtSifraProizvoda.Text), Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();

                        if (Reader.Read())
                        {
                            Reader.Close();
                            var PotvrdiIzmenu = MessageBox.Show("Potvrdite izmenu stavke " + txtSifraProizvoda.Text + ".", "Potvrdite izmenu", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                            if (PotvrdiIzmenu == DialogResult.OK)
                            {
                                // SifraProizvoda, NazivProizvoda, Cena, SifraKategorije, SifraDobavljaca
                                string UpdateNaredba = "UPDATE Proizvod SET NazivProizvoda = '" + txtNaziv.Text + "', Cena = " + Double.Parse(txtCena.Text) + ", SifraKategorije = " + cmbKategorija.SelectedValue + ", SifraDobavljaca = " + cmbDobavljac.SelectedValue + " WHERE SifraProizvoda = " + int.Parse(txtSifraProizvoda.Text);
                                Komanda = new SqlCommand(UpdateNaredba, Konekcija);
                                try
                                {
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Proizvod je uspešno izmenjen", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception Ex)
                                {
                                    MessageBox.Show("Dogodila se greška - " + Ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proizvod sa zadatom šifrom nije pronađen.");
                            txtSifraProizvoda.Text = "";
                            txtSifraProizvoda.Focus();
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Dogodila se greška - " + Ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Konekcija.Close();
                        OsveziEkran();
                    }
                }
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (txtSifraProizvoda.Text == "")
            {
                MessageBox.Show("Polje 'šifra proizvoda' je prazno - unesite šifru proizvoda.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM Proizvod WHERE SifraProizvoda = " + int.Parse(txtSifraProizvoda.Text), Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();

                        if (Reader.Read())
                        {
                            Reader.Close();
                            var PotvrdiUklanjanje = MessageBox.Show("Potvrdite uklanjanje proizvoda " + txtSifraProizvoda.Text + ".", "Potvrdite uklanjanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                            if (PotvrdiUklanjanje == DialogResult.OK)
                            {
                                string DeleteNaredba = "DELETE FROM Proizvod WHERE SifraProizvoda = " + int.Parse(txtSifraProizvoda.Text);
                                Komanda = new SqlCommand(DeleteNaredba, Konekcija);
                                try
                                {
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Proizvod je uspešno uklonjen", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception Ex)
                                {
                                    MessageBox.Show("Dogodila se greška - " + Ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proizvod sa zadatom šifrom nije pronađen.");
                            txtSifraProizvoda.Text = "";
                            txtSifraProizvoda.Focus();
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Dogodila se greška - " + Ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Konekcija.Close();
                        OsveziEkran();
                    }
                }
            }
        }
    }
}
