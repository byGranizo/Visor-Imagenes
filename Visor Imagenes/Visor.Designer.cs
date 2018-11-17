namespace Visor_Imagenes
{
    partial class Visor
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
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.btAbrir = new System.Windows.Forms.Button();
            this.ofdImagenes = new System.Windows.Forms.OpenFileDialog();
            this.btAnt = new System.Windows.Forms.Button();
            this.btSig = new System.Windows.Forms.Button();
            this.btRotIzda = new System.Windows.Forms.Button();
            this.btRotDcha = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenes
            // 
            this.pbImagenes.Location = new System.Drawing.Point(173, 79);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(640, 360);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenes.TabIndex = 0;
            this.pbImagenes.TabStop = false;
            this.pbImagenes.DoubleClick += new System.EventHandler(this.btMas_Click);
            this.pbImagenes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImagenes_MouseDown);
            this.pbImagenes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImagenes_MouseMove);
            this.pbImagenes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImagenes_MouseUp);
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(12, 12);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 23);
            this.btAbrir.TabIndex = 1;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // ofdImagenes
            // 
            this.ofdImagenes.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.gif|All files|*.*";
            this.ofdImagenes.Multiselect = true;
            this.ofdImagenes.Title = "Abrir imagen...";
            // 
            // btAnt
            // 
            this.btAnt.Enabled = false;
            this.btAnt.Location = new System.Drawing.Point(173, 510);
            this.btAnt.Name = "btAnt";
            this.btAnt.Size = new System.Drawing.Size(75, 23);
            this.btAnt.TabIndex = 2;
            this.btAnt.Text = "<<";
            this.btAnt.UseVisualStyleBackColor = true;
            this.btAnt.Click += new System.EventHandler(this.btAnt_Click);
            // 
            // btSig
            // 
            this.btSig.Enabled = false;
            this.btSig.Location = new System.Drawing.Point(254, 510);
            this.btSig.Name = "btSig";
            this.btSig.Size = new System.Drawing.Size(75, 23);
            this.btSig.TabIndex = 3;
            this.btSig.Text = ">>";
            this.btSig.UseVisualStyleBackColor = true;
            this.btSig.Click += new System.EventHandler(this.btSig_Click);
            // 
            // btRotIzda
            // 
            this.btRotIzda.Enabled = false;
            this.btRotIzda.Location = new System.Drawing.Point(409, 510);
            this.btRotIzda.Name = "btRotIzda";
            this.btRotIzda.Size = new System.Drawing.Size(75, 23);
            this.btRotIzda.TabIndex = 4;
            this.btRotIzda.Text = "90º Izda";
            this.btRotIzda.UseVisualStyleBackColor = true;
            this.btRotIzda.Click += new System.EventHandler(this.btRotIzda_Click);
            // 
            // btRotDcha
            // 
            this.btRotDcha.Enabled = false;
            this.btRotDcha.Location = new System.Drawing.Point(490, 510);
            this.btRotDcha.Name = "btRotDcha";
            this.btRotDcha.Size = new System.Drawing.Size(75, 23);
            this.btRotDcha.TabIndex = 5;
            this.btRotDcha.Text = "90º Dcha";
            this.btRotDcha.UseVisualStyleBackColor = true;
            this.btRotDcha.Click += new System.EventHandler(this.btRotDcha_Click);
            // 
            // btMas
            // 
            this.btMas.Enabled = false;
            this.btMas.Location = new System.Drawing.Point(652, 510);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(75, 23);
            this.btMas.TabIndex = 6;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = true;
            this.btMas.Click += new System.EventHandler(this.btMas_Click);
            // 
            // btMenos
            // 
            this.btMenos.Enabled = false;
            this.btMenos.Location = new System.Drawing.Point(734, 510);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(75, 23);
            this.btMenos.TabIndex = 7;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // pbPrev
            // 
            this.pbPrev.Location = new System.Drawing.Point(17, 355);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(150, 84);
            this.pbPrev.TabIndex = 8;
            this.pbPrev.TabStop = false;
            this.pbPrev.Click += new System.EventHandler(this.btAnt_Click);
            // 
            // pbNext
            // 
            this.pbNext.Location = new System.Drawing.Point(819, 355);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(150, 84);
            this.pbNext.TabIndex = 10;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.btSig_Click);
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 569);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btMas);
            this.Controls.Add(this.btRotDcha);
            this.Controls.Add(this.btRotIzda);
            this.Controls.Add(this.btSig);
            this.Controls.Add(this.btAnt);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.pbImagenes);
            this.Name = "Visor";
            this.Text = "Visor";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.OpenFileDialog ofdImagenes;
        private System.Windows.Forms.Button btAnt;
        private System.Windows.Forms.Button btSig;
        private System.Windows.Forms.Button btRotIzda;
        private System.Windows.Forms.Button btRotDcha;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.PictureBox pbPrev;
        private System.Windows.Forms.PictureBox pbNext;
    }
}

