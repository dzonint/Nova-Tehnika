namespace NovaTehnika
{
    partial class frmPorudzbine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPorudzbine));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.cmbDostavljac = new System.Windows.Forms.ComboBox();
            this.lblDostavljac = new System.Windows.Forms.Label();
            this.cmbStanje = new System.Windows.Forms.ComboBox();
            this.lblStanje = new System.Windows.Forms.Label();
            this.cmbZaposleni = new System.Windows.Forms.ComboBox();
            this.lblZaposleni = new System.Windows.Forms.Label();
            this.dateDatumPorudzbine = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblRokIsporuke = new System.Windows.Forms.Label();
            this.dateRokIsporuke = new System.Windows.Forms.DateTimePicker();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.grpDetaljiPorudzbine = new System.Windows.Forms.GroupBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnNadji = new System.Windows.Forms.Button();
            this.txtSifraPorudzbine = new System.Windows.Forms.TextBox();
            this.lblSifraPorudzbine = new System.Windows.Forms.Label();
            this.grpOkidaci = new System.Windows.Forms.GroupBox();
            this.btnNepostojeceStanje = new System.Windows.Forms.Button();
            this.btnNepostojeciKlijent = new System.Windows.Forms.Button();
            this.btnIzmeniKlijenta = new System.Windows.Forms.Button();
            this.btnIzmeniStanje = new System.Windows.Forms.Button();
            this.btnUkloniStanje = new System.Windows.Forms.Button();
            this.btnUkloniKlijenta = new System.Windows.Forms.Button();
            this.btnDetaljiPorudzbine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDetaljiPorudzbine.SuspendLayout();
            this.grpOkidaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(663, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKlijent.Location = new System.Drawing.Point(40, 221);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(58, 20);
            this.lblKlijent.TabIndex = 1;
            this.lblKlijent.Text = "Klijent";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(104, 223);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(222, 21);
            this.cmbKlijent.TabIndex = 2;
            // 
            // cmbDostavljac
            // 
            this.cmbDostavljac.FormattingEnabled = true;
            this.cmbDostavljac.Location = new System.Drawing.Point(104, 252);
            this.cmbDostavljac.Name = "cmbDostavljac";
            this.cmbDostavljac.Size = new System.Drawing.Size(222, 21);
            this.cmbDostavljac.TabIndex = 3;
            // 
            // lblDostavljac
            // 
            this.lblDostavljac.AutoSize = true;
            this.lblDostavljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDostavljac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDostavljac.Location = new System.Drawing.Point(6, 250);
            this.lblDostavljac.Name = "lblDostavljac";
            this.lblDostavljac.Size = new System.Drawing.Size(92, 20);
            this.lblDostavljac.TabIndex = 3;
            this.lblDostavljac.Text = "Dostavljač";
            // 
            // cmbStanje
            // 
            this.cmbStanje.FormattingEnabled = true;
            this.cmbStanje.Location = new System.Drawing.Point(104, 279);
            this.cmbStanje.Name = "cmbStanje";
            this.cmbStanje.Size = new System.Drawing.Size(222, 21);
            this.cmbStanje.TabIndex = 4;
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStanje.Location = new System.Drawing.Point(37, 277);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(61, 20);
            this.lblStanje.TabIndex = 7;
            this.lblStanje.Text = "Stanje";
            // 
            // cmbZaposleni
            // 
            this.cmbZaposleni.FormattingEnabled = true;
            this.cmbZaposleni.Location = new System.Drawing.Point(104, 196);
            this.cmbZaposleni.Name = "cmbZaposleni";
            this.cmbZaposleni.Size = new System.Drawing.Size(222, 21);
            this.cmbZaposleni.TabIndex = 1;
            // 
            // lblZaposleni
            // 
            this.lblZaposleni.AutoSize = true;
            this.lblZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposleni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZaposleni.Location = new System.Drawing.Point(11, 194);
            this.lblZaposleni.Name = "lblZaposleni";
            this.lblZaposleni.Size = new System.Drawing.Size(87, 20);
            this.lblZaposleni.TabIndex = 5;
            this.lblZaposleni.Text = "Zaposleni";
            // 
            // dateDatumPorudzbine
            // 
            this.dateDatumPorudzbine.CustomFormat = "yyyy-MM-dd";
            this.dateDatumPorudzbine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDatumPorudzbine.Location = new System.Drawing.Point(498, 197);
            this.dateDatumPorudzbine.Name = "dateDatumPorudzbine";
            this.dateDatumPorudzbine.Size = new System.Drawing.Size(177, 20);
            this.dateDatumPorudzbine.TabIndex = 5;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDatum.Location = new System.Drawing.Point(336, 197);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(156, 20);
            this.lblDatum.TabIndex = 10;
            this.lblDatum.Text = "Datum porudžbine";
            // 
            // lblRokIsporuke
            // 
            this.lblRokIsporuke.AutoSize = true;
            this.lblRokIsporuke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRokIsporuke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRokIsporuke.Location = new System.Drawing.Point(378, 224);
            this.lblRokIsporuke.Name = "lblRokIsporuke";
            this.lblRokIsporuke.Size = new System.Drawing.Size(114, 20);
            this.lblRokIsporuke.TabIndex = 12;
            this.lblRokIsporuke.Text = "Rok isporuke";
            // 
            // dateRokIsporuke
            // 
            this.dateRokIsporuke.CustomFormat = "yyyy-MM-dd";
            this.dateRokIsporuke.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRokIsporuke.Location = new System.Drawing.Point(498, 223);
            this.dateRokIsporuke.Name = "dateRokIsporuke";
            this.dateRokIsporuke.Size = new System.Drawing.Size(177, 20);
            this.dateRokIsporuke.TabIndex = 6;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(520, 333);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 11;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(601, 333);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvezi.TabIndex = 12;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // grpDetaljiPorudzbine
            // 
            this.grpDetaljiPorudzbine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpDetaljiPorudzbine.Controls.Add(this.btnUkloni);
            this.grpDetaljiPorudzbine.Controls.Add(this.btnIzmeni);
            this.grpDetaljiPorudzbine.Controls.Add(this.btnNadji);
            this.grpDetaljiPorudzbine.Controls.Add(this.txtSifraPorudzbine);
            this.grpDetaljiPorudzbine.Controls.Add(this.lblSifraPorudzbine);
            this.grpDetaljiPorudzbine.Location = new System.Drawing.Point(340, 252);
            this.grpDetaljiPorudzbine.Name = "grpDetaljiPorudzbine";
            this.grpDetaljiPorudzbine.Size = new System.Drawing.Size(335, 48);
            this.grpDetaljiPorudzbine.TabIndex = 13;
            this.grpDetaljiPorudzbine.TabStop = false;
            this.grpDetaljiPorudzbine.Text = "Obrada porudžbine";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(280, 13);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(49, 23);
            this.btnUkloni.TabIndex = 10;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(225, 13);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(49, 23);
            this.btnIzmeni.TabIndex = 9;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnNadji
            // 
            this.btnNadji.Location = new System.Drawing.Point(173, 13);
            this.btnNadji.Name = "btnNadji";
            this.btnNadji.Size = new System.Drawing.Size(49, 23);
            this.btnNadji.TabIndex = 8;
            this.btnNadji.Text = "Nađi";
            this.btnNadji.UseVisualStyleBackColor = true;
            this.btnNadji.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // txtSifraPorudzbine
            // 
            this.txtSifraPorudzbine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSifraPorudzbine.Location = new System.Drawing.Point(125, 15);
            this.txtSifraPorudzbine.Name = "txtSifraPorudzbine";
            this.txtSifraPorudzbine.Size = new System.Drawing.Size(42, 20);
            this.txtSifraPorudzbine.TabIndex = 7;
            // 
            // lblSifraPorudzbine
            // 
            this.lblSifraPorudzbine.AutoSize = true;
            this.lblSifraPorudzbine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSifraPorudzbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraPorudzbine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSifraPorudzbine.Location = new System.Drawing.Point(6, 16);
            this.lblSifraPorudzbine.Name = "lblSifraPorudzbine";
            this.lblSifraPorudzbine.Size = new System.Drawing.Size(113, 15);
            this.lblSifraPorudzbine.TabIndex = 11;
            this.lblSifraPorudzbine.Text = "Šifra porudžbine";
            // 
            // grpOkidaci
            // 
            this.grpOkidaci.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpOkidaci.Controls.Add(this.btnNepostojeceStanje);
            this.grpOkidaci.Controls.Add(this.btnNepostojeciKlijent);
            this.grpOkidaci.Controls.Add(this.btnIzmeniKlijenta);
            this.grpOkidaci.Controls.Add(this.btnIzmeniStanje);
            this.grpOkidaci.Controls.Add(this.btnUkloniStanje);
            this.grpOkidaci.Controls.Add(this.btnUkloniKlijenta);
            this.grpOkidaci.Location = new System.Drawing.Point(15, 306);
            this.grpOkidaci.Name = "grpOkidaci";
            this.grpOkidaci.Size = new System.Drawing.Size(492, 50);
            this.grpOkidaci.TabIndex = 14;
            this.grpOkidaci.TabStop = false;
            this.grpOkidaci.Text = "Testiranje okidača";
            // 
            // btnNepostojeceStanje
            // 
            this.btnNepostojeceStanje.Location = new System.Drawing.Point(428, 19);
            this.btnNepostojeceStanje.Name = "btnNepostojeceStanje";
            this.btnNepostojeceStanje.Size = new System.Drawing.Size(58, 23);
            this.btnNepostojeceStanje.TabIndex = 19;
            this.btnNepostojeceStanje.Text = "N. stanje";
            this.btnNepostojeceStanje.UseVisualStyleBackColor = true;
            this.btnNepostojeceStanje.Click += new System.EventHandler(this.btnNepostojeceStanje_Click);
            // 
            // btnNepostojeciKlijent
            // 
            this.btnNepostojeciKlijent.Location = new System.Drawing.Point(367, 19);
            this.btnNepostojeciKlijent.Name = "btnNepostojeciKlijent";
            this.btnNepostojeciKlijent.Size = new System.Drawing.Size(58, 23);
            this.btnNepostojeciKlijent.TabIndex = 18;
            this.btnNepostojeciKlijent.Text = "N. klijent";
            this.btnNepostojeciKlijent.UseVisualStyleBackColor = true;
            this.btnNepostojeciKlijent.Click += new System.EventHandler(this.btnNepostojeciKlijent_Click);
            // 
            // btnIzmeniKlijenta
            // 
            this.btnIzmeniKlijenta.Location = new System.Drawing.Point(6, 19);
            this.btnIzmeniKlijenta.Name = "btnIzmeniKlijenta";
            this.btnIzmeniKlijenta.Size = new System.Drawing.Size(81, 23);
            this.btnIzmeniKlijenta.TabIndex = 14;
            this.btnIzmeniKlijenta.Text = "Izmeni klijenta";
            this.btnIzmeniKlijenta.UseVisualStyleBackColor = true;
            this.btnIzmeniKlijenta.Click += new System.EventHandler(this.btnIzmeniKlijenta_Click);
            // 
            // btnIzmeniStanje
            // 
            this.btnIzmeniStanje.Location = new System.Drawing.Point(93, 19);
            this.btnIzmeniStanje.Name = "btnIzmeniStanje";
            this.btnIzmeniStanje.Size = new System.Drawing.Size(81, 23);
            this.btnIzmeniStanje.TabIndex = 15;
            this.btnIzmeniStanje.Text = "Izmeni stanje";
            this.btnIzmeniStanje.UseVisualStyleBackColor = true;
            this.btnIzmeniStanje.Click += new System.EventHandler(this.btnIzmeniStanje_Click);
            // 
            // btnUkloniStanje
            // 
            this.btnUkloniStanje.Location = new System.Drawing.Point(267, 19);
            this.btnUkloniStanje.Name = "btnUkloniStanje";
            this.btnUkloniStanje.Size = new System.Drawing.Size(81, 23);
            this.btnUkloniStanje.TabIndex = 17;
            this.btnUkloniStanje.Text = "Ukloni stanje";
            this.btnUkloniStanje.UseVisualStyleBackColor = true;
            this.btnUkloniStanje.Click += new System.EventHandler(this.btnUkloniStanje_Click);
            // 
            // btnUkloniKlijenta
            // 
            this.btnUkloniKlijenta.Location = new System.Drawing.Point(180, 19);
            this.btnUkloniKlijenta.Name = "btnUkloniKlijenta";
            this.btnUkloniKlijenta.Size = new System.Drawing.Size(81, 23);
            this.btnUkloniKlijenta.TabIndex = 16;
            this.btnUkloniKlijenta.Text = "Ukloni klijenta";
            this.btnUkloniKlijenta.UseVisualStyleBackColor = true;
            this.btnUkloniKlijenta.Click += new System.EventHandler(this.btnUkloniKlijenta_Click);
            // 
            // btnDetaljiPorudzbine
            // 
            this.btnDetaljiPorudzbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetaljiPorudzbine.Location = new System.Drawing.Point(520, 307);
            this.btnDetaljiPorudzbine.Name = "btnDetaljiPorudzbine";
            this.btnDetaljiPorudzbine.Size = new System.Drawing.Size(155, 23);
            this.btnDetaljiPorudzbine.TabIndex = 13;
            this.btnDetaljiPorudzbine.Text = "Detalji porudžbine";
            this.btnDetaljiPorudzbine.UseVisualStyleBackColor = true;
            this.btnDetaljiPorudzbine.Click += new System.EventHandler(this.btnDetaljiPorudzbine_Click);
            // 
            // frmPorudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 362);
            this.Controls.Add(this.btnDetaljiPorudzbine);
            this.Controls.Add(this.grpOkidaci);
            this.Controls.Add(this.grpDetaljiPorudzbine);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.lblRokIsporuke);
            this.Controls.Add(this.dateRokIsporuke);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dateDatumPorudzbine);
            this.Controls.Add(this.cmbStanje);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.cmbZaposleni);
            this.Controls.Add(this.lblZaposleni);
            this.Controls.Add(this.cmbDostavljac);
            this.Controls.Add(this.lblDostavljac);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPorudzbine";
            this.Text = "Porudžbine";
            this.Load += new System.EventHandler(this.frmUnosPorudzbine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDetaljiPorudzbine.ResumeLayout(false);
            this.grpDetaljiPorudzbine.PerformLayout();
            this.grpOkidaci.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.ComboBox cmbDostavljac;
        private System.Windows.Forms.Label lblDostavljac;
        private System.Windows.Forms.ComboBox cmbStanje;
        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.ComboBox cmbZaposleni;
        private System.Windows.Forms.Label lblZaposleni;
        private System.Windows.Forms.DateTimePicker dateDatumPorudzbine;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblRokIsporuke;
        private System.Windows.Forms.DateTimePicker dateRokIsporuke;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.GroupBox grpDetaljiPorudzbine;
        private System.Windows.Forms.Label lblSifraPorudzbine;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnNadji;
        private System.Windows.Forms.TextBox txtSifraPorudzbine;
        private System.Windows.Forms.GroupBox grpOkidaci;
        private System.Windows.Forms.Button btnNepostojeceStanje;
        private System.Windows.Forms.Button btnNepostojeciKlijent;
        private System.Windows.Forms.Button btnIzmeniKlijenta;
        private System.Windows.Forms.Button btnIzmeniStanje;
        private System.Windows.Forms.Button btnUkloniStanje;
        private System.Windows.Forms.Button btnUkloniKlijenta;
        private System.Windows.Forms.Button btnDetaljiPorudzbine;
    }
}