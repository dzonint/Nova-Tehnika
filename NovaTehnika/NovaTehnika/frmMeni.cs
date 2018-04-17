using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaTehnika
{
    public partial class frmMeni : Form
    {
        public frmMeni()
        {
            InitializeComponent();
        }

        private void btnDodajPorudzbinu_Click(object sender, EventArgs e)
        {
            frmPorudzbine formaPorudzbina = new frmPorudzbine();
            formaPorudzbina.ShowDialog();
        }

        private void btnProizvodi_Click(object sender, EventArgs e)
        {
            frmProizvodi formaProizvodi = new frmProizvodi();
            formaProizvodi.ShowDialog();
        }

        private void btnStanjaPorudžbine_Click(object sender, EventArgs e)
        {
            frmStanjaPorudzbina formaStanjaPorudzbina = new frmStanjaPorudzbina();
            formaStanjaPorudzbina.ShowDialog();
        }

        private void btnKategorije_Click(object sender, EventArgs e)
        {
            frmKategorije formaKategorije = new frmKategorije();
            formaKategorije.ShowDialog();
        }

        private void btnDostavljaci_Click(object sender, EventArgs e)
        {
            frmDostavljaci formaDostavljaci = new frmDostavljaci();
            formaDostavljaci.ShowDialog();
        }
    }
}
