using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriDePhoto
{
    public partial class TriDePhoto : Form
    {

        PictureLoader pictureLoader;
        public TriDePhoto()
        {
            InitializeComponent();
            pictureLoader = new PictureLoader();
            InitPictureBox();

        }

        private void InitPictureBox()
        {
            PB_affichageSac.Height = (int)((float)PB_affichageSac.Width / (8000.0 / 2048.0));
        }

        private void BTN_LoadPhoto_Click(object sender, EventArgs e)
        {
            pictureLoader.LoadAllPictureID();
            Image image = pictureLoader.LoadImageById(0);
            PB_affichageSac.Image = image;
        }
    }
}
