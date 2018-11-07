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
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenes
            // 
            this.pbImagenes.Location = new System.Drawing.Point(59, 79);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(640, 360);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenes.TabIndex = 0;
            this.pbImagenes.TabStop = false;
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
            this.btAnt.Location = new System.Drawing.Point(217, 510);
            this.btAnt.Name = "btAnt";
            this.btAnt.Size = new System.Drawing.Size(75, 23);
            this.btAnt.TabIndex = 2;
            this.btAnt.Text = "<<";
            this.btAnt.UseVisualStyleBackColor = true;
            this.btAnt.Click += new System.EventHandler(this.btAnt_Click);
            // 
            // btSig
            // 
            this.btSig.Location = new System.Drawing.Point(408, 510);
            this.btSig.Name = "btSig";
            this.btSig.Size = new System.Drawing.Size(75, 23);
            this.btSig.TabIndex = 3;
            this.btSig.Text = ">>";
            this.btSig.UseVisualStyleBackColor = true;
            this.btSig.Click += new System.EventHandler(this.btSig_Click);
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.btSig);
            this.Controls.Add(this.btAnt);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.pbImagenes);
            this.Name = "Visor";
            this.Text = "Visor";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.OpenFileDialog ofdImagenes;
        private System.Windows.Forms.Button btAnt;
        private System.Windows.Forms.Button btSig;
    }
}

