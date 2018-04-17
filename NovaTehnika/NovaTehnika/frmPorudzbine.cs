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
    public partial class frmPorudzbine : Form
    {
        string KonekcioniString;
        SqlConnection Konekcija;
        SqlCommand Komanda;

        private void OsveziEkran()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                string KomandaTabela = "SELECT Porudzbina.SifraPorudzbine AS [ID], Klijent.NazivKompanije AS [Klijent], Porudzbina.DatumPorudzbine AS [Datum porudžbine], Porudzbina.RokIsporuke AS [Rok Isporuke], StanjePorudzbine.NazivStanja AS [Stanje], Dostavljac.NazivKompanije AS [Dostavljač],  Zaposleni.NazivZaposlenog AS [Zaposleni] FROM Porudzbina INNER JOIN Zaposleni ON Zaposleni.SifraZaposlenog = Porudzbina.SifraZaposlenog INNER JOIN Klijent ON Klijent.SifraKlijenta = Porudzbina.SifraKlijenta INNER JOIN Dostavljac ON Dostavljac.SifraDostavljaca = Porudzbina.SifraDostavljaca INNER JOIN StanjePorudzbine ON StanjePorudzbine.SifraStanja = Porudzbina.SifraStanja";

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

        private void UcitajZaposlene()
        {
            using(Konekcija = new SqlConnection(KonekcioniString))
            { 
                try
                {
                    string Query = "SELECT SifraZaposlenog, NazivZaposlenog FROM Zaposleni";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, Konekcija);
                    DataSet setZaposleni = new DataSet();
                    Adapter.Fill(setZaposleni, "Zaposleni");
                    cmbZaposleni.DisplayMember = "NazivZaposlenog";
                    cmbZaposleni.ValueMember = "SifraZaposlenog";
                    cmbZaposleni.DataSource = setZaposleni.Tables["Zaposleni"];
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UcitajKlijente()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SifraKlijenta, NazivKompanije FROM Klijent";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, Konekcija);
                    DataSet setKlijent = new DataSet();
                    Adapter.Fill(setKlijent, "Klijent");
                    cmbKlijent.DisplayMember = "NazivKompanije";
                    cmbKlijent.ValueMember = "SifraKlijenta";
                    cmbKlijent.DataSource = setKlijent.Tables["Klijent"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UcitajDostavljace()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SifraDostavljaca, NazivKompanije FROM Dostavljac";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, Konekcija);
                    DataSet setDostavljac = new DataSet();
                    Adapter.Fill(setDostavljac, "Dostavljac");
                    cmbDostavljac.DisplayMember = "NazivKompanije";
                    cmbDostavljac.ValueMember = "SifraDostavljaca";
                    cmbDostavljac.DataSource = setDostavljac.Tables["Dostavljac"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UcitajStanja()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SifraStanja, NazivStanja FROM StanjePorudzbine";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, Konekcija);
                    DataSet setStanje = new DataSet();
                    Adapter.Fill(setStanje, "Stanje");
                    cmbStanje.DisplayMember = "NazivStanja";
                    cmbStanje.ValueMember = "SifraStanja";
                    cmbStanje.DataSource = setStanje.Tables["Stanje"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public frmPorudzbine()
        {
            InitializeComponent();
            KonekcioniString = ConfigurationManager.ConnectionStrings["KonekcioniString"].ConnectionString;
            Konekcija = new SqlConnection(KonekcioniString);
        }

        private void frmUnosPorudzbine_Load(object sender, EventArgs e)
        {
            OsveziEkran();
            UcitajZaposlene();
            UcitajDostavljace();
            UcitajKlijente();
            UcitajStanja();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            // cmb.SelectedValue.ToString for ValueMember.
            // cmb.Text for DisplayMember.
            using(Konekcija = new SqlConnection(KonekcioniString))
            {
                SqlCommand Komanda = new SqlCommand("INSERT INTO Porudzbina(DatumPorudzbine, RokIsporuke, SifraKlijenta, SifraStanja, SifraZaposlenog, SifraDostavljaca, NazivKlijenta, StanjePorudzbine)VALUES ('" + dateDatumPorudzbine.Text + "', '" + dateRokIsporuke.Text + "', " + cmbKlijent.SelectedValue + ", " + cmbStanje.SelectedValue + ", " + cmbZaposleni.SelectedValue + ", " + cmbDostavljac.SelectedValue + ", '" + cmbKlijent.Text + "', '" + cmbStanje.Text + "');", Konekcija);
                Konekcija.Open();
                try
                {
                    Komanda.ExecuteNonQuery();
                    MessageBox.Show("Porudžbina je uspešno uneta.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
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

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            cmbDostavljac.SelectedItem = 0;
            cmbKlijent.SelectedItem = 0;
            cmbStanje.SelectedItem = 0;
            cmbZaposleni.SelectedItem = 0;
            dateDatumPorudzbine.Text = DateTime.Now.ToString();
            dateRokIsporuke.Text = DateTime.Now.ToString();
            txtSifraPorudzbine.Text = "";
            OsveziEkran();
        }

        private void btnNadji_Click(object sender, EventArgs e)
        {
            if(txtSifraPorudzbine.Text == "")
            {
                MessageBox.Show("Polje 'šifra porudžbine' je prazno - unesite šifru porudžbine.");
            }
            else
            {
                using(Konekcija=new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM Porudzbina WHERE SifraPorudzbine = " + int.Parse(txtSifraPorudzbine.Text), Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();

                        if (Reader.Read())
                        {
                            // SifraPorudzbine, DatumPorudzbine, RokIsporuke, SifraKlijenta, SifraStanja, SifraZaposlenog, SifraDostavljaca, NazivKlijenta, StanjePorudzbine
                            dateDatumPorudzbine.Text = Reader[1].ToString();
                            dateRokIsporuke.Text = Reader[2].ToString();
                            cmbKlijent.SelectedValue = Reader[3];
                            cmbStanje.SelectedValue = Reader[4];
                            cmbZaposleni.SelectedValue = Reader[5];
                            cmbDostavljac.SelectedValue = Reader[6];
                        }
                        else
                        {
                            MessageBox.Show("Porudžbina sa zadatom šifrom nije pronađena.");
                        }
                        Reader.Close();
                        txtSifraPorudzbine.Focus();
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
            if (txtSifraPorudzbine.Text == "")
            {
                MessageBox.Show("Polje 'šifra porudžbine' je prazno - unesite šifru porudžbine.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM Porudzbina WHERE SifraPorudzbine = " + int.Parse(txtSifraPorudzbine.Text), Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();

                        if (Reader.Read())
                        {
                            Reader.Close();
                            var PotvrdiIzmenu = MessageBox.Show("Potvrdite izmenu porudžbine " + txtSifraPorudzbine.Text + ".", "Potvrdite izmenu", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                            if (PotvrdiIzmenu == DialogResult.OK)
                            {
                                // SifraPorudzbine, DatumPorudzbine, RokIsporuke, SifraKlijenta, SifraStanja, SifraZaposlenog, SifraDostavljaca, NazivKlijenta, StanjePorudzbine
                                Komanda = new SqlCommand("UPDATE Porudzbina SET DatumPorudzbine ='" + dateDatumPorudzbine.Text + "', RokIsporuke = '" + dateRokIsporuke.Text + "', SifraKlijenta = " + cmbKlijent.SelectedValue + ", SifraStanja = " + cmbStanje.SelectedValue + ", SifraZaposlenog = " + cmbZaposleni.SelectedValue + ", SifraDostavljaca = " + cmbDostavljac.SelectedValue + ", NazivKlijenta = '" + cmbKlijent.Text + "', StanjePorudzbine = '" + cmbStanje.Text + "' WHERE SifraPorudzbine = " + int.Parse(txtSifraPorudzbine.Text) + ";", Konekcija);
                                try
                                {
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Porudžbina je uspešno izmenjena", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception Ex)
                                {
                                    MessageBox.Show("Dogodila se greška - " + Ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Porudžbina sa zadatom šifrom nije pronađena.");
                            txtSifraPorudzbine.Text = "";
                            txtSifraPorudzbine.Focus();
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
            if (txtSifraPorudzbine.Text == "")
            {
                MessageBox.Show("Polje 'šifra porudžbine' je prazno - unesite šifru porudžbine.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM Porudzbina WHERE SifraPorudzbine = " + int.Parse(txtSifraPorudzbine.Text), Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();

                        if (Reader.Read())
                        {
                            Reader.Close();
                            var PotvrdiUklanjanje = MessageBox.Show("Potvrdite uklanjanje porudžbine " + txtSifraPorudzbine.Text + ".", "Potvrdite uklanjanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                            if (PotvrdiUklanjanje == DialogResult.OK)
                            {
                                SqlCommand KomandaStavke = new SqlCommand("DELETE FROM StavkaPorudzbine WHERE SifraPorudzbine = " + int.Parse(txtSifraPorudzbine.Text), Konekcija);
                                Komanda = new SqlCommand("DELETE FROM Porudzbina WHERE SifraPorudzbine = " + int.Parse(txtSifraPorudzbine.Text), Konekcija);
                                try
                                {
                                    KomandaStavke.ExecuteNonQuery();
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Porudžbina je uspešno uklonjena.", "Uklanjanje porudžbine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception Ex)
                                {
                                    MessageBox.Show("Dogodila se greška - " + Ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Porudžbina sa zadatom šifrom nije pronađena.");
                            txtSifraPorudzbine.Text = "";
                            txtSifraPorudzbine.Focus();
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

        private void btnIzmeniKlijenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovaj okidač će prilikom izmene vrednosti kolone `NazivKontakta` u tabeli `Klijent` ažurirati vrednost kolone `NazivKlijenta` tabele `Porudzbina`.");
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                SqlCommand Komanda = new SqlCommand("UPDATE Klijent SET NazivKontakta = 'KlijentNazivOkidač' WHERE SifraKlijenta = 1", Konekcija);
                Konekcija.Open();
                try
                {
                    Komanda.ExecuteNonQuery();
                    MessageBox.Show("Naziv klijenta sa šifrom klijenta 1 je uspešno ažuriran u `KlijentNazivOkidač`.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnIzmeniStanje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovaj okidač će prilikom izmene vrednosti kolone `NazivStanja` u tabeli `StanjePorudzbine` ažurirati vrednost kolone `StanjePorudzbine` tabele `Porudzbina`.");
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                SqlCommand Komanda = new SqlCommand("UPDATE StanjePorudzbine SET NazivStanja = 'StanjeNazivOkidač' WHERE SifraStanja = 1", Konekcija);
                Konekcija.Open();
                try
                {
                    Komanda.ExecuteNonQuery();
                    MessageBox.Show("Naziv stanja sa šifrom stanja 1 je uspešno ažuriran u `StanjeNazivOkidač`.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUkloniKlijenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovaj okidač će zabraniti uklanjanje n-torke ukoliko se vrednost kolone `SifraKlijenta` te n-torke nalazi u koloni `SifraKlijenta` neke n-torke tabele `Porudzbina`.");
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                SqlCommand Komanda = new SqlCommand("DELETE FROM Klijent WHERE SifraKlijenta = 1", Konekcija);
                Konekcija.Open();
                try
                {
                    Komanda.ExecuteNonQuery();
                    MessageBox.Show("Klijent sa šifrom 1 je uspešno uklonjen.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUkloniStanje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovaj okidač će zabraniti uklanjanje n-torke ukoliko se vrednost kolone `SifraStanja` te n-torke nalazi u koloni `SifraStanja` neke n-torke tabele `Porudzbina`.");
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                SqlCommand Komanda = new SqlCommand("DELETE FROM StanjePorudzbine WHERE SifraStanja = 1", Konekcija);
                Konekcija.Open();
                try
                {
                    Komanda.ExecuteNonQuery();
                    MessageBox.Show("Stanje sa šifrom 1 je uspešno uklonjeno.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnNepostojeciKlijent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovaj okidač će zabraniti ažuriranje n-torke iz tabele `Porudzbina` ukoliko n-torka sa vrednostima kolona `SifraKlijenta` i `NazivKlijenta` ne postoji u tabeli `Klijent`.");
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                SqlCommand Komanda = new SqlCommand("UPDATE Porudzbina SET SifraKlijenta = 9999, NazivKlijenta = 'Nepostojeći klijent' WHERE SifraPorudzbine = 1", Konekcija);
                Konekcija.Open();
                try
                {
                    Komanda.ExecuteNonQuery();
                    MessageBox.Show("Porudžbina sa šifrom 1 je uspešno ažurirana.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnNepostojeceStanje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovaj okidač će zabraniti ažuriranje n-torke iz tabele `Porudzbina` ukoliko n-torka sa vrednostima kolona `SifraStanja` i `StanjePorudzbine` ne postoji u tabeli `StanjePorudzbine`.");
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                SqlCommand Komanda = new SqlCommand("UPDATE Porudzbina SET SifraStanja = 9999, StanjePorudzbine = 'Nepostojeće stanje' WHERE SifraPorudzbine = 1", Konekcija);
                Konekcija.Open();
                try
                {
                    Komanda.ExecuteNonQuery();
                    MessageBox.Show("Porudžbina sa šifrom 1 je uspešno ažurirana.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDetaljiPorudzbine_Click(object sender, EventArgs e)
        {
            if (txtSifraPorudzbine.Text == "")
            {
                MessageBox.Show("Polje 'šifra porudžbine' je prazno - unesite šifru porudžbine.");
            }
            else
            {
                frmDetaljiPorudzbine DetaljiPorudzbine = new frmDetaljiPorudzbine(int.Parse(txtSifraPorudzbine.Text));
                DetaljiPorudzbine.ShowDialog();
            }
        }
    }
}
