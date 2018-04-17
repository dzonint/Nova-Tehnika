namespace NovaTehnika
{
    partial class frmDostavljaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDostavljaci));
            this.txtNazivKontakta = new System.Windows.Forms.TextBox();
            this.lblNazivKontakta = new System.Windows.Forms.Label();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.grpDostavljac = new System.Windows.Forms.GroupBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnNadji = new System.Windows.Forms.Button();
            this.txtSifraDostavljaca = new System.Windows.Forms.TextBox();
            this.lblSifraDostavljaca = new System.Windows.Forms.Label();
            this.txtNazivKompanije = new System.Windows.Forms.TextBox();
            this.lblNazivKompanije = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.grpDostavljac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivKontakta
            // 
            this.txtNazivKontakta.Location = new System.Drawing.Point(149, 147);
            this.txtNazivKontakta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNazivKontakta.Name = "txtNazivKontakta";
            this.txtNazivKontakta.Size = new System.Drawing.Size(256, 20);
            this.txtNazivKontakta.TabIndex = 2;
            // 
            // lblNazivKontakta
            // 
            this.lblNazivKontakta.AutoSize = true;
            this.lblNazivKontakta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivKontakta.Location = new System.Drawing.Point(16, 145);
            this.lblNazivKontakta.Name = "lblNazivKontakta";
            this.lblNazivKontakta.Size = new System.Drawing.Size(127, 20);
            this.lblNazivKontakta.TabIndex = 34;
            this.lblNazivKontakta.Text = "Naziv kontakta";
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(218, 252);
            this.btnOsvezi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(75, 22);
            this.btnOsvezi.TabIndex = 9;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(136, 252);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 22);
            this.btnUnos.TabIndex = 8;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // grpDostavljac
            // 
            this.grpDostavljac.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpDostavljac.Controls.Add(this.btnUkloni);
            this.grpDostavljac.Controls.Add(this.btnIzmeni);
            this.grpDostavljac.Controls.Add(this.btnNadji);
            this.grpDostavljac.Controls.Add(this.txtSifraDostavljaca);
            this.grpDostavljac.Controls.Add(this.lblSifraDostavljaca);
            this.grpDostavljac.Location = new System.Drawing.Point(12, 198);
            this.grpDostavljac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDostavljac.Name = "grpDostavljac";
            this.grpDostavljac.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDostavljac.Size = new System.Drawing.Size(393, 46);
            this.grpDostavljac.TabIndex = 31;
            this.grpDostavljac.TabStop = false;
            this.grpDostavljac.Text = "Obrada dostavljača";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(326, 15);
            this.btnUkloni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(49, 22);
            this.btnUkloni.TabIndex = 7;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(274, 15);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(46, 22);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnNadji
            // 
            this.btnNadji.Location = new System.Drawing.Point(215, 15);
            this.btnNadji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNadji.Name = "btnNadji";
            this.btnNadji.Size = new System.Drawing.Size(53, 22);
            this.btnNadji.TabIndex = 5;
            this.btnNadji.Text = "Nađi";
            this.btnNadji.UseVisualStyleBackColor = true;
            this.btnNadji.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // txtSifraDostavljaca
            // 
            this.txtSifraDostavljaca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSifraDostavljaca.Location = new System.Drawing.Point(137, 17);
            this.txtSifraDostavljaca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifraDostavljaca.Name = "txtSifraDostavljaca";
            this.txtSifraDostavljaca.Size = new System.Drawing.Size(62, 20);
            this.txtSifraDostavljaca.TabIndex = 4;
            // 
            // lblSifraDostavljaca
            // 
            this.lblSifraDostavljaca.AutoSize = true;
            this.lblSifraDostavljaca.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSifraDostavljaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraDostavljaca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSifraDostavljaca.Location = new System.Drawing.Point(5, 18);
            this.lblSifraDostavljaca.Name = "lblSifraDostavljaca";
            this.lblSifraDostavljaca.Size = new System.Drawing.Size(129, 17);
            this.lblSifraDostavljaca.TabIndex = 11;
            this.lblSifraDostavljaca.Text = "Šifra dostavljača";
            // 
            // txtNazivKompanije
            // 
            this.txtNazivKompanije.Location = new System.Drawing.Point(149, 124);
            this.txtNazivKompanije.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNazivKompanije.Name = "txtNazivKompanije";
            this.txtNazivKompanije.Size = new System.Drawing.Size(256, 20);
            this.txtNazivKompanije.TabIndex = 1;
            // 
            // lblNazivKompanije
            // 
            this.lblNazivKompanije.AutoSize = true;
            this.lblNazivKompanije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivKompanije.Location = new System.Drawing.Point(5, 122);
            this.lblNazivKompanije.Name = "lblNazivKompanije";
            this.lblNazivKompanije.Size = new System.Drawing.Size(138, 20);
            this.lblNazivKompanije.TabIndex = 29;
            this.lblNazivKompanije.Text = "Naziv kompanije";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 112);
            this.dataGridView1.TabIndex = 28;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(149, 170);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefon.MaxLength = 10;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(131, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(74, 168);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(69, 20);
            this.lblTelefon.TabIndex = 36;
            this.lblTelefon.Text = "Telefon";
            // 
            // frmDostavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 285);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtNazivKontakta);
            this.Controls.Add(this.lblNazivKontakta);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.grpDostavljac);
            this.Controls.Add(this.txtNazivKompanije);
            this.Controls.Add(this.lblNazivKompanije);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDostavljaci";
            this.Text = "Dostavljači";
            this.Load += new System.EventHandler(this.frmDostavljaci_Load);
            this.grpDostavljac.ResumeLayout(false);
            this.grpDostavljac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNazivKontakta;
        private System.Windows.Forms.Label lblNazivKontakta;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.GroupBox grpDostavljac;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnNadji;
        private System.Windows.Forms.TextBox txtSifraDostavljaca;
        private System.Windows.Forms.Label lblSifraDostavljaca;
        private System.Windows.Forms.TextBox txtNazivKompanije;
        private System.Windows.Forms.Label lblNazivKompanije;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
    }
}