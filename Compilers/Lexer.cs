using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilers
{
    public class Lexer
    {
        // Collecting numbers atm?:
        private int checkNumbers = 1;
        private string state;
        Dictionary<string, string> D;
        Dictionary<string, string> numbersNVariables;
        private bool debug = true;
        private string text;

        public Lexer(string szoveg, int mode)
        {
            state = "q0";
            D = new Dictionary<string, string>();
            numbersNVariables = new Dictionary<string, string>();
            this.checkNumbers = mode;
            if (this.checkNumbers == 1)
            {
                //D.Add("q0err", "q3");
                D.Add("q0-", "q1");
                D.Add("q0+", "q1");
                D.Add("q0d", "q2");
                D.Add("q1d", "q2");
                D.Add("q2d", "q2");
            }
            else
            {
                D.Add("q0b", "q1");
                D.Add("q1b", "q2");
                D.Add("q2b", "q2");
            }
            this.text = szoveg;

            text = elemzo(szoveg);
        }

        public string elemzo(string list)
        {
            string[] inputList = list.Split(' ');
            string addAs;
            int namingIndex = 0;
            string actualElement;
            for (int i = 0; i < inputList.Length; i++)
            {
                actualElement = inputList[i];
                if (debug)
                    Console.WriteLine("The Inspected element is: " + actualElement);
                // Searching numbers
                if (this.checkNumbers == 1 && actualElement != "")
                {
                    if (Analizer(actualElement) == true)
                    {
                        if (!CheckAlreadyExists(actualElement, numbersNVariables))
                        {
                            namingIndex++;
                            addAs = String.Format("00" + namingIndex);
                            AddToDictionary(actualElement, addAs, numbersNVariables);
                        }
                        else
                        {
                            addAs = GetValueFromDict(actualElement, numbersNVariables);
                        }
                        inputList[i] = addAs;
                    }
                }
                // Checking for variables
                else if (this.checkNumbers == 0 && actualElement != "")
                {
                    if (Analizer(actualElement) == true)
                    {
                        if (!CheckAlreadyExists(actualElement, numbersNVariables))
                        {
                            namingIndex++;
                            // All variables starts with the "11" prefix ,because the letter L is the 12th in the english alphabet.
                            addAs = String.Format("11" + namingIndex);
                            AddToDictionary(actualElement, addAs, numbersNVariables);
                        }
                        else
                        {
                            addAs = GetValueFromDict(actualElement, numbersNVariables);
                        }
                        inputList[i] = addAs;
                    }
                }
            }
            if (debug)
            {
                if (checkNumbers == 1)
                {
                    Console.WriteLine("numbers: ");
                    string[] myKeys;
                    myKeys = numbersNVariables.Keys.ToArray();
                    for (int i = 0; i < myKeys.Length; i++)
                    {
                        Console.WriteLine(myKeys[i]);
                    }
                    Console.WriteLine("------------");
                }
                else
                {
                    Console.WriteLine("Variables: ");
                    string[] myKeys;
                    myKeys = numbersNVariables.Keys.ToArray();
                    for (int i = 0; i < myKeys.Length; i++)
                    {
                        Console.WriteLine(myKeys[i]);
                    }
                    Console.WriteLine("------------");
                }
            }

            string outputText = "";
            foreach (var item in inputList)
                outputText += item + " ";
            return outputText;
        }

        bool Analizer(string szoveg)
        {
            state = "q0";
            int i = 0;
            while (i < szoveg.Length && state != "error")
            {
                state = Delta(state, szoveg[i]);
                if (debug) Console.WriteLine(state);
                i++;
            }

            if (state == "error")
            {
                return false;
            }
            return true;
        }

        string Delta(string a, char s0)
        {
            string x = a + Csere(s0);
            if (debug) Console.WriteLine(x);
            if (D.ContainsKey(x))
            {
                return D[x];
            }
            else
            {
                return "error";
            }
        }

        string Csere(char c)
        {
            //checking for empty char
            if (c == '\0')
            {
                return "err";
            }
            if (char.IsDigit(c))
            {
                return "d";
            }
            if (char.IsLetter(c))
            {
                return "b";
            }

            return c.ToString();
        }


        //string[] ReplaceAndSaveConstans(string[] szoveg)
        //{

        //}

        public void AddToDictionary(string key, string value, Dictionary<string, string> DictToFill)
        {
            DictToFill.Add(key, value);
        }

        public bool CheckAlreadyExists(string key, Dictionary<string, string> DictToSearchInto)
        {
            if (DictToSearchInto.ContainsKey(key))
            {
                return true;
            }
            return false;
        }

        public string GetValueFromDict(string key, Dictionary<string, string> Dict)
        {
            return Dict[key];
        }

        public string GetFinalText()
        {
            return text;
        }


    }
}
