namespace NovaTehnika
{
    partial class frmProizvodi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProizvodi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.grpProizvod = new System.Windows.Forms.GroupBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnNadji = new System.Windows.Forms.Button();
            this.txtSifraProizvoda = new System.Windows.Forms.TextBox();
            this.lblSifraProizvoda = new System.Windows.Forms.Label();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpProizvod.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(41, 171);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(52, 20);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(102, 173);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(251, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(42, 197);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(51, 20);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "Cena";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(102, 199);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(91, 20);
            this.txtCena.TabIndex = 2;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorija.Location = new System.Drawing.Point(6, 225);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(90, 20);
            this.lblKategorija.TabIndex = 5;
            this.lblKategorija.Text = "Kategorija";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(102, 227);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(177, 21);
            this.cmbKategorija.TabIndex = 3;
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(102, 256);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(177, 21);
            this.cmbDobavljac.TabIndex = 4;
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobavljac.Location = new System.Drawing.Point(6, 254);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(87, 20);
            this.lblDobavljac.TabIndex = 7;
            this.lblDobavljac.Text = "Dobavljač";
            // 
            // grpProizvod
            // 
            this.grpProizvod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpProizvod.Controls.Add(this.btnUkloni);
            this.grpProizvod.Controls.Add(this.btnIzmeni);
            this.grpProizvod.Controls.Add(this.btnNadji);
            this.grpProizvod.Controls.Add(this.txtSifraProizvoda);
            this.grpProizvod.Controls.Add(this.lblSifraProizvoda);
            this.grpProizvod.Location = new System.Drawing.Point(7, 283);
            this.grpProizvod.Name = "grpProizvod";
            this.grpProizvod.Size = new System.Drawing.Size(362, 48);
            this.grpProizvod.TabIndex = 15;
            this.grpProizvod.TabStop = false;
            this.grpProizvod.Text = "Obrada proizvoda";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(307, 16);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(49, 23);
            this.btnUkloni.TabIndex = 10;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(252, 16);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(49, 23);
            this.btnIzmeni.TabIndex = 9;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnNadji
            // 
            this.btnNadji.Location = new System.Drawing.Point(197, 16);
            this.btnNadji.Name = "btnNadji";
            this.btnNadji.Size = new System.Drawing.Size(49, 23);
            this.btnNadji.TabIndex = 8;
            this.btnNadji.Text = "Nađi";
            this.btnNadji.UseVisualStyleBackColor = true;
            this.btnNadji.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // txtSifraProizvoda
            // 
            this.txtSifraProizvoda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSifraProizvoda.Location = new System.Drawing.Point(129, 18);
            this.txtSifraProizvoda.Name = "txtSifraProizvoda";
            this.txtSifraProizvoda.Size = new System.Drawing.Size(57, 20);
            this.txtSifraProizvoda.TabIndex = 7;
            // 
            // lblSifraProizvoda
            // 
            this.lblSifraProizvoda.AutoSize = true;
            this.lblSifraProizvoda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSifraProizvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraProizvoda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSifraProizvoda.Location = new System.Drawing.Point(7, 19);
            this.lblSifraProizvoda.Name = "lblSifraProizvoda";
            this.lblSifraProizvoda.Size = new System.Drawing.Size(118, 17);
            this.lblSifraProizvoda.TabIndex = 11;
            this.lblSifraProizvoda.Text = "Šifra proizvoda";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(288, 227);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(288, 254);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvezi.TabIndex = 6;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 337);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.grpProizvod);
            this.Controls.Add(this.cmbDobavljac);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProizvodi";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.frmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpProizvod.ResumeLayout(false);
            this.grpProizvod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.GroupBox grpProizvod;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnNadji;
        private System.Windows.Forms.TextBox txtSifraProizvoda;
        private System.Windows.Forms.Label lblSifraProizvoda;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnOsvezi;
    }
}