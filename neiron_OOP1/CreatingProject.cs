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
    public partial class CreatingNewProject : Form
    {
        string[] objList;

        public CreatingNewProject()
        {   
           
            InitializeComponent();
        }
        private void createBbutton_Click(object sender, EventArgs e)
        {   
            MainForm mFr = new MainForm();
            
         
            string[] dataOfPrj = new string[2];
            saveFileDialog1.DefaultExt = "dprj";
            saveFileDialog1.Filter = "проекты диагностики|*.dprj";
            if (nameOfPrTextBox.Text == "") 
            { return; }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {//nameOfPrTextBox  nameOfObjtextBox
                    dataOfPrj[0] = nameOfPrTextBox.Text;
                    //dataOfPrj[1] = textBoxNameOfObj.Text;
                    System.IO.File.WriteAllLines(saveFileDialog1.FileName, dataOfPrj);

                    this.Close();
                }
            }
            
        }

        private void canzelButton_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void buttonNewObj_Click(object sender, EventArgs e)
        {
            if (textBoxNameOfObj.Text != null && nameOfPrTextBox.Text!=null)
             {
                 DiagnostProject dPrj = new DiagnostProject(nameOfPrTextBox.Text, textBoxNameOfObj.Text);
             }
        }
    }
}
