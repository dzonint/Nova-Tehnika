namespace NovaTehnika
{
    partial class frmKategorije
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategorije));
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.grpKategorija = new System.Windows.Forms.GroupBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnNadji = new System.Windows.Forms.Button();
            this.txtSifraKategorije = new System.Windows.Forms.TextBox();
            this.lblSifraKategorije = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblOpcionalan = new System.Windows.Forms.Label();
            this.grpKategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(151, 246);
            this.btnOsvezi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(75, 22);
            this.btnOsvezi.TabIndex = 8;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(70, 246);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 22);
            this.btnUnos.TabIndex = 7;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // grpKategorija
            // 
            this.grpKategorija.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpKategorija.Controls.Add(this.btnUkloni);
            this.grpKategorija.Controls.Add(this.btnIzmeni);
            this.grpKategorija.Controls.Add(this.btnNadji);
            this.grpKategorija.Controls.Add(this.txtSifraKategorije);
            this.grpKategorija.Controls.Add(this.lblSifraKategorije);
            this.grpKategorija.Location = new System.Drawing.Point(12, 162);
            this.grpKategorija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKategorija.Name = "grpKategorija";
            this.grpKategorija.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKategorija.Size = new System.Drawing.Size(260, 76);
            this.grpKategorija.TabIndex = 22;
            this.grpKategorija.TabStop = false;
            this.grpKategorija.Text = "Obrada kategorije";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(174, 46);
            this.btnUkloni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(63, 22);
            this.btnUkloni.TabIndex = 6;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(108, 46);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(60, 22);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnNadji
            // 
            this.btnNadji.Location = new System.Drawing.Point(33, 46);
            this.btnNadji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNadji.Name = "btnNadji";
            this.btnNadji.Size = new System.Drawing.Size(69, 22);
            this.btnNadji.TabIndex = 4;
            this.btnNadji.Text = "Nađi";
            this.btnNadji.UseVisualStyleBackColor = true;
            this.btnNadji.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // txtSifraKategorije
            // 
            this.txtSifraKategorije.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSifraKategorije.Location = new System.Drawing.Point(164, 20);
            this.txtSifraKategorije.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifraKategorije.Name = "txtSifraKategorije";
            this.txtSifraKategorije.Size = new System.Drawing.Size(62, 20);
            this.txtSifraKategorije.TabIndex = 3;
            // 
            // lblSifraKategorije
            // 
            this.lblSifraKategorije.AutoSize = true;
            this.lblSifraKategorije.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSifraKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraKategorije.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSifraKategorije.Location = new System.Drawing.Point(36, 20);
            this.lblSifraKategorije.Name = "lblSifraKategorije";
            this.lblSifraKategorije.Size = new System.Drawing.Size(122, 18);
            this.lblSifraKategorije.TabIndex = 11;
            this.lblSifraKategorije.Text = "Šifra kategorije";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(70, 106);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(202, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(12, 106);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(52, 20);
            this.lblNaziv.TabIndex = 20;
            this.lblNaziv.Text = "Naziv";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 85);
            this.dataGridView1.TabIndex = 19;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(70, 129);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(202, 20);
            this.txtOpis.TabIndex = 2;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(12, 129);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(45, 20);
            this.lblOpis.TabIndex = 25;
            this.lblOpis.Text = "Opis";
            // 
            // lblOpcionalan
            // 
            this.lblOpcionalan.AutoSize = true;
            this.lblOpcionalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionalan.Location = new System.Drawing.Point(12, 149);
            this.lblOpcionalan.Name = "lblOpcionalan";
            this.lblOpcionalan.Size = new System.Drawing.Size(41, 9);
            this.lblOpcionalan.TabIndex = 27;
            this.lblOpcionalan.Text = "opcionalan";
            // 
            // frmKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 275);
            this.Controls.Add(this.lblOpcionalan);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.grpKategorija);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKategorije";
            this.Text = "Kategorije proizvoda";
            this.Load += new System.EventHandler(this.frmKategorije_Load);
            this.grpKategorija.ResumeLayout(false);
            this.grpKategorija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.GroupBox grpKategorija;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnNadji;
        private System.Windows.Forms.TextBox txtSifraKategorije;
        private System.Windows.Forms.Label lblSifraKategorije;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblOpcionalan;
    }
}