namespace NovaTehnika
{
    partial class frmMeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeni));
            this.btnPorudzbine = new System.Windows.Forms.Button();
            this.btnProizvodi = new System.Windows.Forms.Button();
            this.grpKonektovanaArhitektura = new System.Windows.Forms.GroupBox();
            this.grpProcedure = new System.Windows.Forms.GroupBox();
            this.btnStanjaPorudžbina = new System.Windows.Forms.Button();
            this.grpOkidaci = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDostavljaci = new System.Windows.Forms.Button();
            this.btnKategorije = new System.Windows.Forms.Button();
            this.picNovaTehnika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpKonektovanaArhitektura.SuspendLayout();
            this.grpProcedure.SuspendLayout();
            this.grpOkidaci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNovaTehnika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPorudzbine
            // 
            this.btnPorudzbine.Location = new System.Drawing.Point(6, 19);
            this.btnPorudzbine.Name = "btnPorudzbine";
            this.btnPorudzbine.Size = new System.Drawing.Size(75, 39);
            this.btnPorudzbine.TabIndex = 3;
            this.btnPorudzbine.Text = "Porudžbine";
            this.btnPorudzbine.UseVisualStyleBackColor = true;
            this.btnPorudzbine.Click += new System.EventHandler(this.btnDodajPorudzbinu_Click);
            // 
            // btnProizvodi
            // 
            this.btnProizvodi.Location = new System.Drawing.Point(197, 39);
            this.btnProizvodi.Name = "btnProizvodi";
            this.btnProizvodi.Size = new System.Drawing.Size(75, 39);
            this.btnProizvodi.TabIndex = 5;
            this.btnProizvodi.Text = "Proizvodi";
            this.btnProizvodi.UseVisualStyleBackColor = true;
            this.btnProizvodi.Click += new System.EventHandler(this.btnProizvodi_Click);
            // 
            // grpKonektovanaArhitektura
            // 
            this.grpKonektovanaArhitektura.Controls.Add(this.grpProcedure);
            this.grpKonektovanaArhitektura.Controls.Add(this.grpOkidaci);
            this.grpKonektovanaArhitektura.Controls.Add(this.btnProizvodi);
            this.grpKonektovanaArhitektura.Location = new System.Drawing.Point(12, 255);
            this.grpKonektovanaArhitektura.Name = "grpKonektovanaArhitektura";
            this.grpKonektovanaArhitektura.Size = new System.Drawing.Size(283, 94);
            this.grpKonektovanaArhitektura.TabIndex = 2;
            this.grpKonektovanaArhitektura.TabStop = false;
            this.grpKonektovanaArhitektura.Text = "Konektovana arhitektura";
            // 
            // grpProcedure
            // 
            this.grpProcedure.Controls.Add(this.btnStanjaPorudžbina);
            this.grpProcedure.Location = new System.Drawing.Point(102, 20);
            this.grpProcedure.Name = "grpProcedure";
            this.grpProcedure.Size = new System.Drawing.Size(89, 63);
            this.grpProcedure.TabIndex = 3;
            this.grpProcedure.TabStop = false;
            this.grpProcedure.Text = "Procedure";
            // 
            // btnStanjaPorudžbina
            // 
            this.btnStanjaPorudžbina.Location = new System.Drawing.Point(6, 19);
            this.btnStanjaPorudžbina.Name = "btnStanjaPorudžbina";
            this.btnStanjaPorudžbina.Size = new System.Drawing.Size(75, 39);
            this.btnStanjaPorudžbina.TabIndex = 4;
            this.btnStanjaPorudžbina.Text = "Stanja porudžbina";
            this.btnStanjaPorudžbina.UseVisualStyleBackColor = true;
            this.btnStanjaPorudžbina.Click += new System.EventHandler(this.btnStanjaPorudžbine_Click);
            // 
            // grpOkidaci
            // 
            this.grpOkidaci.Controls.Add(this.btnPorudzbine);
            this.grpOkidaci.Location = new System.Drawing.Point(7, 20);
            this.grpOkidaci.Name = "grpOkidaci";
            this.grpOkidaci.Size = new System.Drawing.Size(89, 63);
            this.grpOkidaci.TabIndex = 2;
            this.grpOkidaci.TabStop = false;
            this.grpOkidaci.Text = "Okidači";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDostavljaci);
            this.groupBox1.Controls.Add(this.btnKategorije);
            this.groupBox1.Location = new System.Drawing.Point(69, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diskonektovana arhitektura";
            // 
            // btnDostavljaci
            // 
            this.btnDostavljaci.Location = new System.Drawing.Point(87, 19);
            this.btnDostavljaci.Name = "btnDostavljaci";
            this.btnDostavljaci.Size = new System.Drawing.Size(75, 39);
            this.btnDostavljaci.TabIndex = 2;
            this.btnDostavljaci.Text = "Dostavljači";
            this.btnDostavljaci.UseVisualStyleBackColor = true;
            this.btnDostavljaci.Click += new System.EventHandler(this.btnDostavljaci_Click);
            // 
            // btnKategorije
            // 
            this.btnKategorije.Location = new System.Drawing.Point(6, 19);
            this.btnKategorije.Name = "btnKategorije";
            this.btnKategorije.Size = new System.Drawing.Size(75, 39);
            this.btnKategorije.TabIndex = 1;
            this.btnKategorije.Text = "Kategorije proizvoda";
            this.btnKategorije.UseVisualStyleBackColor = true;
            this.btnKategorije.Click += new System.EventHandler(this.btnKategorije_Click);
            // 
            // picNovaTehnika
            // 
            this.picNovaTehnika.Image = ((System.Drawing.Image)(resources.GetObject("picNovaTehnika.Image")));
            this.picNovaTehnika.InitialImage = ((System.Drawing.Image)(resources.GetObject("picNovaTehnika.InitialImage")));
            this.picNovaTehnika.Location = new System.Drawing.Point(83, 3);
            this.picNovaTehnika.Name = "picNovaTehnika";
            this.picNovaTehnika.Size = new System.Drawing.Size(143, 131);
            this.picNovaTehnika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNovaTehnika.TabIndex = 5;
            this.picNovaTehnika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nova Tehnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(107, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lanac snabdevanja";
            // 
            // frmMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picNovaTehnika);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpKonektovanaArhitektura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMeni";
            this.Text = "Nova Tehnika";
            this.grpKonektovanaArhitektura.ResumeLayout(false);
            this.grpProcedure.ResumeLayout(false);
            this.grpOkidaci.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNovaTehnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPorudzbine;
        private System.Windows.Forms.Button btnProizvodi;
        private System.Windows.Forms.GroupBox grpKonektovanaArhitektura;
        private System.Windows.Forms.GroupBox grpProcedure;
        private System.Windows.Forms.Button btnStanjaPorudžbina;
        private System.Windows.Forms.GroupBox grpOkidaci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDostavljaci;
        private System.Windows.Forms.Button btnKategorije;
        private System.Windows.Forms.PictureBox picNovaTehnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

