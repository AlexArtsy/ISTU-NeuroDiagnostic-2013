using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace neiron_OOP1
{
    public partial class MainForm : Form
    {
        public string bar = "|";
        public int [] valueOfNeiron = new int [3];
        double[] ch1;
        string[] lines = null;
        public MainForm()
        {
            InitializeComponent();
            neironMeth mn = new neironMeth();
            mn.MdiParent = this;
            mn.Show();
            
        }
  
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справка");
        }

        private void PrjMenuItemOpenProject_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
            }
        }

        private void PrjMenuItemCreateProject_Click(object sender, EventArgs e)
        {
            CreatingNewProject formForCreatingNewProject = new CreatingNewProject();
            formForCreatingNewProject.Show();
            
        }

        private void MethMenuItemNeiro_Click(object sender, EventArgs e)
        {
            neironMeth fmn = new neironMeth();
            fmn.Show();
        }

        private void справкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Справка");
        }
    }

    class DiagnostProject
    {
        public string ProjectName;
        public string DiagnostObjectName;

        public DiagnostProject(string PrjN, string DObjN)
        {
            ProjectName = PrjN;
            DiagnostObjectName = DObjN;
        }
    }

}
