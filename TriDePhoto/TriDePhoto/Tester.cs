using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriDePhoto
{
    class Tester
    {
        private string path;
        private List<string> tests;
        private int answer = 0;
        private Random rand;
        public Tester(string relativePath, string testFile)
        {
            rand = new Random();
            path = Environment.CurrentDirectory + relativePath;
            tests = File.ReadAllText(Environment.CurrentDirectory + relativePath + testFile).Replace('\r', ' ').Split('\n').ToList();
            for(int i = 0; i < tests.Count; i++)
            {
                tests[i] = tests[i].TrimEnd();
            }
            if (tests[tests.Count - 1] == "")
            {
                tests.RemoveAt(tests.Count - 1);
            }
        }

        public int GetAnswer()
        {
            return answer;
        }

        public Image LoadImage()
        {
            int index = rand.Next() % tests.Count();
            answer = int.Parse(tests[index].Split(';')[1]);
            return (Bitmap)(new ImageConverter()).ConvertFrom(File.ReadAllBytes(path + tests[index].Split(';')[0]));
        }
    }
}
