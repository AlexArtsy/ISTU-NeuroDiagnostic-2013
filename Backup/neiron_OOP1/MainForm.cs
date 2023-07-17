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
            
        }
        //============================ свойства================================
        public int progressBarMaxValue
        {   
            set { progressBar1.Maximum = value; }
        }
        public int progressBarValue
        {
            get { return progressBar1.Value; }
            set { progressBar1.Value = value; }
        }
        public bool progressBarVisible
        {
            set { progressBar1.Visible = value; }
        }
        public void menuMethVis(bool value)
        {
            MenuItemDiagnosticMethode.Visible = value;
            
            
        }
        //======================================================================

        public void creatNeiron()
        {

            Neiron[] neiro1 = new Neiron[valueOfNeiron[0]]; 
            Neiron[] neiro2 = new Neiron[valueOfNeiron[1]];
            Neiron[] neiro3 = new Neiron[valueOfNeiron[2]];

            for (int i = 0; i < valueOfNeiron[0]; i++)
            {
                neiro1[i]= new Neiron(ch1.Length,ch1);
            }
            for (int i = 0; i < valueOfNeiron[1]; i++)
            {
                neiro2[i] = new Neiron(valueOfNeiron[0]);
            }
            for (int i = 0; i < valueOfNeiron[2]; i++)
            {
                neiro3[i] = new Neiron(valueOfNeiron[1]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {  
          /* if (textBox1.Text!= null)
            valueOfNeiron[0] = Convert.ToInt32( textBox1.Text);
           valueOfNeiron[1] = Convert.ToInt32(textBox2.Text);
           valueOfNeiron[2] = Convert.ToInt32(textBox3.Text);
           creatNeiron();*/

            //double[] funk = new double[1000];
            double[] integrFunk = new double[ch1.Length];
            //double n = 0;
            double sum=0;
            double sred=0;
            for (int i = 0; i < ch1.Length; i++)
            {
                sum += ch1[i];
            }
            sred = sum/ch1.Length;
            int poz = 0, neg = 0, sumPozNeg;
            for (int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] > 0)
                { poz++; }
                else
                { neg++; }
            }
            sumPozNeg = neg - poz;
            integrFunk[0] = 0.5 * (ch1[0] + ch1[1])-sred;
            for (int i = 2; i < ch1.Length; i++)
            {
                integrFunk[i - 1] = 0.5 * (ch1[i - 1] + ch1[i])-sred  + integrFunk[i - 2];
            }

            
            Graf gr = new Graf(); //gr.CreateGraph(zedGraphControl1);
            gr.copy(ch1, integrFunk);
            Graf grafic = new Graf();
            grafic.Show();
            System.Drawing.Pen myPen;
            System.Drawing.Pen myPen1;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 40, 40, 40, 550);
            formGraphics.DrawLine(myPen, 40, 550, 800, 550);
            formGraphics.DrawLine(myPen, 40, 40, 38, 43);
            formGraphics.DrawLine(myPen, 40, 40, 42, 43);
            formGraphics.DrawLine(myPen, 800, 550, 797, 548);
            formGraphics.DrawLine(myPen, 800, 550, 797, 552);
            //for (int j = 0; j < N; j++)
            // {
            //    formGraphics.DrawLine(myPen, 40 + 20 * j, 548, 40 + 20 * j, 552);
            //    formGraphics.DrawLine(myPen, 38, 550 - 20 * j, 42, 550 - 20 * j);
            //}
            myPen = new System.Drawing.Pen(System.Drawing.Color.Aqua);
            int n = 0;
            for (int b = 1; b < ch1.Length; b++)
            {
                formGraphics.DrawLine(myPen, (n-10), (int)(300 - ch1[b - 1] * 1000), n, (int)(300 - ch1[b] * 100));
                n+=10;
            }
            myPen1 = new System.Drawing.Pen(System.Drawing.Color.Orange);
            n = 0;
            for (int b = 1; b < integrFunk.Length; b++)
            {
                formGraphics.DrawLine(myPen1, (n - 10), (int)(300 - integrFunk[b - 1] * 100), n, (int)(300 - integrFunk[b] * 100));
                n += 10;
            }
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           int tb5t=0;
           int tb6t=0;
            //string[] chLines=null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                ch1 = new double[Convert.ToInt32(textBox6.Text) * 78125 - Convert.ToInt32(textBox5.Text) * 78125];
               // float[] ch1;
              //  chLines = new string[lines.Length - 19];
                //ch1 = DiagnostData.strTodb(lines);
               // ch1 = DiagnostData.StringToDouble(lines);
                tb5t = Convert.ToInt32(textBox5.Text);
                tb6t = Convert.ToInt32(textBox6.Text);
                //ch1 = DiagnostData.strTodb(lines, tb5t, tb6t);
                ch1 = DiagnostData.StringToDouble(lines, tb5t, tb6t);

                progressBar1.Visible = true;
               progressBar1.Maximum = Convert.ToInt32(textBox6.Text) * 78125 - Convert.ToInt32(textBox5.Text) * 78125;
               // button5.Visible = true;
                tb5t *= 78125;
                tb6t *= 78125;
                
            }/*
           
            for (int i = 0; i < tb6t - tb5t; i++)
            {
                progressBar1.Value++;
                ch1[i] = Convert.ToDouble(lines[i + tb5t + 19].Substring(12, 10).Replace(".", ","));
                
            }
            this.button3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;*/
            //progressBar1.Visible = false;
            // время конвертации с 4 по 5 с: 36,23
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox4.Text);

             double k1 = 0;
             double kk1 = 0;
             double[] xRe = new double[ch1.Length];
             double[] xIm = new double[ch1.Length];
             double[] Xres = new double[N];
             double[] PHIres = new double[N];
             double[] ResRe = new double[N];
             double[] ResIM = new double[N];

             for (int i =0, n = Convert.ToInt32(textBox5.Text) * 78125; n < Convert.ToInt32(textBox6.Text) * 78125; n++,i++)
            {
                xRe[i] = ch1[n];
                xIm[i] = 0.0; 
                 
            }
             progressBar1.Visible = true;
             progressBar1.Maximum = N;
            for (int k = 0; k < N; k++, k1++)
            {for (int n = 0; n < N; n++)
            {
                ResRe[k] += xRe[n] * ((float)Math.Cos((2 * Math.PI * n * k1) / N)) + xIm[n] * ((float)Math.Cos((2 * Math.PI * n * k1) / N - Math.PI / 2));
                ResIM[k] += xRe[n] * ((float)Math.Sin((2 * Math.PI * n * k1) / N)) + xIm[n] * ((float)Math.Sin((2 * Math.PI * n * k1) / N - Math.PI / 2));
            }
            progressBar1.Value = k;
                Xres[k] = (float)Math.Sqrt(ResRe[k] * ResRe[k] + ResIM[k] * ResIM[k]);
                PHIres[k] = (float)Math.Atan(Math.Round(ResIM[k],4) / ResRe[k]);
            }
            progressBar1.Visible = false;
            
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 40, 40, 40, 550);
            formGraphics.DrawLine(myPen, 40, 550, 800, 550);
            formGraphics.DrawLine(myPen, 40, 40, 38, 43);
            formGraphics.DrawLine(myPen, 40, 40, 42, 43);
            formGraphics.DrawLine(myPen, 800, 550, 797, 548);
            formGraphics.DrawLine(myPen, 800, 550, 797, 552);
            for (int j = 0; j < N; j++)
            {
                formGraphics.DrawLine(myPen, 40 + 20 * j, 548, 40 + 20 * j, 552);
                formGraphics.DrawLine(myPen, 38, 550 - 20 * j, 42, 550 - 20 * j);
            }
            myPen = new System.Drawing.Pen(System.Drawing.Color.Aqua);
            for (int b = 0; b < N; b++)
            {
                formGraphics.DrawLine(myPen, (40 + b * 10), 550, (40 + b * 10), (int)(550 - Xres[b] * 100));

            }
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справка");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(openFileDialog1.FileName,lines);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double MQR = 0;
            for (int i = 0; i < ch1.Length; i++)
            {
                MQR += ch1[i];
            }
            MQR = MQR/ch1.Length;
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
    }
    class Neiron
    {
        public int synaps;
        public double[] synapsValue;

        public Neiron(int s, double[] sV)
        { synaps = s; synapsValue = sV; }

        public Neiron(int k)
        { synaps = k; }


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
    class DiagnostData
    {
        double[] vibroSpeed;
        double[] vibroAksel;
        string nameOfExperiment;
        int chNumber;

        public DiagnostData(double[] vs, int ch, string nOfExp)
        { vibroSpeed = vs; chNumber = ch; nameOfExperiment = nOfExp; }

        public static double[] strTodb(string[] MyStr, int textBox5Text, int textBox6Text)
        {
            MainForm pr = new MainForm();
            double[] ch = new double[textBox6Text * 78125 - textBox5Text * 78125];
            for (int i = 0; i < textBox6Text * 78125 - textBox5Text * 78125; i++)
            {
                pr.progressBarValue++;
                ch[i] = Convert.ToDouble(MyStr[i + textBox5Text + 19].Substring(2, 8).Replace(".", ","));

            }
            return ch;
        }

        public static double[] StringToDouble(string[] MyStr, int textBox5Text, int textBox6Text)
        {
            MainForm pr = new MainForm();
            pr.progressBarValue = 0;
            pr.progressBarVisible = true;
            int znak;
            float poz, drobOrZel;
            double[] ch = new double[textBox6Text * 78125 - textBox5Text * 78125];
            pr.progressBarMaxValue = (textBox6Text * 78125 - textBox5Text * 78125);
            //double min, max, raznost, sred;

            for (int i = 0; i < (textBox6Text * 78125 - textBox5Text * 78125); i++)
            {
                pr.progressBarValue++;
                znak = 1; poz = 0.1f; drobOrZel = 0.1f;
                MyStr[i] = MyStr[(textBox5Text * 78125) + 19 + i].Substring(0, 8);
                foreach (char s in MyStr[i])
                {
                    if (s == '-')
                        poz *= 0.1f;
                    if (s == '.')
                        break;
                    poz *= 10;
                }
                foreach (char s in MyStr[i])
                {
                    switch (s)
                    {
                        case '0': ch[i] += 0 * poz;
                            break;
                        case '1': ch[i] += 1 * poz;
                            break;
                        case '2': ch[i] += 2 * poz;
                            break;
                        case '3': ch[i] += 3 * poz;
                            break;
                        case '4': ch[i] += 4 * poz;
                            break;
                        case '5': ch[i] += 5 * poz;
                            break;
                        case '6': ch[i] += 6 * poz;
                            break;
                        case '7': ch[i] += 7 * poz;
                            break;
                        case '8': ch[i] += 8 * poz;
                            break;
                        case '9': ch[i] += 9 * poz;
                            break;
                        case '-':
                            znak = -1;
                            poz *= 10;
                            break;
                        case '.':
                            //drobOrZel = 0.1f;
                            poz = 1;
                            break;
                    } poz = poz * drobOrZel;
                } ch[i] = znak * ch[i];
            }
            // время конвертации с 4 по 5 с: 11,40
            //pr.progressBarVisible = false;
             return ch;
        }

    }
    class DiagnostMethod
    {
        
    }
}
