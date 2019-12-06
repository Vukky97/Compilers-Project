using System;
using System.IO;
using System.Windows.Forms;

namespace Compilers
{
    public partial class CompilerForm : Form
    {
        public CompilerForm()
        {
            InitializeComponent();
            FillUpDGV();
            //string fileExtension = "xml";
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
            OFD.Filter = "XML Files (*.xml)|*.xml";
            OFD.FilterIndex = 0;
            OFD.DefaultExt = "xml";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                if (!String.Equals(Path.GetExtension(OFD.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    // Invalid file type selected; display an error.
                    MessageBox.Show("The type of the selected file is not supported by this application. You must select an XML file.",
                                    "Invalid File Type",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    string fullPath = OFD.FileName;
                    string fileName = OFD.SafeFileName;
                    string filepath = fullPath.Replace(fileName, "");
                }
            }
        }

        public void SaveFile()
        {

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
