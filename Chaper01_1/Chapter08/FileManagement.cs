using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    class FileManagement
    {
        private string filename;
        public FileManagement(string filename)
        {
            this.filename = filename;
        }
        public List<string> ReadFile()
        {
            List<string> content = new List<string>();
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine();
            while (line != null)
            {
                content.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            return content;
        }
        public void WriteFile(List<string> lines)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close();
        }
    }
}
 
