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
        const string relativePathPhoto = "\\..\\..\\..\\..\\Photo\\";
        const string relativePathCsv = "\\..\\..\\..\\..\\Out\\";
        PictureLoader pictureLoader;
        CsvManager csvManager;
        public TriDePhoto()
        {
            InitializeComponent();
            InitPictureBox();

            pictureLoader = new PictureLoader(relativePathPhoto);
            csvManager = new CsvManager(relativePathCsv);
            csvManager.LoadCsv();
            pictureLoader.LoadAllPictureID();
        }

        private void InitPictureBox()
        {
            PB_affichageSac.Height = (int)((float)PB_affichageSac.Width / (8000.0 / 2048.0));
        }

        public void NextPicture(int categorieValue)
        {
            PB_affichageSac.Image = pictureLoader.LoadImageById(csvManager.LineCount);
            csvManager.AddData(pictureLoader.GetImageNameByID(csvManager.LineCount), categorieValue);
        }
        private void BTN_LoadPhoto_Click(object sender, EventArgs e)
        {
            NextPicture(1);
        }
    }
}
