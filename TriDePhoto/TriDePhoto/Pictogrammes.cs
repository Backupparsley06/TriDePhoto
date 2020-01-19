using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriDePhoto
{
    class Pictogrammes
    {
        List<Image> pictogrammes;
        public Pictogrammes(string relativePath)
        {
            pictogrammes = new List<Image>();
            PictureLoader pictureLoader = new PictureLoader(relativePath);
            for (int i = 0; i < pictureLoader.PictureCount;i++)
            {
                pictogrammes.Add(pictureLoader.LoadImageById(i));
            }
        }

        public Image Get(int i)
        {
            return pictogrammes[i - 1];
        }
    }
}
