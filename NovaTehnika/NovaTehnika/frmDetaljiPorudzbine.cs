using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NovaTehnika
{
    public partial class frmDetaljiPorudzbine : Form
    {
        int SifraPorudzbine;
        double ZaUplatu;
        double Cena;
        string KonekcioniString;
        SqlConnection Konekcija;
        SqlCommand Komanda;

        private void OsveziEkran()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                string KomandaTabela = "SELECT StavkaPorudzbine.SifraStavke AS [ID], Proizvod.NazivProizvoda AS [Proizvod], StavkaPorudzbine.Kolicina AS [Količina], Kategorija.NazivKategorije AS [Kategorija], StavkaPorudzbine.Cena AS [Cena] FROM StavkaPorudzbine INNER JOIN Proizvod ON StavkaPorudzbine.SifraProizvoda = Proizvod.SifraProizvoda INNER JOIN Kategorija ON Kategorija.SifraKategorije = Proizvod.SifraKategorije WHERE StavkaPorudzbine.SifraPorudzbine =" + SifraPorudzbine;

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
                Reader.Close();
                string ZaUplatuUpit = "SELECT SUM(StavkaPorudzbine.Cena*StavkaPorudzbine.Kolicina) FROM StavkaPorudzbine WHERE StavkaPorudzbine.SifraPorudzbine = " + SifraPorudzbine;
                Komanda = new SqlCommand(ZaUplatuUpit, Konekcija);
                if(Komanda.ExecuteScalar() != DBNull.Value)
                {
                    ZaUplatu = Convert.ToDouble(Komanda.ExecuteScalar());
                }
                else
                {
                    ZaUplatu = 0;
                }
                lblZaUplatuValue.Text = ZaUplatu.ToString();
            }
        }

        private void UcitajProizvode()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SifraProizvoda, NazivProizvoda FROM Proizvod";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, Konekcija);
                    DataSet setProizvod = new DataSet();
                    Adapter.Fill(setProizvod, "Proizvodi");
                    cmbProizvod.DisplayMember = "NazivProizvoda";
                    cmbProizvod.ValueMember = "SifraProizvoda";
                    cmbProizvod.DataSource = setProizvod.Tables["Proizvodi"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public frmDetaljiPorudzbine(int SifraPor)
        {
            InitializeComponent();
            SifraPorudzbine = SifraPor;
            KonekcioniString = ConfigurationManager.ConnectionStrings["KonekcioniString"].ConnectionString;
            Konekcija = new SqlConnection(KonekcioniString);
        }
         
        private void frmDetaljiPorudzbine_Load(object sender, EventArgs e)
        { 
            OsveziEkran();
            UcitajProizvode();
            lblSifraPorudzbineValue.Text = SifraPorudzbine.ToString();
        }

        private void cmbProizvod_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                string Upit = "SELECT Cena FROM Proizvod WHERE SifraProizvoda = " + cmbProizvod.SelectedValue;
                Komanda = new SqlCommand(Upit, Konekcija);
                Konekcija.Open();
                Cena = Convert.ToDouble(Komanda.ExecuteScalar());
                txtCena.Text = Cena.ToString();
                txtKolicina.Text = "1";
                Konekcija.Close();
            }
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (txtCena.Text == "" || txtKolicina.Text == "")
            {
                MessageBox.Show("Popunite sva polja pre unosa.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("INSERT INTO StavkaPorudzbine (SifraPorudzbine, Kolicina, Cena, SifraProizvoda) VALUES (" + SifraPorudzbine + ", " + int.Parse(txtKolicina.Text) + ", " + double.Parse(txtCena.Text) + ", " + cmbProizvod.SelectedValue + ");", Konekcija);
                    Konekcija.Open();
                    try
                    {
                        Komanda.ExecuteNonQuery();
                        MessageBox.Show("Stavka je uspešno uneta.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cmbProizvod.SelectedItem = 0;
            txtCena.Text = "";
            txtKolicina.Text = "";
        }

        private void btnNadji_Click(object sender, EventArgs e)
        {
            if (txtSifraStavke.Text == "")
            {
                MessageBox.Show("Polje 'šifra stavke' je prazno - unesite šifru stavke.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM StavkaPorudzbine WHERE SifraStavke = " + int.Parse(txtSifraStavke.Text) + " AND SifraPorudzbine = " + SifraPorudzbine, Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();

                        if (Reader.Read())
                        {
                            // SifraStavke, SifraPorudzbine, Kolicina, Cena, SifraProizvoda
                            txtKolicina.Text = Reader[2].ToString();
                            txtCena.Text = Reader[3].ToString();
                            cmbProizvod.SelectedValue = Reader[4];
                        }
                        else
                        {
                            MessageBox.Show("Stavka sa zadatom šifrom unutar trenutne porudžbine nije pronađena.");
                        }
                        Reader.Close();
                        txtSifraStavke.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dogodila se greška - " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        OsveziEkran();
                        Konekcija.Close();
                    }
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (txtSifraStavke.Text == "")
            {
                MessageBox.Show("Polje 'šifra stavke' je prazno - unesite šifru stavke.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM StavkaPorudzbine WHERE SifraStavke = " + int.Parse(txtSifraStavke.Text), Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();

                        if (Reader.Read())
                        {
                            Reader.Close();
                            var PotvrdiIzmenu = MessageBox.Show("Potvrdite izmenu stavke " + txtSifraStavke.Text + ".", "Potvrdite izmenu", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                            if (PotvrdiIzmenu == DialogResult.OK)
                            {
                                // SifraStavke, SifraPorudzbine, Kolicina, Cena, SifraProizvoda
                                string UpdateNaredba = "UPDATE StavkaPorudzbine SET Kolicina =" + int.Parse(txtKolicina.Text) + ", Cena=" + double.Parse(txtCena.Text) + ", SifraProizvoda=" + cmbProizvod.SelectedValue + "WHERE SifraStavke =" + int.Parse(txtSifraStavke.Text);
                                Komanda = new SqlCommand(UpdateNaredba, Konekcija);
                                try
                                {
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Stavka je uspešno izmenjena", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception Ex)
                                {
                                    MessageBox.Show("Dogodila se greška - " + Ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Stavka sa zadatom šifrom nije pronađena.");
                            txtSifraStavke.Text = "";
                            txtSifraStavke.Focus();
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
            if (txtSifraStavke.Text == "")
            {
                MessageBox.Show("Polje 'šifra stavke' je prazno - unesite šifru stavke.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM StavkaPorudzbine WHERE SifraStavke = " + int.Parse(txtSifraStavke.Text), Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();

                        if (Reader.Read())
                        {
                            Reader.Close();
                            var PotvrdiUklanjanje = MessageBox.Show("Potvrdite uklanjanje porudžbine " + txtSifraStavke.Text + ".", "Potvrdite uklanjanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                            if (PotvrdiUklanjanje == DialogResult.OK)
                            {
                                // SifraStavke, SifraPorudzbine, Kolicina, Cena, SifraProizvoda
                                string DeleteNaredba = "DELETE FROM StavkaPorudzbine WHERE SifraStavke =" + int.Parse(txtSifraStavke.Text);
                                Komanda = new SqlCommand(DeleteNaredba, Konekcija);
                                try
                                {
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Stavka je uspešno izmenjena", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception Ex)
                                {
                                    MessageBox.Show("Dogodila se greška - " + Ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Stavka sa zadatom šifrom nije pronađena.");
                            txtSifraStavke.Text = "";
                            txtSifraStavke.Focus();
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
