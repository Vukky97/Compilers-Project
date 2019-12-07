using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilers
{
    class RekurzívLeszállás
    {
        // TODO: 
        // Szokoz kitakarit v ne legyen az inputba es az alapjan splitelni, vagy / menten splitelni
        //string s = "i+i*i#";
        //string s = "(i+i)#";
        string inputString;
        int k = 0;
        char lastInputChar;
        bool hasError = false;

        public RekurzívLeszállás()
        {
            Console.Write("Add meg az elemzendő szót: ");
            inputString = Console.ReadLine();
            lastInputChar = inputString[inputString.Length - 1];

            if (!lastInputChar.Equals("#"))
            {
                inputString += "#";
            }

            Console.WriteLine(String.Format("A bemeneti szó: {0}", inputString));
            S();
            
            if (hasError == false)
            {
                Console.WriteLine("Query way succesfull.");
            }
            else
            {
                Console.WriteLine("There are some error.");
            }

            Console.WriteLine("The program reaches its end.");
        }


        public void Elfogad(char c)
        {
            if (inputString[k] == c)
            {
                k++;
            }
            else
            {
                hasError = true;
                Console.WriteLine("Error at : {0}. input string index ", k);
                k++;
            }
        }

        void S()
        {
            E();
            Elfogad('#');
        }

        void E()
        {
            T();
            Ev();
        }
        void Ev()
        {
            if (inputString[k] == '+')
            {
                Elfogad('+');
                T();
                Ev();
            }
            else
            {
                //Console.WriteLine("Summa, siker");
                //k++;
            }
        }

        void T()
        {
            F();
            Tv();
        }
        void Tv()
        {
            if (inputString[k] == '*')
            {
                Elfogad('*');
                F();
                Tv();
            }
            else
            {
                //Console.WriteLine("Summa, siker");
                //k++;
            }
        }

        void F()
        {
            if (inputString[k] == '(')
            {
                Elfogad('(');
                E();
                Elfogad(')');
            }
            else
            {
                Elfogad('i');
            }
        }

    }
}
