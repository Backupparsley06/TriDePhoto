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
        string relativePath;
        public PictureLoader(string relativePath)
        {
            this.relativePath = relativePath;
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

        public string GetImageNameByID(int id)
        {
            return fileInfos[id].Name;
        }
    }
}
