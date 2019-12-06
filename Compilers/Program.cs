using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilers
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CompilerForm());

            //string path1 = @"D:\TANN\7.FELEV\FordítóProgramok\test\inputTest.txt";
            //string path2 = @"D:\TANN\7.FELEV\FordítóProgramok\test\outputTest.txt";
            //SourceHandler sourceHandler = new SourceHandler(path1, path2);


            //SourceHandler compiler = new SourceHandler("input.txt", "output.txt");
            //compiler.OpenFile();
            //compiler.PrintFile();

            //Lexer lexer = new Lexer();
            //lexer.S = "+34";
            ////lexer.S = "+34 blablabla 234512 sadasdsa dsfds 5rete ";
            //lexer.startLexer();

            // if you want to use it, right click on proj name, properties, and switch output to console app
            //RekurzívLeszállás RL = new RekurzívLeszállás();

            Console.ReadLine();
        }
    }
}
