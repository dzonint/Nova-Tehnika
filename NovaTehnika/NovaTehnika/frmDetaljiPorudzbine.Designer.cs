namespace NovaTehnika
{
    partial class frmDetaljiPorudzbine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiPorudzbine));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.lblProizvod = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblSifraPorudzbine = new System.Windows.Forms.Label();
            this.lblZaUplatu = new System.Windows.Forms.Label();
            this.lblSifraPorudzbineValue = new System.Windows.Forms.Label();
            this.lblZaUplatuValue = new System.Windows.Forms.Label();
            this.grpStavkaPorudzbine = new System.Windows.Forms.GroupBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnNadji = new System.Windows.Forms.Button();
            this.txtSifraStavke = new System.Windows.Forms.TextBox();
            this.lblSifraStavke = new System.Windows.Forms.Label();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpStavkaPorudzbine.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(96, 178);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(347, 21);
            this.cmbProizvod.TabIndex = 1;
            this.cmbProizvod.SelectedIndexChanged += new System.EventHandler(this.cmbProizvod_SelectedIndexChanged);
            // 
            // lblProizvod
            // 
            this.lblProizvod.AutoSize = true;
            this.lblProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProizvod.Location = new System.Drawing.Point(12, 179);
            this.lblProizvod.Name = "lblProizvod";
            this.lblProizvod.Size = new System.Drawing.Size(77, 20);
            this.lblProizvod.TabIndex = 2;
            this.lblProizvod.Text = "Proizvod";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(38, 205);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(51, 20);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "Cena";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(95, 205);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 2;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(95, 230);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(67, 20);
            this.txtKolicina.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.Location = new System.Drawing.Point(18, 230);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(71, 20);
            this.lblKolicina.TabIndex = 5;
            this.lblKolicina.Text = "Količina";
            // 
            // lblSifraPorudzbine
            // 
            this.lblSifraPorudzbine.AutoSize = true;
            this.lblSifraPorudzbine.Location = new System.Drawing.Point(290, 212);
            this.lblSifraPorudzbine.Name = "lblSifraPorudzbine";
            this.lblSifraPorudzbine.Size = new System.Drawing.Size(89, 13);
            this.lblSifraPorudzbine.TabIndex = 7;
            this.lblSifraPorudzbine.Text = "Šifra porudžbine :";
            // 
            // lblZaUplatu
            // 
            this.lblZaUplatu.AutoSize = true;
            this.lblZaUplatu.Location = new System.Drawing.Point(321, 230);
            this.lblZaUplatu.Name = "lblZaUplatu";
            this.lblZaUplatu.Size = new System.Drawing.Size(58, 13);
            this.lblZaUplatu.TabIndex = 8;
            this.lblZaUplatu.Text = "Za uplatu :";
            // 
            // lblSifraPorudzbineValue
            // 
            this.lblSifraPorudzbineValue.AutoSize = true;
            this.lblSifraPorudzbineValue.Location = new System.Drawing.Point(385, 212);
            this.lblSifraPorudzbineValue.Name = "lblSifraPorudzbineValue";
            this.lblSifraPorudzbineValue.Size = new System.Drawing.Size(0, 13);
            this.lblSifraPorudzbineValue.TabIndex = 9;
            // 
            // lblZaUplatuValue
            // 
            this.lblZaUplatuValue.AutoSize = true;
            this.lblZaUplatuValue.Location = new System.Drawing.Point(385, 230);
            this.lblZaUplatuValue.Name = "lblZaUplatuValue";
            this.lblZaUplatuValue.Size = new System.Drawing.Size(0, 13);
            this.lblZaUplatuValue.TabIndex = 10;
            // 
            // grpStavkaPorudzbine
            // 
            this.grpStavkaPorudzbine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpStavkaPorudzbine.Controls.Add(this.btnUkloni);
            this.grpStavkaPorudzbine.Controls.Add(this.btnIzmeni);
            this.grpStavkaPorudzbine.Controls.Add(this.btnNadji);
            this.grpStavkaPorudzbine.Controls.Add(this.txtSifraStavke);
            this.grpStavkaPorudzbine.Controls.Add(this.lblSifraStavke);
            this.grpStavkaPorudzbine.Location = new System.Drawing.Point(13, 256);
            this.grpStavkaPorudzbine.Name = "grpStavkaPorudzbine";
            this.grpStavkaPorudzbine.Size = new System.Drawing.Size(340, 48);
            this.grpStavkaPorudzbine.TabIndex = 14;
            this.grpStavkaPorudzbine.TabStop = false;
            this.grpStavkaPorudzbine.Text = "Obrada stavke";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(280, 16);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(49, 23);
            this.btnUkloni.TabIndex = 7;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(225, 16);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(49, 23);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnNadji
            // 
            this.btnNadji.Location = new System.Drawing.Point(170, 16);
            this.btnNadji.Name = "btnNadji";
            this.btnNadji.Size = new System.Drawing.Size(49, 23);
            this.btnNadji.TabIndex = 5;
            this.btnNadji.Text = "Nađi";
            this.btnNadji.UseVisualStyleBackColor = true;
            this.btnNadji.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // txtSifraStavke
            // 
            this.txtSifraStavke.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSifraStavke.Location = new System.Drawing.Point(107, 18);
            this.txtSifraStavke.Name = "txtSifraStavke";
            this.txtSifraStavke.Size = new System.Drawing.Size(57, 20);
            this.txtSifraStavke.TabIndex = 4;
            // 
            // lblSifraStavke
            // 
            this.lblSifraStavke.AutoSize = true;
            this.lblSifraStavke.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSifraStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraStavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSifraStavke.Location = new System.Drawing.Point(7, 19);
            this.lblSifraStavke.Name = "lblSifraStavke";
            this.lblSifraStavke.Size = new System.Drawing.Size(94, 17);
            this.lblSifraStavke.TabIndex = 11;
            this.lblSifraStavke.Text = "Šifra stavke";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(365, 256);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 8;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(365, 281);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvezi.TabIndex = 9;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // frmDetaljiPorudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 313);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.grpStavkaPorudzbine);
            this.Controls.Add(this.lblZaUplatuValue);
            this.Controls.Add(this.lblSifraPorudzbineValue);
            this.Controls.Add(this.lblZaUplatu);
            this.Controls.Add(this.lblSifraPorudzbine);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblProizvod);
            this.Controls.Add(this.cmbProizvod);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetaljiPorudzbine";
            this.Text = "Detalji porudžbine";
            this.Load += new System.EventHandler(this.frmDetaljiPorudzbine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpStavkaPorudzbine.ResumeLayout(false);
            this.grpStavkaPorudzbine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.Label lblProizvod;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblSifraPorudzbine;
        private System.Windows.Forms.Label lblZaUplatu;
        private System.Windows.Forms.Label lblSifraPorudzbineValue;
        private System.Windows.Forms.Label lblZaUplatuValue;
        private System.Windows.Forms.GroupBox grpStavkaPorudzbine;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnNadji;
        private System.Windows.Forms.TextBox txtSifraStavke;
        private System.Windows.Forms.Label lblSifraStavke;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnOsvezi;
    }
}