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
    public partial class error : Form
    {
        public error()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(training.countPar);
        }
    }
}
