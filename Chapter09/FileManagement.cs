using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09
{
    class FileManagement
    {
        private string fileName;

        public FileManagement(string fileName)
        {
            this.fileName = fileName;
        }

        public List<string> ReadFile()
        {
            List<string> texts = new List<string>();
            try
            {
                string[] fileContent = File.ReadAllLines(fileName);
                texts.AddRange(fileContent);
                return texts;
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                return texts;
            }
        }

        public void WriteFile(List<string> texts)
        {
            try
            {
                File.Delete(fileName);
                //File.AppendAllLines(fileName, texts);
                File.WriteAllLines(fileName, texts);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
