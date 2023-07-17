using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;

namespace neiron_OOP1
{
    public partial class neironMeth : Form
    {
       //static isLearningData
        public neironMeth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Training tr = new Training();
            tr.button2.Click += new EventHandler(learningData2);
            tr.Show();
            label36.Text = Data.nameOfNet;
            label36.Visible = true;
            this.labels = new System.Windows.Forms.Label[Data.valueOfOut];
            this.textBoxes = new System.Windows.Forms.TextBox[Data.valueOfOut, Data.valueOfOutNeiro / Data.valueOfOut];
            for (int i = 0; i < Data.valueOfOut; i++)
            {

                this.labels[i] = new System.Windows.Forms.Label();
                this.labels[i].AutoSize = true;
                this.labels[i].Location = new System.Drawing.Point(6, 50 + i * 25);
                this.labels[i].Name = "labels" + Convert.ToString(i);
                this.labels[i].Size = new System.Drawing.Size(67, 13);
                this.labels[i].TabIndex = 20;
                this.labels[i].Text = Data.nameOfOut[i];
                this.groupBox2.Controls.Add(this.labels[i]);
            }
            for (int i = 0; i < Data.valueOfOut; i++)
            {
                for (int j = 0; j < Data.valueOfOutNeiro / Data.valueOfOut; j++)
                {
                    this.textBoxes[i, j] = new System.Windows.Forms.TextBox();
                    this.textBoxes[i, j].Location = new System.Drawing.Point(104 + j * 46, 48 + i * 25);
                    this.textBoxes[i, j].Name = "textBox" + Convert.ToString(i) + Convert.ToString(j);
                    this.textBoxes[i, j].Size = new System.Drawing.Size(40, 20);
                    this.textBoxes[i, j].TabIndex = 54;
                    this.groupBox2.Controls.Add(this.textBoxes[i, j]);
                }
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewDataForm ndf = new NewDataForm();
            ndf.Show();
        }

        private void button3_Click(object sender, EventArgs e)///////////////////////////////////
        {
            int n = 0;
            for (int i = 0; i < Data.net.layers.Length; i++)
            {
                for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                {
                    for (int k = 0; k < Data.net.layers[i].neiron[j].w.Length; k++)
                    { n++; }
                    n++;
                }
            }

            string[] saveNetData = new string[19+Data.valueOfneiron.Length+n];
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveNetData[0] = Data.nameOfNet;
                saveNetData[1] = Data.nameOfOut[0];
                saveNetData[2] = Data.nameOfOut[1];
                saveNetData[3] = Data.nameOfOut[2];
                saveNetData[4] = Data.nameOfOut[3];
                saveNetData[5] = Data.nameOfOut[4];
                saveNetData[6] = Data.nameOfOut[5];
                saveNetData[7] = Data.nameOfOut[6];
                saveNetData[8] = Data.nameOfOut[7];
                saveNetData[9] = Data.nameOfOut[8];
                saveNetData[10] = Data.nameOfOut[9];
                saveNetData[11] = Convert.ToString(Data.valueOfInputs);
                saveNetData[12] = Convert.ToString(Data.valueOfLayer);
                saveNetData[13] = Convert.ToString(Data.valueOfLern);
                saveNetData[14] = Convert.ToString(Data.valueOfOut);
                saveNetData[15] = Convert.ToString(Data.valueOfOutNeiro);
                saveNetData[16] = Convert.ToString(Data.isLearned);
                int count = 17;
                for (int i = 0; i < Data.valueOfneiron.Length; i++)
                { saveNetData[count] = Convert.ToString(Data.valueOfneiron[i]); count++; }
               

                if (Data.isLearned == true)
                { saveNetData[count] = Convert.ToString( Data.valueOfZycles);
                  count++;
                  saveNetData[count] = Convert.ToString(Data.mistake);
                  count++;
                  progressBar1.Visible = true;
                  
                  progressBar1.Maximum = n + 19 + Data.valueOfneiron.Length;
                 
                  for (int i = 0; i < Data.net.layers.Length; i++)
                  {
                      for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                      {
                          for (int k = 0; k < Data.net.layers[i].neiron[j].w.Length; k++)
                          {
                              saveNetData[count] = Convert.ToString(Data.net.layers[i].neiron[j].w[k]);
                              progressBar1.Value = count;
                              count++;
                          }
                      }
                  }
                  for (int i = 0; i < Data.net.layers.Length; i++)
                  {
                      for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                      {
                          saveNetData[count] = Convert.ToString(Data.net.layers[i].neiron[j].pw);
                          progressBar1.Value = count;
                          count++;

                      }
                  }
                  progressBar1.Visible = false;
                  label37.Text= Convert.ToString(Data.valueOfZycles);
                  label37.Text = Convert.ToString(Data.valueOfZycles); 
                }

                System.IO.File.WriteAllLines(saveFileDialog1.FileName, saveNetData);               
            }            
        }

        private void button5_Click(object sender, EventArgs e) //сохранение весов
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Visible = true;
                int n = 0;
                for (int i = 0; i < Data.net.layers.Length; i++)
                {
                    for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                    {
                        for (int k = 0; k < Data.net.layers[i].neiron[j].w.Length; k++)
                        { n++; } n++;
                    }
                }
                progressBar1.Maximum = n + 1 + Data.valueOfneiron.Length;
                string[] saveWeight = new string[n + 1 + Data.valueOfneiron.Length]; int count = 1;
                saveWeight[0] = Convert.ToString( Data.valueOfInputs);
                for (int i = 0; i < Data.valueOfneiron.Length; i++)
                { saveWeight[count] = Convert.ToString(Data.valueOfneiron[i]); count++;}
                for (int i = 0; i < Data.net.layers.Length; i++)
                {
                    for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                    {
                        for (int k = 0; k < Data.net.layers[i].neiron[j].w.Length; k++)
                        { saveWeight[count] = Convert.ToString(Data.net.layers[i].neiron[j].w[k]);
                        progressBar1.Value = count;
                            count++; }
                    }
                }
                for (int i = 0; i < Data.net.layers.Length; i++)
                {
                    for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                    {
                        
                            saveWeight[count] = Convert.ToString(Data.net.layers[i].neiron[j].pw);
                            progressBar1.Value = count;
                            count++;
                        
                    }
                }
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, saveWeight);
                progressBar1.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Data.isLearned = true;
            string[] lines = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Visible = true;
                int n = 0;
                for (int i = 0; i < Data.net.layers.Length; i++)
                {
                    for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                    {
                        for (int k = 0; k < Data.net.layers[i].neiron[j].w.Length; k++)
                        { n++; } n++;
                    }
                }
                progressBar1.Maximum = n + 1 + Data.valueOfneiron.Length;
                lines = new string[n + 1 + Data.valueOfneiron.Length];
                lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                int count = 1;
              
                for (int i = 0; i < Data.valueOfneiron.Length; i++)
                { count++; }
                for (int i = 0; i < Data.net.layers.Length; i++)
                {
                    for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                    {
                        for (int k = 0; k < Data.net.layers[i].neiron[j].w.Length; k++)
                        { Data.net.layers[i].neiron[j].w[k] = Convert.ToDouble(lines[count]);
                        progressBar1.Value = count; count++;
                        }
                    }
                }
                for (int i = 0; i < Data.net.layers.Length; i++)
                {
                    for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                    {
                       
                            Data.net.layers[i].neiron[j].pw = Convert.ToDouble(lines[count]);
                            progressBar1.Value = count; count++;
                        
                    }
                }
                progressBar1.Visible = false;
            }
        }
        
        private void learningData2(object sender, EventArgs e)
        {
            button5.Visible = true;
            label30.Text = Convert.ToString( Data.Mistake);
            label37.Text = Convert.ToString(Data.valueOfZycles);
            label30.Refresh();
            label37.Refresh();
        }
        private void learningData(object sender, EventArgs e)
        {
            label36.Visible = true;
            label24.Visible = true;
            label26.Visible = true;
            label36.Text = Data.nameOfNet;
            label24.Text = Convert.ToString (Data.valueOfLayer+1);
            label36.Refresh();
            label24.Refresh();
            string n = "";
                for (int i = 0; i < Data.valueOfneiron.Length; i++)
                { n += Convert.ToString(Data.valueOfneiron[i]) + " "; }
                label26.Text = n;
                if (Data.isLearned == false)
                { label30.Text = "не обучена"; label30.Refresh(); }
                else { label37.Text = Convert.ToString(Data.valueOfZycles); label37.Refresh(); }
        }
        private void learningData3(object sender, EventArgs e)
        {
            button6.Visible = true;
            label36.Visible = true;
            label24.Visible = true;
            label26.Visible = true;
            label36.Text = Data.nameOfNet;
            label24.Text = Convert.ToString(Data.valueOfLayer + 1);
            label36.Refresh();
            label24.Refresh();
            string n = "";
            for (int i = 0; i < Data.valueOfneiron.Length; i++)
            { n += Convert.ToString(Data.valueOfneiron[i]) + " "; }
            label26.Text = n;
            if (Data.isLearned == false)
            { label30.Text = "не обучена"; label30.Refresh(); }
            else { label37.Text = Convert.ToString(Data.valueOfZycles); label37.Refresh(); }
            this.labels = new System.Windows.Forms.Label[Data.valueOfOut];
            this.textBoxes = new System.Windows.Forms.TextBox[Data.valueOfOut, Data.valueOfOutNeiro / Data.valueOfOut];
            for (int i = 0; i < Data.valueOfOut; i++)
            {

                this.labels[i] = new System.Windows.Forms.Label();
                this.labels[i].AutoSize = true;
                this.labels[i].Location = new System.Drawing.Point(6, 50 + i * 25);
                this.labels[i].Name = "labels" + Convert.ToString(i);
                this.labels[i].Size = new System.Drawing.Size(67, 13);
                this.labels[i].TabIndex = 20;
                this.labels[i].Text = Data.nameOfOut[i];
                this.groupBox2.Controls.Add(this.labels[i]);
                labels[i].Refresh();
            }
            for (int i = 0; i < Data.valueOfOut; i++)
            {
                for (int j = 0; j < Data.valueOfOutNeiro / Data.valueOfOut; j++)
                {
                    this.textBoxes[i, j] = new System.Windows.Forms.TextBox();
                    this.textBoxes[i, j].Location = new System.Drawing.Point(104 + j * 46, 48 + i * 25);
                    this.textBoxes[i, j].Name = "textBox" + Convert.ToString(i) + Convert.ToString(j);
                    this.textBoxes[i, j].Size = new System.Drawing.Size(40, 20);
                    this.textBoxes[i, j].TabIndex = 54;                    
                    this.groupBox2.Controls.Add(this.textBoxes[i, j]);
                    textBoxes[i, j].Refresh();
                }
            }
            groupBox2.Refresh();
            Data.net = new Net(Data.nameOfNet,Data.nameOfOut);
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double[] outs = new double [Data.valueOfOutNeiro];
            string []lines = new string[Data.valueOfInputs];
            double[] spec = new double[Data.valueOfInputs];
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                spec = DiagnostData.StringToDouble(lines);
                Grafic.CreateGraph(zedGraphControl1, spec, "Амплитуда", "N", "Спектр");
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
                outs = Net.netRun(spec, Data.net );
                int n=0;
                for (int i = 0; i < Data.valueOfOut; i++)
                {
                    for (int j = 0; j < Data.valueOfOutNeiro / Data.valueOfOut; j++)
                    {
                        this.textBoxes[i, j].Text = Convert.ToString(outs[n]);
                        this.textBoxes[i, j].Refresh();
                        n++;                        
                    }
                }   

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] lines = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                Data.nameOfNet = lines[0];
                Data.nameOfOut[0] = lines[1];
                Data.nameOfOut[1] = lines[2];
                Data.nameOfOut[2] = lines[3];
                Data.nameOfOut[3] = lines[4];
                Data.nameOfOut[4] = lines[5];
                Data.nameOfOut[5] = lines[6];
                Data.nameOfOut[6] = lines[7];
                Data.nameOfOut[7] = lines[8];
                Data.nameOfOut[8] = lines[9];
                Data.nameOfOut[9] = lines[10];
                Data.valueOfInputs = Convert.ToInt32(lines[11]);
                Data.valueOfLayer = Convert.ToInt32(lines[12]);
                Data.valueOfLern = Convert.ToInt32(lines[13]);
                Data.valueOfOut = Convert.ToInt32(lines[14]);
                Data.valueOfOutNeiro = Convert.ToInt32(lines[15]);
                Data.isLearned = Convert.ToBoolean(lines[16]);
                Data.valueOfneiron = new int[Data.valueOfLayer];/////////////////
                int count = 17;
                for (int i = 0; i < Data.valueOfLayer; i++)
                { Data.valueOfneiron[i] = Convert.ToInt32(lines[count]); count++; }////////////////
                Data.lernData = new DiagnostData[Data.valueOfOut, Data.valueOfLern / Data.valueOfOut];
                Data.net = new Net(Data.nameOfNet, Data.nameOfOut);
                if (Data.isLearned == true)
                {
                    Data.valueOfZycles = Convert.ToInt32(lines[count]);
                    label37.Text = lines[count];

                    count++;
                    Data.Mistake = Convert.ToDouble(lines[count]);
                    label30.Text = lines[count];
                    count++;

                    progressBar1.Visible = true;

                    progressBar1.Maximum = lines.Length;
                    
                    for (int i = 0; i < Data.net.layers.Length; i++)
                    {
                        for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                        {
                            for (int k = 0; k < Data.net.layers[i].neiron[j].w.Length; k++)
                            {
                                Data.net.layers[i].neiron[j].w[k] = Convert.ToDouble(lines[count]);
                                progressBar1.Value = count;
                                count++;
                            }
                        }
                    }
                    for (int i = 0; i < Data.net.layers.Length; i++)
                    {
                        for (int j = 0; j < Data.net.layers[i].neiron.Length; j++)
                        {
                            Data.net.layers[i].neiron[j].pw = Convert.ToDouble(lines[count]);
                            progressBar1.Value = count;
                            count++;
                        }
                    }
                    progressBar1.Visible = false;
                }
                if (Data.isLearned == false)
                { button1.Visible = true; }
                label36.Text = Data.nameOfNet;
                label36.Visible = true;
                this.labels = new System.Windows.Forms.Label[Data.valueOfOut];
                this.textBoxes = new System.Windows.Forms.TextBox[Data.valueOfOut, Data.valueOfOutNeiro / Data.valueOfOut];
                for (int i = 0; i < Data.valueOfOut; i++)
                {

                    this.labels[i] = new System.Windows.Forms.Label();
                    this.labels[i].AutoSize = true;
                    this.labels[i].Location = new System.Drawing.Point(6, 50 + i * 25);
                    this.labels[i].Name = "labels" + Convert.ToString(i);
                    this.labels[i].Size = new System.Drawing.Size(67, 13);
                    this.labels[i].TabIndex = 20;
                    this.labels[i].Text = Data.nameOfOut[i];
                    this.groupBox2.Controls.Add(this.labels[i]);
                }
                for (int i = 0; i < Data.valueOfOut; i++)
                {
                    for (int j = 0; j < Data.valueOfOutNeiro / Data.valueOfOut; j++)
                    {
                        this.textBoxes[i, j] = new System.Windows.Forms.TextBox();
                        this.textBoxes[i, j].Location = new System.Drawing.Point(104 + j * 46, 48 + i * 25);
                        this.textBoxes[i, j].Name = "textBox" + Convert.ToString(i) + Convert.ToString(j);
                        this.textBoxes[i, j].Size = new System.Drawing.Size(40, 20);
                        this.textBoxes[i, j].TabIndex = 54;
                        this.groupBox2.Controls.Add(this.textBoxes[i, j]);
                    }
                }
                label36.Text = Data.nameOfNet;
                label24.Text = Convert.ToString(Data.valueOfLayer + 1);
                label24.Visible = true;
                string n = "";
                for (int i = 0; i < Data.valueOfneiron.Length; i++)
                { n += Convert.ToString(Data.valueOfneiron[i]) + "  "; }
                n += Convert.ToString(Data.valueOfOutNeiro);
                label26.Text = n;
                label26.Visible = true;
                if (Data.isLearned == true)
                {
                    button1.Visible = true;
                    button1.Text = "переобучить";
                }
                if (Data.valueOfOutNeiro / Data.valueOfOut == 2)
                { label34.Visible = true; }
                else if (Data.valueOfOutNeiro / Data.valueOfOut == 3)
                { label34.Visible = true; label35.Visible = true; }
                button5.Visible = true;
                button6.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            createNeiron crNeiroForm = new createNeiron();
            crNeiroForm.button1.Click += new EventHandler(learningData3);
            crNeiroForm.Show();
            button1.Visible = true;
        }


    }
    class Neiron
    {
         double[] input;
         public double Out;
         public double[] w;
         public double m;
         public double pw;    // пороговый вес
         public double delta;
         public double sigma; 
         public double [,] historyOfW;
         public double[] historyOfPW;

        
        public Neiron()            
        { }
        public Neiron(int valueOfInput, double sig, int nomer)                 // конструктор для нейронов
        {
            sigma = sig;
            input = new double[valueOfInput];
            Out = 0;
            w = new double[valueOfInput];
            Random rnd = new Random();
            pw = rnd.NextDouble() / 100.0;
            for (int i = 0; i < valueOfInput; i++)
            {
                w[i] = rnd.NextDouble() /100.0;
            }
            if (nomer != 0)
            {
                historyOfW = new double[40000, valueOfInput];
                historyOfPW = new double[40000];
            }
            else
            {
                historyOfW = new double[0, 0];
                historyOfPW = new double[0];
            }
        }       
    }
    class Layer
    {
       
       public Neiron [] neiron;
        public Layer(int vOfNeiron, int vOfInputs, double sigma, int nomer)
        {
            neiron = new Neiron[vOfNeiron];
            for (int i = 0; i < vOfNeiron; i++)
            {
                neiron[i] = new Neiron(vOfInputs,sigma,nomer);

            }
        }
    }
    class Net
    { 
        string[] nameOfOut;
        string nameOfNet;
        public Layer []layers = new Layer[Data.valueOfLayer+1];
        
        public Net()
        { }
        public Net(string nOfNet, string [] nOfOut)
        {
            int i;
            nameOfOut = nOfOut;
            nameOfNet = nOfNet;
            layers[0] = new Layer(Data.valueOfneiron[0], Data.valueOfInputs, -0.5,0);
            //layers[1] = new Layer(Data.valueOfneiron[1], Data.valueOfneiron[0],-0.9);

            for (i = 1; i < layers.Length-1;i++ )
            {
                layers[i] = new Layer(Data.valueOfneiron[i], Data.valueOfneiron[i-1],-0.9,i);
            }
            layers[i] = new Layer(Data.valueOfOutNeiro, Data.valueOfneiron[i-1],-0.9,i);
        }

        
        static public double [] netRun(double []inputs, Net net)
        {
            double[] outs = new double[net.layers[0].neiron.Length];
            for (int a = 0; a < net.layers[0].neiron.Length; a++)
            {
                net.layers[0].neiron[a].Out = OutOfNeiron(net.layers[0].neiron[a].w, inputs, net.layers[0].neiron[a].pw,net.layers[0].neiron[a].sigma);
                outs[a] = net.layers[0].neiron[a].Out;
                if (outs[a] == 0.9999)
                {
                    error er = new error();
                    er.Show();
                    break;
                }
            }
            inputs = outs;
            for (int a = 1; a < net.layers.Length; a++ )
            {
                outs = new double[net.layers[a].neiron.Length];
                for (int b = 0; b < net.layers[a].neiron.Length; b++)
                {
                    net.layers[a].neiron[b].Out = OutOfNeiron(net.layers[a].neiron[b].w, inputs, net.layers[a].neiron[b].pw, net.layers[a].neiron[b].sigma);
                    outs[b] = net.layers[a].neiron[b].Out;
                    if(outs[b] == 0.9999)
                    {

                    }
                }
                inputs = outs;
            }
            return outs;        
        }
        static public double OutOfNeiron(double []w, double [] input, double pw, double sigma)
        {
            double  o = 0;
            double Sum =0;
            for (int i = 0; i < w.Length; i++ )
            { Sum += w[i] * input[i]; }
            Sum -= pw;
            o = 1.0 / (1.0 + Math.Exp(sigma * Sum));
            return o;
        }
    }
    class Data
    { 
        public static string nameOfNet;
        public static string[] nameOfOut = new string [10];
        public static int[] valueOfneiron;
        public static int valueOfOut;
        public static int valueOfInputs;
        public static int valueOfLayer;
        public static int valueOfChannel;
        public static int valueOfOutNeiro;
        public static int valueOfLern;
        public static int valueOfZycles;
        public static double Mistake;
        public static int secunde;
        public static bool isLearned;
        public static double[] ch1 = new double[781250];
        public static double[] ch2 = new double[781250];
        public static double[] ch3 = new double[781250];
        public static DiagnostData[,] lernData;
        //public static double[,,] weights ;
        public static double[] mistake = new double [500000];
        //public static double[] weight;
        public static Net net;
       

        private static Complex w(int k, int N)
        {
            if (k % N == 0) return 1;
            double arg = -2 * Math.PI * k / N;
            return new Complex(Math.Cos(arg), Math.Sin(arg));
        }
        /// <summary>
        /// Возвращает спектр сигнала
        /// </summary>
        /// <param name="x">Массив значений сигнала. Количество значений должно быть степенью 2</param>
        /// <returns>Массив со значениями спектра сигнала</returns>
        public static Complex[] fft(Complex[] x)
        {
            Complex[] X;
            int N = x.Length;
            if (N == 2)
            {
                X = new Complex[2];
                X[0] = x[0] + x[1];
                X[1] = x[0] - x[1];
            }
            else
            {
                Complex[] x_even = new Complex[N / 2];
                Complex[] x_odd = new Complex[N / 2];
                for (int i = 0; i < N / 2; i++)
                {
                    x_even[i] = x[2 * i];
                    x_odd[i] = x[2 * i + 1];
                }
                Complex[] X_even = fft(x_even);
                Complex[] X_odd = fft(x_odd);
                X = new Complex[N];
                for (int i = 0; i < N / 2; i++)
                {
                    X[i] = X_even[i] + w(i, N) * X_odd[i];
                    X[i + N / 2] = X_even[i] - w(i, N) * X_odd[i];
                }
            }
            return X;
        }
        public static  double [] spec(double [] dat)
        {
            double[] amp = new double[dat.Length];
            double[] noncompRe = dat;
            double[] noncompIm = new double[dat.Length];
            Complex[] cmp = new Complex[dat.Length];
            for (int i = 0; i < dat.Length; i++)
            {
                noncompRe[i] = dat[i];
                noncompIm[i] = 0;
                
                cmp[i] = new Complex(noncompRe[i], noncompIm[i]);
            }
            cmp = fft(cmp);
            
            for (int i = 0; i < dat.Length; i++)
            {
                amp[i] = Math.Sqrt(cmp[i].Real*cmp[i].Real+cmp[i].Imaginary*cmp[i].Imaginary)/amp.Length;
            }
            return amp;
        }
    }
    class DiagnostData
    {
        public int Outs;
        public  int[] etalon;
        public double[] dInputs= new double[Data.valueOfInputs];
        public DiagnostData(int outs, double [] spec)
        {
            int v;
            etalon = new int[Data.valueOfOutNeiro];
            for (int i = 0; i < Data.valueOfInputs; i++ )
            {dInputs[i] = spec[i]; Outs = outs;}
            v = Data.valueOfOutNeiro / Data.valueOfOut;
            for (int i = 0; i < (outs - 1)*v; i++)
            { etalon[i] = 0; }
            for (int i = (outs - 1)*v; i < (outs - 1)*v+v; i++)
            { etalon[i] = 1; }
            for (int i = (outs - 1)*v+v; i < etalon.Length; i++)
            { etalon[i] = 0; }

        }

        public static double [] StrToDVA(string[] Str, int chNumber)
        {
            double[] ch = new double[781250];
            string[] str = new string[3];
            string[] myStr = new string[781250];
            for (int i = 0; i < 781250; i++)
            {
                str = Str[19 + i].Split(' ');
                int n = 0;
                for (int k = 0; k < str.Length; k++)
                {

                    if (str[k] != "")
                    { str[n] = str[k]; n++; }
                }
                myStr[i] = str[chNumber];
            }
          
             int znak;
             float poz, drobOrZel;
             for (int i = 0; i < myStr.Length; i++)
             {

                 znak = 1; poz = 0.1f; drobOrZel = 0.1f;

                 foreach (char s in myStr[i])
                 {
                     if (s == '-')
                         poz *= 0.1f;
                     if ((s == '.') || (s == ','))
                         break;
                     poz *= 10;
                 }
                 foreach (char s in myStr[i])
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
                 } ch[i] = Math.Round(znak * ch[i], 8);
             }
        return ch;
    }
    public static double[] StringToDouble(string[] MyStr)
    {
        double[] ch = new double[MyStr.Length];
        for (int i = 0; i < ch.Length; i++)
        { ch[i] = Convert.ToDouble(MyStr[i])*1000; }
                return ch;
        }
    }
}
