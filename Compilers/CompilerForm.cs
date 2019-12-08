using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Reflection;

namespace Compilers
{
    public partial class CompilerForm : Form
    {
        Random rnd = new Random();

        Dictionary<string, string> dictionary;
        private Stack<string> tape;
        private Stack<string> rule;
        private string ruleNum;
        private int colNum, rowNum;
        private bool showSteps = false;
        private string csvOutput = "";

        public CompilerForm()
        {
            InitializeComponent();
            BTN_Analyze.Enabled = false;
            saveRule.Enabled = false;
            SaveAs.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void OpenFile()
        {
            DataTable dataTable = new DataTable();
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "CSV Files (*.csv)|*.csv";
            OFD.FilterIndex = 0;
            OFD.DefaultExt = "csv";

            string fullPath = "";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                fullPath = OFD.FileName;
            }
            string[] rawText = File.ReadAllLines(fullPath);
            string[] dataColumns = null;
            bool isHeader = true;

            foreach (string textLine in rawText)
            {
                dataColumns = textLine.Split(';');
                if (isHeader)
                {
                    for (int i = 0; i <= dataColumns.Count() - 1; i++)
                    {
                        dataTable.Columns.Add(i.ToString());
                    }
                    dataTable.Rows.Add(dataColumns);
                    isHeader = false;
                }
                else
                {
                    dataTable.Rows.Add(dataColumns);
                }

                DGV.DataSource = dataTable;

                foreach (DataGridViewColumn column in DGV.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            BTN_Analyze.Enabled = true;
            saveRule.Enabled = true;
            SaveAs.Enabled = true;
            dataTable = null;
        }

        private void SaveFile()
        {
            int rowCount = DGV.RowCount;
            int CellCount = DGV.Rows[0].Cells.Count;

            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int cellIndex = 0; cellIndex < CellCount; cellIndex++)
                {
                    if (!(CellCount - cellIndex <= 1))
                    {
                        csvOutput += DGV.Rows[rowIndex].Cells[cellIndex].Value.ToString() + ";";
                    }
                    else    // dont write ; after last element
                    {
                        csvOutput += DGV.Rows[rowIndex].Cells[cellIndex].Value.ToString();
                    }
                }
                csvOutput += "\r\n";
            }
        }

        // global variable for "memorise" previously choosed file path
        private string selectedRoute = "";
        public void SaveFileAs()
        {
            SaveFile();

            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "Save";
            SFD.Filter = "CSV Files (*.csv)|*.csv" + " | " + "All Files (*.*)|*.*";

            string fullPath = "";
            // TODO : improve catch
            try
            {
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    fullPath = SFD.FileName;
                }
                else
                {
                    MessageBox.Show("You must choose, if you want to continue");
                }
                ClearFileContent(fullPath);
                File.WriteAllText(fullPath, csvOutput);
                selectedRoute = fullPath;
            }
            catch
            {
                SaveFileAs();
            }
        }

        public void SaveFileShort()
        {
            SaveFile();

            string fullPath;
            if (selectedRoute != "")
            {
                fullPath = selectedRoute;
                MessageBox.Show("Your file has been sucessfully saved here: " + "\r\n" + selectedRoute);
            }
            else
            {
                fullPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "temp.csv");
                MessageBox.Show("Your file has been sucessfully saved into /bin/debug as temp.csv");
            }
            ClearFileContent(fullPath);
            File.WriteAllText(fullPath, csvOutput);

        }

        public void ClearFileContent(string path)
        {
            File.WriteAllText(path, string.Empty);
        }

        private void Analyze()
        {
            //labelResult.Text = "";
            rule = new Stack<string>();
            tape = new Stack<string>();
            ruleNum = "";
            rule.Push("#");
            rule.Push("E");
            colNum = 0;
            rowNum = 0;
            labelOutput.Text = "";
            string actRule;
            string actState;

            string fixedInput = CheckInput();

            if (showSteps)
            {
                MessageBox.Show("Fixed Input: " + fixedInput);
            }


            if (!fixedInput.Equals(""))
            {
                for (int i = fixedInput.Length - 1; i >= 0; i--)
                {
                    tape.Push(fixedInput[i].ToString());
                }
                labelCorrectInput.Text = fixedInput;
            }

            string act = tape.Pop();
            bool end = (act == "#");
            while (DGV.Rows[rowNum].Cells[colNum].Value.ToString() != "elfogad" && !end)
            {
                colNum = 0;
                rowNum = 1;
                while (colNum < DGV.Columns.Count && act != DGV.Rows[0].Cells[colNum].Value.ToString())
                {
                    //DGV.Rows[rowNum].Cells[colNum].Style.BackColor = Color.LightGreen;
                    //MessageBox.Show(act + " / " + DGV.Rows[0].Cells[colNum].Value.ToString());
                    colNum++;
                }

                if (colNum == DGV.Columns.Count)
                {
                    end = true;
                    break;
                }
                else
                {
                    actRule = rule.Pop();
                    if (actRule != "#" && rule.Peek() == "v")
                    {
                        actRule += rule.Pop();
                    }
                    while (rowNum < DGV.Rows.Count && actRule != DGV.Rows[rowNum].Cells[0].Value.ToString())
                    {
                        if (showSteps)
                        {
                            MessageBox.Show("Act rule : " + actRule + "| Act Row Cel Value: " + DGV.Rows[rowNum].Cells[0].Value.ToString());
                        }
                        //DGV.Rows[rowNum].Cells[0].Style.BackColor = Color.FromArgb(150, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                        rowNum++;
                    }
                    if (rowNum == DGV.Rows.Count)
                    {
                        if (showSteps)
                        {
                            MessageBox.Show(rowNum + " /// " + DGV.Rows.Count);
                        }

                        end = true;
                        break;
                    }
                    else
                    {
                        actState = "<" + act;
                        foreach (string s in tape)
                        {
                            actState += s;
                        }
                        actState += ", " + actRule;
                        foreach (string s in rule)
                        {
                            actState += s;
                        }
                        actState += ", " + ruleNum + ">";

                        if (DGV.Rows[rowNum].Cells[colNum].Value.ToString() == "")
                        {
                            end = true;
                            break;
                        }
                        else if (DGV.Rows[rowNum].Cells[colNum].Value.ToString() == "pop")
                        {
                            act = tape.Pop();
                            actState += " - pop";
                        }
                        else
                        {
                            string[] temp = DGV.Rows[rowNum].Cells[colNum].Value.ToString().Split(',');
                            if (temp[0] == "e")
                            {
                                temp[0] = "";
                            }
                            for (int i = temp[0].Length - 1; i >= 0; i--)
                            {
                                rule.Push(temp[0][i].ToString());
                            }
                            if (temp.Length == 2)
                            {
                                ruleNum += temp[1];
                            }
                        }
                        labelOutput.Text += actState + "\r\n";
                    }
                }
            }
            if (rowNum < DGV.RowCount && colNum < DGV.ColumnCount)
            {
                if (showSteps)
                {
                    MessageBox.Show(rowNum + " " + "<" + " " + " " + DGV.RowCount + " " + "&&" + colNum + "<" + DGV.ColumnCount);
                    MessageBox.Show(DGV.Rows[rowNum].Cells[colNum].Value.ToString() + rowNum + " " + colNum + "==" + " elfogad");
                }

                if (DGV.Rows[rowNum].Cells[colNum].Value.ToString() == "elfogad")
                {
                    //MessageBox.Show(DGV.Rows[rowNum].Cells[colNum].Value.ToString() + "==" + " elfogad");
                    labelResult.ForeColor = Color.Green;
                    labelResult.Text = "Accepted";
                }
                else
                {
                    labelResult.ForeColor = Color.Red;
                    labelResult.Text = "Error in input";
                }
            }
            else
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Error in input";
            }
        }

        private string CheckInput()
        {
            string inputToCheck = textBoxAnalyze.Text;
            if (textBoxAnalyze.Text != "")
            {
                dictionary = new Dictionary<string, string>();
                dictionary.Add("\r\n", " ");
                dictionary.Add("    ", " ");
                dictionary.Add("  ", " ");
                dictionary.Add(" ", "");

                //TODO: maybe change to ASCII code, 2 for loop, 1 for nums, 1 upper n lower case fill up
                char[] charsToDic = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'z',
                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Z'};
                for (int i = 0; i < charsToDic.Length; i++)
                {
                    dictionary.Add(charsToDic[i].ToString(), "i");
                }

                foreach (var x in dictionary)
                {
                    while (inputToCheck.Contains(x.Key))
                    {
                        inputToCheck = inputToCheck.Replace(x.Key, x.Value);
                    }
                }

                char lastInputChar = inputToCheck[inputToCheck.Length - 1];
                if (lastInputChar.Equals("#"))
                {

                }
                else
                {
                    inputToCheck += "#";
                }

                return inputToCheck;
            }
            else
            {
                return "";
            }
        }
        private bool CheckInputIsEmpty()
        {
            if (textBoxAnalyze.Text == "")
            {
                MessageBox.Show("You must give some input first");
                textBoxAnalyze.Focus();
                return true;
            }
            return false;
        }

        private void openRule_Click(object sender, System.EventArgs e)
        {
            OpenFile();
        }

        private void saveRule_Click(object sender, System.EventArgs e)
        {
            SaveFileShort();
        }

        private void BTN_Analyze_Click(object sender, EventArgs e)
        {
            if (!CheckInputIsEmpty())
            {
                Analyze();
            }

        }

        private void SaveAs_Click(object sender, System.EventArgs e)
        {
            SaveFileAs();
        }

    }
}
