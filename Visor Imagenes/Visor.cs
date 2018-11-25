using System;
using System.Drawing;
using System.Windows.Forms;

using Visor2;

namespace Visor_Imagenes
{
    public partial class VisorImg : Form
    {
        static int anchoVisor = 640;
        static int altoVisor = 360;

        Visor v = new Visor(anchoVisor, altoVisor);

        bool arrastrando;
        float zoom = 1;
        Point offset;

        int anchoMiniatura = 150;
        int altoMiniatura = 84;
        public VisorImg()
        {
            InitializeComponent();
            arrastrando = false;
        }

        private void btAbrir_Click(object sender, System.EventArgs e)
        {
            if (ofdImagenes.ShowDialog() == DialogResult.Cancel)
                return;

            foreach (string imagen in ofdImagenes.FileNames)
                v.Agregar_Foto(imagen);
            

            pbImagenes.Image = v.Foto_Actual();

            Console.WriteLine(v.Num_Actual);

            btAnt.Enabled = true;
            btSig.Enabled = true;
            btRotIzda.Enabled = true;
            btRotDcha.Enabled = true;
            btMas.Enabled = true;
            btMenos.Enabled = true;

            setMiniaturas();


        }

        private void btAnt_Click(object sender, System.EventArgs e)
        {
            pbImagenes.Image = v.Prev_Foto();
            setMiniaturas();
        }

        private void btSig_Click(object sender, System.EventArgs e)
        {
            pbImagenes.Image = v.Next_Foto();
            setMiniaturas();
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
            zoom = zoom * 1.1f;
        }

        private void btMenos_Click(object sender, System.EventArgs e)
        {
            pbImagenes.Image = v.Zoom(0.9f);
            zoom = zoom * 0.9f;
        }

        private void pbImagenes_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrando = true;
            offset = e.Location;
        }

        private void pbImagenes_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                pbImagenes.Image = v.Despl(pbImagenes.Location.X + e.X - offset.X, pbImagenes.Location.Y + e.Y - offset.Y);
            }
        }

        private void pbImagenes_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
        }

        private void setMiniaturas()
        {
            int numPrev;
            int numNext;

            if (v.Num_Actual == 0) {
                numPrev = v.Num_Fotos() - 1;
            } else {
                numPrev = v.Num_Actual - 1;
            }

            if (v.Num_Actual == v.Num_Fotos() - 1) {
                numNext = 0;
            } else {
                numNext = v.Num_Actual + 1;
            }
            

            pbPrev.Image = v.Miniatura(numPrev, anchoMiniatura, altoMiniatura);
            pbNext.Image = v.Miniatura(numNext, anchoMiniatura, altoMiniatura);
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
