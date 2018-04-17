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
    public partial class frmStanjaPorudzbina : Form
    {
        string KonekcioniString;
        SqlConnection Konekcija;
        SqlCommand Komanda;

        public frmStanjaPorudzbina()
        {
            InitializeComponent();
        }

        private void frmStanjaPorudzbine_Load(object sender, EventArgs e)
        {
            KonekcioniString = ConfigurationManager.ConnectionStrings["KonekcioniString"].ConnectionString;
            Konekcija = new SqlConnection(KonekcioniString);
            OsveziEkran();
        }

        private void OsveziEkran()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                Komanda = new SqlCommand("sp_PrikaziStanja", Konekcija);
                Komanda.CommandType = CommandType.StoredProcedure;

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

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Popunite sva polja pre unosa.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    Komanda = new SqlCommand("sp_UnesiStanje", Konekcija);
                    Komanda.CommandType = CommandType.StoredProcedure;
                    Komanda.Parameters.Add("@NazivStanja", SqlDbType.NVarChar).Value = txtNaziv.Text;

                    Konekcija.Open();
                    try
                    {
                        Komanda.ExecuteNonQuery();
                        MessageBox.Show("Stanje je uspešno uneto.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtSifraStanja.Text == "")
            {
                MessageBox.Show("Unesite šifru stanja.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    Komanda = new SqlCommand("sp_VratiStanjePoSifri", Konekcija);
                    Komanda.CommandType = CommandType.StoredProcedure;
                    Komanda.Parameters.Add("@SifraStanja", SqlDbType.Int).Value = int.Parse(txtSifraStanja.Text);
                    Komanda.Parameters.Add("@NazivStanja", SqlDbType.NVarChar, 50);
                    Komanda.Parameters["@NazivStanja"].Direction = ParameterDirection.Output;
                    Konekcija.Open();
                    try
                    {
                        Komanda.ExecuteNonQuery();
                        txtNaziv.Text = Komanda.Parameters["@NazivStanja"].Value.ToString();
                        if (txtNaziv.Text == "")
                            MessageBox.Show("Stanje sa zadatom šifrom nije pronađeno.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nastala je greška - " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtNaziv.Text == "" || txtSifraStanja.Text == "")
            {
                MessageBox.Show("Popunite sva polja pre ažuriranja.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    Komanda = new SqlCommand("sp_VratiStanjePoSifri", Konekcija);
                    Komanda.CommandType = CommandType.StoredProcedure;
                    Komanda.Parameters.Add("@SifraStanja", SqlDbType.Int).Value = int.Parse(txtSifraStanja.Text);
                    Komanda.Parameters.Add("@NazivStanja", SqlDbType.NVarChar, 50);
                    Komanda.Parameters["@NazivStanja"].Direction = ParameterDirection.Output;
                    Konekcija.Open();
                    try
                    {
                        Komanda.ExecuteNonQuery();
                        if (Komanda.Parameters["@NazivStanja"].Value.ToString() != "")
                        {
                            var PotvrdiIzmenu = MessageBox.Show("Potvrdite izmenu stanja " + txtSifraStanja.Text + ".", "Potvrdite izmenu", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                            if (PotvrdiIzmenu == DialogResult.OK)
                            {
                                Komanda = new SqlCommand("sp_AzurirajStanje", Konekcija);
                                Komanda.CommandType = CommandType.StoredProcedure;
                                Komanda.Parameters.Add("@SifraStanja", SqlDbType.Int).Value = int.Parse(txtSifraStanja.Text);
                                Komanda.Parameters.Add("@NazivStanja", SqlDbType.NVarChar).Value = txtNaziv.Text;
                                try
                                {
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Stanje je uspešno ažurirano.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Nastala je greška - " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Stanje sa zadatom šifrom nije pronađeno.");
                            txtSifraStanja.Text = "";
                            txtSifraStanja.Focus();
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
            if (txtSifraStanja.Text == "")
            {
                MessageBox.Show("Unesite šifru stanja.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    Komanda = new SqlCommand("sp_VratiStanjePoSifri", Konekcija);
                    Komanda.CommandType = CommandType.StoredProcedure;
                    Komanda.Parameters.Add("@SifraStanja", SqlDbType.Int).Value = int.Parse(txtSifraStanja.Text);
                    Komanda.Parameters.Add("@NazivStanja", SqlDbType.NVarChar, 50);
                    Komanda.Parameters["@NazivStanja"].Direction = ParameterDirection.Output;
                    Konekcija.Open();
                    try
                    {
                        Komanda.ExecuteNonQuery();
                        if (Komanda.Parameters["@NazivStanja"].Value.ToString() != "")
                        {
                            var PotvrdiUklanjanje = MessageBox.Show("Potvrdite uklanjanje stanja " + txtSifraStanja.Text + ".", "Potvrdite uklanjanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                            if (PotvrdiUklanjanje == DialogResult.OK)
                            {
                                Komanda = new SqlCommand("sp_UkloniStanje", Konekcija);
                                Komanda.CommandType = CommandType.StoredProcedure;
                                Komanda.Parameters.Add("@SifraStanja", SqlDbType.Int).Value = int.Parse(txtSifraStanja.Text);
                                try
                                {
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Stanje je uspešno uklonjeno.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Nastala je greška - " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Stanje sa zadatom šifrom nije pronađeno.");
                            txtSifraStanja.Text = "";
                            txtSifraStanja.Focus();
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

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            txtSifraStanja.Text = "";
            txtNaziv.Text = "";
        }
    }
}
