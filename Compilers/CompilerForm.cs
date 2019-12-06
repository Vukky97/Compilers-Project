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

namespace Compilers
{
    public partial class CompilerForm : Form
    {
        public CompilerForm()
        {
            InitializeComponent();
            //FillUpDGV();
            SimpleOpenFile();
        }

        public void FillUpDGV()
        {
            // TODO: Make a similar xml or csv and read it from file
            // the table column and rows number will be fixed, but with cahngeable letters
            DGV.Rows.Add("", "", "TEv,1", "", "TEv,1", "");
            DGV.Rows.Add("+TEv,2", "", "", "ev3", "", "e,3");
            DGV.Rows.Add("", "", "FTv,4", "", "FTv,4", "");
            DGV.Rows.Add("e,6", "*FTv,5", "", "e,6", "", "e,6");
            DGV.Rows.Add("", "", "(E)v1", "", "i,8", "");

            DGV.Rows.Add("pop", "", "", "", "", "");
            DGV.Rows.Add("", "pop", "", "", "", "");
            DGV.Rows.Add("", "", "pop", "", "", "");
            DGV.Rows.Add("", "", "", "pop", "", "");
            DGV.Rows.Add("", "", "", "", "pop", "");
            DGV.Rows.Add("", "", "", "", "", "elfogad");
            DGV.Rows[0].HeaderCell.Value = "E";
            DGV.Rows[1].HeaderCell.Value = "Ev";
            DGV.Rows[2].HeaderCell.Value = "T";
            DGV.Rows[3].HeaderCell.Value = "Tv";
            DGV.Rows[4].HeaderCell.Value = "F";
            DGV.Rows[5].HeaderCell.Value = "+";
            DGV.Rows[6].HeaderCell.Value = "*";
            DGV.Rows[7].HeaderCell.Value = "(";
            DGV.Rows[8].HeaderCell.Value = ")";
            DGV.Rows[9].HeaderCell.Value = "i";
            DGV.Rows[10].HeaderCell.Value = "#";
        }

        public void OpenFile()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "CSV Files (*.csv)|*.csv";
            OFD.FilterIndex = 0;
            OFD.DefaultExt = "csv";

            if (OFD.ShowDialog() == DialogResult.OK)
            {

                if (!String.Equals(Path.GetExtension(OFD.FileName), ".csv", StringComparison.OrdinalIgnoreCase))
                {
                    // Invalid file type selected; display an error.
                    MessageBox.Show("The type of the selected file is not supported by this application. You must select an .csv file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string fullPath = OFD.FileName;
                    string fileName = OFD.SafeFileName;
                    //string filepath = fullPath.Replace(fileName, "");
                    using (var reader = new StreamReader(fullPath))
                    using (var csv = new CsvReader(reader))
                    {
                    }
                    DataSet ds = new DataSet();
                    //DGV.DataSource =

                    //ds.ReadXml(fullPath);
                    //DGV.DataSource = ds.Tables[0];
                }
            }
        }

        public void SimpleOpenFile()
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
                        dataTable.Columns.Add(dataColumns[i]);
                    }
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


        }

        public void SaveFile()
        {
            textBox.Text = "";
            textBox.Multiline = true;
            // TODO: Save File Dialog to get the save route
            int rowCount = DGV.RowCount;
            int CellCount = DGV.Rows[0].Cells.Count;

            for (int rowIndex = 0; rowIndex <= rowCount - 2; rowIndex++)
            {
                for (int cellIndex = 0; cellIndex < CellCount - 1; cellIndex++)
                {
                    textBox.Text += DGV.Rows[rowIndex].Cells[cellIndex].Value.ToString() + ";";
                }
                textBox.Text = "\r\n";
            }


        }

        private void openRule_Click(object sender, System.EventArgs e)
        {
            OpenFile();
        }

        // mentes helye a megnyitott file legyen
        private void saveRule_Click(object sender, System.EventArgs e)
        {
            SaveFile();
        }

        // kivalszhato mentes hely
        private void SaveAs_Click(object sender, System.EventArgs e)
        {

        }
    }
}
