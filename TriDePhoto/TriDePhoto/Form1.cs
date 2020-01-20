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
        const string relativePathPictogrammes = "\\..\\..\\..\\..\\Pictogrammes\\";
        const string relativePathPhoto = "\\..\\..\\..\\..\\Photo\\";
        const string relativePathCsv = "\\..\\..\\..\\..\\Out\\";
        const string relativePathTester = "\\..\\..\\..\\..\\Test\\";
        const string testFileName = "Tests.data";
        const string testProbability = "1/10";
        const int penalty = 10;
        private bool isTest = false;
        private PictureLoader pictureLoader;
        private Pictogrammes pictogrammes;
        private CsvManager csvManager;
        private ProbabilityGenerator probabilityGenerator;
        private Tester tester;
        public TriDePhoto()
        {
            InitializeComponent();
            InitPictureBox();

            probabilityGenerator = new ProbabilityGenerator(int.Parse(testProbability.Split('/')[0]), int.Parse(testProbability.Split('/')[1]));
            pictureLoader = new PictureLoader(relativePathPhoto);
            csvManager = new CsvManager(relativePathCsv);
            tester = new Tester(relativePathTester, testFileName);
            csvManager.LoadCsv();
            PB_affichageSac.Image = pictureLoader.LoadImageById(csvManager.LineCount);
            InitPictogrammes();
            UpdateCounter();
            UpdateUI();
        }

        private void InitPictogrammes()
        {
            pictogrammes = new Pictogrammes(relativePathPictogrammes);
            PB_1.Image = pictogrammes.Get(1);
            PB_2.Image = pictogrammes.Get(2);
            PB_3.Image = pictogrammes.Get(3);
            PB_4.Image = pictogrammes.Get(4);
            PB_5.Image = pictogrammes.Get(5);
            PB_6.Image = pictogrammes.Get(6);
            PB_7.Image = pictogrammes.Get(7);
            PB_8.Image = pictogrammes.Get(8);
            PB_9.Image = pictogrammes.Get(9);
            PB_10.Image = pictogrammes.Get(10);
            PB_11.Image = pictogrammes.Get(11);
            PB_12.Image = pictogrammes.Get(12);
            PB_13.Image = pictogrammes.Get(13);
            PB_14.Image = pictogrammes.Get(14);
            PB_15.Image = pictogrammes.Get(15);
            PB_16.Image = pictogrammes.Get(16);
            PB_17.Image = pictogrammes.Get(17);
            PB_18.Image = pictogrammes.Get(18);
            PB_19.Image = pictogrammes.Get(19);
            PB_20.Image = pictogrammes.Get(20);
            PB_21.Image = pictogrammes.Get(21);
            PB_22.Image = pictogrammes.Get(22);
            PB_23.Image = pictogrammes.Get(23);
        }
        
        private void UpdatePB_Hover(int i)
        {
            PB_OnHover.Image = pictogrammes.Get(i);
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
            
            if (isTest)
            {
                isTest = false;
                if (categorieValue == tester.GetAnswer())
                {
                    //TO-DO
                    LBL_TestSucces.Text = "Succes";
                    LBL_TestSucces.BackColor = Color.Green;
                }
                else
                {
                    //TO-DO
                    LBL_TestSucces.Text = "Raté";
                    LBL_TestSucces.BackColor = Color.Red;
                    csvManager.Back(penalty);
                }
            }
            else
            {
                LBL_TestSucces.Text = "";
                LBL_TestSucces.BackColor = Color.Transparent;
                csvManager.AddData(pictureLoader.GetImageNameByID(csvManager.LineCount), categorieValue);
            }


            if (pictureLoader.PictureCount > csvManager.LineCount)
            {
                if(isTest = probabilityGenerator.GetRandom())
                {
                    PB_affichageSac.Image = tester.LoadImage();
                }
                else
                {
                    PB_affichageSac.Image = pictureLoader.LoadImageById(csvManager.LineCount);
                }
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
        private void BTN_Categorie1_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(1);
        }
        private void BTN_Categorie2_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(2);
        }
        private void BTN_Categorie3_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(3);
        }
        private void BTN_Categorie4_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(4);
        }
        private void BTN_Categorie5_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(5);
        }
        private void BTN_Categorie6_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(6);
        }
        private void BTN_Categorie7_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(7);
        }
        private void BTN_Categorie8_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(8);
        }
        private void BTN_Categorie9_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(9);
        }
        private void BTN_Categorie10_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(10);
        }
        private void BTN_Categorie11_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(11);
        }
        private void BTN_Categorie12_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(12);
        }
        private void BTN_Categorie13_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(13);
        }
        private void BTN_Categorie14_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(14);
        }
        private void BTN_Categorie15_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(15);
        }
        private void BTN_Categorie16_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(16);
        }
        private void BTN_Categorie17_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(17);
        }
        private void BTN_Categorie18_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(18);
        }
        private void BTN_Categorie19_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(19);
        }
        private void BTN_Categorie20_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(20);
        }
        private void BTN_Categorie21_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(21);
        }
        private void BTN_Categorie22_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(22);
        }
        private void BTN_Categorie23_MouseEnter(object sender, EventArgs e)
        {
            UpdatePB_Hover(23);
        }
    }
}
