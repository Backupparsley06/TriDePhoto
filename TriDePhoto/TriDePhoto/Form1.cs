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
            PB_affichageSac.Image = pictureLoader.LoadImageById(csvManager.LineCount);
            UpdateCounter();
            UpdateUI();
        }
        private void UpdateUI()
        {
            BTN_Back.Enabled = csvManager.LineCount > 0;
            ToggleCategories(csvManager.LineCount < pictureLoader.PictureCount);
        }
        private void UpdateCounter()
        {
            Lbl_Counter.Text = csvManager.LineCount + "/" + pictureLoader.PictureCount; 
        }

        private void InitPictureBox()
        {
            PB_affichageSac.Height = (int)((float)PB_affichageSac.Width / (8000.0 / 2048.0));
        }

        public void NextPicture(int categorieValue)
        {   
            csvManager.AddData(pictureLoader.GetImageNameByID(csvManager.LineCount), categorieValue);
            if (pictureLoader.PictureCount > csvManager.LineCount)
            {
                PB_affichageSac.Image = pictureLoader.LoadImageById(csvManager.LineCount);
            }

            UpdateCounter();
            UpdateUI();
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            csvManager.Back();
            PB_affichageSac.Image = pictureLoader.LoadImageById(csvManager.LineCount);
            UpdateCounter();
            UpdateUI();
        }
        public void ToggleCategories(bool enabled)
        {
            BTN_Categorie1.Enabled = enabled;
            BTN_Categorie2.Enabled = enabled;
            BTN_Categorie3.Enabled = enabled;
            BTN_Categorie4.Enabled = enabled;
            BTN_Categorie5.Enabled = enabled;
            BTN_Categorie6.Enabled = enabled;
            BTN_Categorie7.Enabled = enabled;
            BTN_Categorie8.Enabled = enabled;
            BTN_Categorie9.Enabled = enabled;
            BTN_Categorie10.Enabled = enabled;
            BTN_Categorie11.Enabled = enabled;
            BTN_Categorie12.Enabled = enabled;
            BTN_Categorie13.Enabled = enabled;
            BTN_Categorie14.Enabled = enabled;
            BTN_Categorie15.Enabled = enabled;
            BTN_Categorie16.Enabled = enabled;
            BTN_Categorie17.Enabled = enabled;
            BTN_Categorie18.Enabled = enabled;
            BTN_Categorie19.Enabled = enabled;
            BTN_Categorie20.Enabled = enabled;
            BTN_Categorie21.Enabled = enabled;
            BTN_Categorie22.Enabled = enabled;
            BTN_Categorie23.Enabled = enabled;
        }


        private void BTN_Categorie1_Click(object sender, EventArgs e)
        {
            NextPicture(1);
        }
        private void BTN_Categorie2_Click(object sender, EventArgs e)
        {
            NextPicture(2);
        }
        private void BTN_Categorie3_Click(object sender, EventArgs e)
        {
            NextPicture(3);
        }
        private void BTN_Categorie4_Click(object sender, EventArgs e)
        {
            NextPicture(4);
        }
        private void BTN_Categorie5_Click(object sender, EventArgs e)
        {
            NextPicture(5);
        }
        private void BTN_Categorie6_Click(object sender, EventArgs e)
        {
            NextPicture(6);
        }
        private void BTN_Categorie7_Click(object sender, EventArgs e)
        {
            NextPicture(7);
        }
        private void BTN_Categorie8_Click(object sender, EventArgs e)
        {
            NextPicture(8);
        }
        private void BTN_Categorie9_Click(object sender, EventArgs e)
        {
            NextPicture(9);
        }
        private void BTN_Categorie10_Click(object sender, EventArgs e)
        {
            NextPicture(10);
        }
        private void BTN_Categorie11_Click(object sender, EventArgs e)
        {
            NextPicture(11);
        }
        private void BTN_Categorie12_Click(object sender, EventArgs e)
        {
            NextPicture(12);
        }
        private void BTN_Categorie23_Click(object sender, EventArgs e)
        {
            NextPicture(23);
        }
        private void BTN_Categorie22_Click(object sender, EventArgs e)
        {
            NextPicture(22);
        }
        private void BTN_Categorie21_Click(object sender, EventArgs e)
        {
            NextPicture(21);
        }
        private void BTN_Categorie20_Click(object sender, EventArgs e)
        {
            NextPicture(20);
        }
        private void BTN_Categorie19_Click(object sender, EventArgs e)
        {
            NextPicture(19);
        }
        private void BTN_Categorie18_Click(object sender, EventArgs e)
        {
            NextPicture(18);
        }
        private void BTN_Categorie17_Click(object sender, EventArgs e)
        {
            NextPicture(17);
        }
        private void BTN_Categorie16_Click(object sender, EventArgs e)
        {
            NextPicture(16);
        }
        private void BTN_Categorie15_Click(object sender, EventArgs e)
        {
            NextPicture(15);
        }
        private void BTN_Categorie14_Click(object sender, EventArgs e)
        {
            NextPicture(14);
        }
        private void BTN_Categorie13_Click(object sender, EventArgs e)
        {
            NextPicture(13);
        }


    }
}
