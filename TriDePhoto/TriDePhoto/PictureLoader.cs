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
        public PictureLoader(string relativePath)
        {
            LoadAllPictureID(relativePath);
        }

        public int PictureCount
        {
            get
            {
                return fileInfos.Length;
            }
        }

        private void LoadAllPictureID(string relativePath)
        {
            directory = new DirectoryInfo(Environment.CurrentDirectory + relativePath);
            fileInfos = directory.GetFiles().ToList().OrderBy(_ => _.Name).ToArray();
        }

        public Image LoadImageById(int id)
        {
            return (Bitmap)((new ImageConverter()).ConvertFrom(File.ReadAllBytes(fileInfos[id].FullName)));
        }

        public string GetImageNameByID(int id)
        {
            return fileInfos[id].Name;
        }
    }
}
