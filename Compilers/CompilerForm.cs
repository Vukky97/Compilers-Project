﻿using System;
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
        public CompilerForm()
        {
            InitializeComponent();
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

        private void SaveFile()
        {
            InitializeTextBox();
            int rowCount = DGV.RowCount;
            int CellCount = DGV.Rows[0].Cells.Count;

            // TODO: a headert is olvassa be valahogy a csv be
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int cellIndex = 0; cellIndex < CellCount; cellIndex++)
                {
                    // TODO: utolso elemek mogott ne legyen pontos vesszo
                    textBox.Text += DGV.Rows[rowIndex].Cells[cellIndex].Value.ToString() + ";";
                }
                textBox.Text += "\r\n";
            }
        }

        private string selectedRoute = "";
        public void SaveFileAs()
        {
            SaveFile();

            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "Save";
            SFD.Filter = "CSV Files (*.csv)|*.csv" + " | " + "All Files (*.*)|*.*";

            string fullPath = "";
            // TODO :catch el lekezelni ha kilepne SFD bol try catch 
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                fullPath = SFD.FileName;
            }
            else
            {
                MessageBox.Show("You must choose, if you want to continue");
            }
            File.WriteAllText(fullPath, textBox.Text);
            selectedRoute = fullPath;

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
            OpenFile();
        }

        private void saveRule_Click(object sender, System.EventArgs e)
        {
            SaveFileShort();
        }

        private void SaveAs_Click(object sender, System.EventArgs e)
        {
            SaveFileAs();
        }

    }
}
