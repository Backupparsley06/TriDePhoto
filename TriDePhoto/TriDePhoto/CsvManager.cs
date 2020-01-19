using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriDePhoto
{
    class CsvManager
    {
        private DirectoryInfo directory;
        private List<string> data;
        private string dataFileName = "outputData.csv";
        string relativePath;
        private FileInfo dataFile;
        StreamWriter streamWrite;
        public CsvManager(string relativePath)
        {
            this.relativePath = relativePath;
            data = new List<string>();
        }
        
        public int LineCount {
            get
            {
                return data.Count;
            }
        }
        public void LoadCsv()
        {
            string currentDir = Environment.CurrentDirectory + relativePath;
            directory = new DirectoryInfo(currentDir);
            directory.Create();
            dataFile = new FileInfo(Path.Combine(directory.FullName, dataFileName));

            

            if (dataFile.Exists)
            {
                pullFile();     
            }

            OpenWriter();
            pushFile();
  
        }

        private void OpenWriter()
        {
            Stream stream = dataFile.OpenWrite();
            streamWrite = new StreamWriter(stream);
        }

        private void pushFile()
        {
            if (data.Count > 0)
            {
                streamWrite.Write(data.Aggregate((i, j) => i + "\n" + j));
            }
            else
            {
                streamWrite.Write("");
            }
            streamWrite.Flush();
        }

        private void pullFile()
        {
            using (Stream stream = dataFile.OpenRead())
                using (StreamReader reader = new StreamReader(stream))
                {
                    data = reader.ReadToEnd().Split('\n').ToList();
                    if (data[0] == "")
                    {
                        data.RemoveAt(0);
                    }
                }
        }

        public void Back(int count)
        {
            streamWrite.Close();
            for (int i = 0; i < count && data.Count > 0; i++)
                data.RemoveAt(data.Count - 1);        
            dataFile.Delete();
            OpenWriter();
            pushFile();
        }
        public void Back()
        {
            Back(1);
        }

        public void AddData(string Image, int categorie)
        {
            streamWrite.Write((LineCount > 0 ? "\n": "") + Image + ";" + categorie.ToString());
            data.Add(Image + ";" + categorie.ToString());
            streamWrite.Flush();
        }

    }
}
