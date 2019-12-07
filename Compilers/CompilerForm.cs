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
            //SimpleOpenFile();
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
            InitializeTextBox();
            // TODO: Save File Dialog to get the save route
            int rowCount = DGV.RowCount;
            int CellCount = DGV.Rows[0].Cells.Count;

            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int cellIndex = 0; cellIndex < CellCount; cellIndex++)
                {
                    textBox.Text += DGV.Rows[rowIndex].Cells[cellIndex].Value.ToString() + ";";
                }
                textBox.Text += "\r\n";
            }

            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "Save";
            SFD.Filter = "CSV Files (*.csv)|*.csv" + " | " + "All Files (*.*)|*.*";

            string fullPath = "";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                fullPath = SFD.FileName;
            }

            File.WriteAllText(fullPath, textBox.Text);

        }
        private void InitializeTextBox()
        {
            textBox.Text = "";
            textBox.Multiline = true;
            textBox.Size = new Size(750, 200);
        }

        private void openRule_Click(object sender, System.EventArgs e)
        {
            SimpleOpenFile();
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
