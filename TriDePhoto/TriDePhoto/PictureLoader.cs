using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TriDePhoto
{
    class PictureLoader
    {
        private DirectoryInfo directory;
        FileInfo[] fileInfos;
        public PictureLoader()
        {

        }

        public void LoadAllPictureID()
        {
            string currentDir = Environment.CurrentDirectory + "\\..\\..\\..\\..\\Photo\\";
            directory = new DirectoryInfo(currentDir);
            fileInfos = directory.GetFiles();
        }

        public Image LoadImageById(int id)
        {
            byte [] bytes = File.ReadAllBytes(fileInfos[id].FullName);
            return (Bitmap)((new ImageConverter()).ConvertFrom(bytes));
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            catch {
                int i = 0;
            }
            return returnImage;
        }
    }
}
