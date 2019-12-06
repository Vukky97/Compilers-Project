using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Compilers
{
    class SourceHandler
    {
        string input, output;
        string source = "";

        Dictionary<string, string> D1;
        Dictionary<string, string> D2;

        public SourceHandler(string file1, string file2)
        {
            this.input = file1;
            this.output = file2;
            D1 = new Dictionary<string, string>();
            D2 = new Dictionary<string, string>();
            D1.Add("\r\n", " ");
            D1.Add("    ", " ");
            D1.Add("  ", " ");
            //..
            D2.Add("if", "10");
            D2.Add("then", "20");
            D2.Add("else", "30");
            D2.Add("==", "40");
            D2.Add("=", "50");
            D2.Add("!=", "60");
            D2.Add("do", "70");
            D2.Add("while", "80");
            D2.Add("case", "90");
            D2.Add("break", "100");
            //...
            openFile(input);
            replace2();
            replace1(D1);

            writeFile(file2);
            openFile(file2);

            replace3(1);

            writeFile(file2);
            openFile(file2);

            replace1(D2);
            replace3(0);
            writeFile(file2);
            Console.WriteLine("Process completed without any error, Press Enter");
        }

        public void openFile(string filePath)
        {
            StreamReader SR = new StreamReader(File.OpenRead(filePath));
            source = SR.ReadToEnd();
            SR.Close();
        }
        public void writeFile(string outputFile)
        {
            StreamWriter WR = new StreamWriter(File.Open(outputFile, FileMode.Create));
            WR.WriteLine(source);
            WR.Flush();
            WR.Close();
        }
        public void replace1(Dictionary<string, string> d)
        {
            foreach (var x in d)
            {
                while (source.Contains(x.Key))
                {
                    source = source.Replace(x.Key, x.Value);
                }
            }
        }
        public void replace2()
        {
            source = Regex.Replace(source, "//(.*?)\r?\n", string.Empty);
            source = Regex.Replace(source, @"/\*([^\*/])*\*/", string.Empty);
        }

        public void replace3(int mode)
        {
            Lexer lexer = new Lexer(source, mode);
            source = lexer.GetFinalText();
        }

    }
}
