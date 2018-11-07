using System.Drawing;
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

            foreach(string imagen in ofdImagenes.FileNames)
                v.Agregar_Foto((Bitmap)Bitmap.FromFile(imagen));

            pbImagenes.Image = v.Foto_Actual();
        
        }
    }
}
