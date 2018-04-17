namespace NovaTehnika
{
    partial class frmStanjaPorudzbina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStanjaPorudzbina));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.grpStanje = new System.Windows.Forms.GroupBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnNadji = new System.Windows.Forms.Button();
            this.txtSifraStanja = new System.Windows.Forms.TextBox();
            this.lblSifraStanja = new System.Windows.Forms.Label();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpStanje.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(182, 85);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(14, 106);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(52, 20);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(72, 106);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(122, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // grpStanje
            // 
            this.grpStanje.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpStanje.Controls.Add(this.btnUkloni);
            this.grpStanje.Controls.Add(this.btnIzmeni);
            this.grpStanje.Controls.Add(this.btnNadji);
            this.grpStanje.Controls.Add(this.txtSifraStanja);
            this.grpStanje.Controls.Add(this.lblSifraStanja);
            this.grpStanje.Location = new System.Drawing.Point(14, 132);
            this.grpStanje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpStanje.Name = "grpStanje";
            this.grpStanje.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpStanje.Size = new System.Drawing.Size(182, 76);
            this.grpStanje.TabIndex = 16;
            this.grpStanje.TabStop = false;
            this.grpStanje.Text = "Obrada stanja";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(118, 48);
            this.btnUkloni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(50, 22);
            this.btnUkloni.TabIndex = 5;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(63, 48);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(50, 22);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnNadji
            // 
            this.btnNadji.Location = new System.Drawing.Point(8, 48);
            this.btnNadji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNadji.Name = "btnNadji";
            this.btnNadji.Size = new System.Drawing.Size(50, 22);
            this.btnNadji.TabIndex = 3;
            this.btnNadji.Text = "Nađi";
            this.btnNadji.UseVisualStyleBackColor = true;
            this.btnNadji.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // txtSifraStanja
            // 
            this.txtSifraStanja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSifraStanja.Location = new System.Drawing.Point(105, 19);
            this.txtSifraStanja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifraStanja.Name = "txtSifraStanja";
            this.txtSifraStanja.Size = new System.Drawing.Size(62, 20);
            this.txtSifraStanja.TabIndex = 2;
            // 
            // lblSifraStanja
            // 
            this.lblSifraStanja.AutoSize = true;
            this.lblSifraStanja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSifraStanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraStanja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSifraStanja.Location = new System.Drawing.Point(6, 20);
            this.lblSifraStanja.Name = "lblSifraStanja";
            this.lblSifraStanja.Size = new System.Drawing.Size(93, 18);
            this.lblSifraStanja.TabIndex = 11;
            this.lblSifraStanja.Text = "Šifra stanja";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(22, 214);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 22);
            this.btnUnos.TabIndex = 6;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(107, 214);
            this.btnOsvezi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(75, 22);
            this.btnOsvezi.TabIndex = 7;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // frmStanjaPorudzbina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 243);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.grpStanje);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStanjaPorudzbina";
            this.Text = "Stanja porudž.";
            this.Load += new System.EventHandler(this.frmStanjaPorudzbine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpStanje.ResumeLayout(false);
            this.grpStanje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.GroupBox grpStanje;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnNadji;
        private System.Windows.Forms.TextBox txtSifraStanja;
        private System.Windows.Forms.Label lblSifraStanja;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnOsvezi;
    }
}