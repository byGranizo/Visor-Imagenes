namespace Visor_Imagenes
{
    partial class VisorImg
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
            this.components = new System.ComponentModel.Container();
            this.ofdImagenes = new System.Windows.Forms.OpenFileDialog();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAnt = new System.Windows.Forms.ToolStripButton();
            this.btSig = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btRotIzda = new System.Windows.Forms.ToolStripButton();
            this.btRotDcha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btMas = new System.Windows.Forms.ToolStripButton();
            this.btMenos = new System.Windows.Forms.ToolStripButton();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.msMenu.SuspendLayout();
            this.tsBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdImagenes
            // 
            this.ofdImagenes.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.gif|All files|*.*";
            this.ofdImagenes.Multiselect = true;
            this.ofdImagenes.Title = "Abrir imagen...";
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(980, 24);
            this.msMenu.TabIndex = 11;
            this.msMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::Visor_Imagenes.Properties.Resources.boton_abrir_archivo;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cerrarToolStripMenuItem.Text = "&Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // tsBarraHerramientas
            // 
            this.tsBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAbrir,
            this.toolStripSeparator1,
            this.btAnt,
            this.btSig,
            this.toolStripSeparator2,
            this.btRotIzda,
            this.btRotDcha,
            this.toolStripSeparator3,
            this.btMas,
            this.btMenos});
            this.tsBarraHerramientas.Location = new System.Drawing.Point(0, 24);
            this.tsBarraHerramientas.Name = "tsBarraHerramientas";
            this.tsBarraHerramientas.Size = new System.Drawing.Size(980, 25);
            this.tsBarraHerramientas.TabIndex = 12;
            this.tsBarraHerramientas.Text = "toolStrip1";
            // 
            // btAbrir
            // 
            this.btAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAbrir.Image = global::Visor_Imagenes.Properties.Resources.boton_abrir_archivo;
            this.btAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(23, 22);
            this.btAbrir.Text = "Abrir (Ctrl + A)";
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btAnt
            // 
            this.btAnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAnt.Enabled = false;
            this.btAnt.Image = global::Visor_Imagenes.Properties.Resources.flecha_hacia_la_izquierda;
            this.btAnt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAnt.Name = "btAnt";
            this.btAnt.Size = new System.Drawing.Size(23, 22);
            this.btAnt.Text = "Anterior";
            this.btAnt.Click += new System.EventHandler(this.btAnt_Click);
            // 
            // btSig
            // 
            this.btSig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSig.Enabled = false;
            this.btSig.Image = global::Visor_Imagenes.Properties.Resources.flecha_derecha;
            this.btSig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSig.Name = "btSig";
            this.btSig.Size = new System.Drawing.Size(23, 22);
            this.btSig.Text = "Siguiente";
            this.btSig.Click += new System.EventHandler(this.btSig_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btRotIzda
            // 
            this.btRotIzda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRotIzda.Enabled = false;
            this.btRotIzda.Image = global::Visor_Imagenes.Properties.Resources.deshacer_flecha;
            this.btRotIzda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRotIzda.Name = "btRotIzda";
            this.btRotIzda.Size = new System.Drawing.Size(23, 22);
            this.btRotIzda.Text = "Rotar 90º Izda";
            this.btRotIzda.Click += new System.EventHandler(this.btRotIzda_Click);
            // 
            // btRotDcha
            // 
            this.btRotDcha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRotDcha.Enabled = false;
            this.btRotDcha.Image = global::Visor_Imagenes.Properties.Resources.actualizar_flecha;
            this.btRotDcha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRotDcha.Name = "btRotDcha";
            this.btRotDcha.Size = new System.Drawing.Size(23, 22);
            this.btRotDcha.Text = "Rotar 90º Dcha";
            this.btRotDcha.Click += new System.EventHandler(this.btRotDcha_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btMas
            // 
            this.btMas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btMas.Enabled = false;
            this.btMas.Image = global::Visor_Imagenes.Properties.Resources.signo_mas_en_un_circulo_negro;
            this.btMas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(23, 22);
            this.btMas.Text = "Zoom in";
            this.btMas.Click += new System.EventHandler(this.btMas_Click);
            // 
            // btMenos
            // 
            this.btMenos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btMenos.Enabled = false;
            this.btMenos.Image = global::Visor_Imagenes.Properties.Resources.menos;
            this.btMenos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(23, 22);
            this.btMenos.Text = "Zoom out";
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // pbNext
            // 
            this.pbNext.Location = new System.Drawing.Point(814, 343);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(150, 84);
            this.pbNext.TabIndex = 10;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.btSig_Click);
            // 
            // pbPrev
            // 
            this.pbPrev.Location = new System.Drawing.Point(12, 343);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(150, 84);
            this.pbPrev.TabIndex = 8;
            this.pbPrev.TabStop = false;
            this.pbPrev.Click += new System.EventHandler(this.btAnt_Click);
            // 
            // pbImagenes
            // 
            this.pbImagenes.Location = new System.Drawing.Point(168, 67);
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
            // VisorImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 439);
            this.Controls.Add(this.tsBarraHerramientas);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.pbImagenes);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "VisorImg";
            this.Text = "Visor";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.OpenFileDialog ofdImagenes;
        private System.Windows.Forms.PictureBox pbPrev;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsBarraHerramientas;
        private System.Windows.Forms.ToolStripButton btAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btAnt;
        private System.Windows.Forms.ToolStripButton btSig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btRotIzda;
        private System.Windows.Forms.ToolStripButton btRotDcha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btMas;
        private System.Windows.Forms.ToolStripButton btMenos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

