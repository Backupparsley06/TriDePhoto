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

        }

        private void BTN_LoadPhoto_Click(object sender, EventArgs e)
        {
            pictureLoader.LoadAllPictureID();
        }
    }
}
