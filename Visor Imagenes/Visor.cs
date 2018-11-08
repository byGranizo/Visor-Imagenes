﻿using System.Drawing;
using System.Windows.Forms;

using Visor;

namespace Visor_Imagenes
{
    public partial class Visor : Form
    {
        static int anchoVisor = 640;
        static int altoVisor = 360;
        VisorFoto v = new VisorFoto(anchoVisor, altoVisor);
        public Visor()
        {
            InitializeComponent();
        }

        private void btAbrir_Click(object sender, System.EventArgs e)
        {
            if (ofdImagenes.ShowDialog() == DialogResult.Cancel)
                return;

            foreach (string imagen in ofdImagenes.FileNames)
                v.Agregar_Foto((Bitmap)Bitmap.FromFile(imagen));
            

            pbImagenes.Image = v.Foto_Actual();

            btAnt.Enabled = true;
            btSig.Enabled = true;
            btRotIzda.Enabled = true;
            btRotDcha.Enabled = true;
            btMas.Enabled = true;
            btMenos.Enabled = true;
            
        }

        private void btAnt_Click(object sender, System.EventArgs e)
        {
            pbImagenes.Image = v.Prev_Foto();
        }

        private void btSig_Click(object sender, System.EventArgs e)
        {
            pbImagenes.Image = v.Next_Foto();
        }

        private void btRotIzda_Click(object sender, System.EventArgs e)
        {
            pbImagenes.Image = v.rotar_antihor();
        }

        private void btRotDcha_Click(object sender, System.EventArgs e)
        {
            pbImagenes.Image = v.rotar_hor();
        }

        private void btMas_Click(object sender, System.EventArgs e)
        {
            pbImagenes.Image = v.Zoom(1.1f);
        }

        private void btMenos_Click(object sender, System.EventArgs e)
        {
            pbImagenes.Image = v.Zoom(0.9f);
        }
    }
}
