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
    public partial class Training : Form
    {
        static int c1 = 1;
        static int c2 = 1;
        static int c3 = 1;
        static int c4 = 1;
        static int c5 = 1;
        static int c6 = 1;
        static int c7 = 1;
        static int c8 = 1;
        static int c9 = 1;
        static int c10 = 1;
        static int count = 0;
        double[] ch;
        public Training()
        {
            InitializeComponent();
            numericUpDown1.Maximum = Data.valueOfOut;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int []i = new int [6];
            Random rnd = new Random();
            for (int j = 0; j < 6; j++)
            {
                i[j] = rnd.Next();
               
            }
            //openFileDialog1.DefaultExt = "spec";
            //openFileDialog1.Filter = "Спектр виброускорения|*.spec";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                string[] lines = null;
                lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                ch = new double [lines.Length];
                ch = DiagnostData.StringToDouble(lines);
                Grafic.CreateGraph(zedGraphControl1, ch, "Амплитуда", "N", "Спектр");
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //Data.lernData[count] = new DiagnostData((int)numericUpDown1.Value, ch);   
            if(numericUpDown1.Value ==1)
            {
                if (c1 <= Data.valueOfLern / Data.valueOfOut)
                {
                    Data.lernData[(int)numericUpDown1.Value - 1, c1 - 1] = new DiagnostData((int)numericUpDown1.Value, ch);
                    label34.Text = Convert.ToString(c1);
                    c1++;
                }
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            else if (numericUpDown1.Value == 2)
            {
                if (c2 <= Data.valueOfLern / Data.valueOfOut)
                {
                Data.lernData[(int)numericUpDown1.Value-1, c2-1] = new DiagnostData((int)numericUpDown1.Value, ch);
                label33.Text = Convert.ToString(c2);
                c2++;
                    }
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            else if (numericUpDown1.Value == 3)
            {   
                if (c3 <= Data.valueOfLern / Data.valueOfOut)
                {
                Data.lernData[(int)numericUpDown1.Value-1, c3-1] = new DiagnostData((int)numericUpDown1.Value, ch);
                label32.Text = Convert.ToString(c3);
                c3++;
                    }
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            else if (numericUpDown1.Value == 4)
            {
                if (c4 <= Data.valueOfLern / Data.valueOfOut)
                {
                Data.lernData[(int)numericUpDown1.Value-1, c4-1] = new DiagnostData((int)numericUpDown1.Value, ch);
                label31.Text = Convert.ToString(c4);
                c4++;}
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            else if (numericUpDown1.Value == 5)
            {
                if (c5 <= Data.valueOfLern / Data.valueOfOut)
                {
                Data.lernData[(int)numericUpDown1.Value-1, c5-1] = new DiagnostData((int)numericUpDown1.Value, ch);
                label30.Text = Convert.ToString(c5);
                c5++;}
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            else if (numericUpDown1.Value == 6)
            {
                if (c6 <= Data.valueOfLern / Data.valueOfOut)
                {
                Data.lernData[(int)numericUpDown1.Value-1, c6-1] = new DiagnostData((int)numericUpDown1.Value, ch);
                label29.Text = Convert.ToString(c6);
                c6++;}
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            else if (numericUpDown1.Value == 7)
            {
                if (c7 <= Data.valueOfLern / Data.valueOfOut)
                {
                Data.lernData[(int)numericUpDown1.Value-1, c7-1] = new DiagnostData((int)numericUpDown1.Value, ch);
                label28.Text = Convert.ToString(c7);
                c7++;}
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            else if (numericUpDown1.Value == 8)
            {
                if (c8 <= Data.valueOfLern / Data.valueOfOut)
                {
                Data.lernData[(int)numericUpDown1.Value-1, c8-1] = new DiagnostData((int)numericUpDown1.Value, ch);
                label27.Text = Convert.ToString(c8);
                c8++;}
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            else if (numericUpDown1.Value == 9)
            {
                if (c9 <= Data.valueOfLern / Data.valueOfOut)
                {
                Data.lernData[(int)numericUpDown1.Value-1, c9-1] = new DiagnostData((int)numericUpDown1.Value, ch);
                label26.Text = Convert.ToString(c9);
                c9++;}
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            else if (numericUpDown1.Value == 10)
            {
                if (c10 <= Data.valueOfLern / Data.valueOfOut)
                {
                Data.lernData[(int)numericUpDown1.Value-1, c10-1] = new DiagnostData((int)numericUpDown1.Value, ch);
                label1.Text = Convert.ToString(c10);
                c10++;
                }
                else
                { MessageBox.Show("Вы пытаетесь загрузить лишний обучающий образ", "Ошибка!", MessageBoxButtons.OK); }
            }
            count++;
        }

        private void button2_Click(object sender, EventArgs e) // обучение 
        {
            numericUpDown2.Maximum = Data.net.layers.Length;
            numericUpDown3.Maximum = Data.net.layers[(int)numericUpDown2.Value-1].neiron.Length;
            numericUpDown4.Maximum = Data.net.layers[(int)numericUpDown2.Value - 1].neiron[(int)numericUpDown3.Value - 1].w.Length;
 
            Data.net = new Net(Data.nameOfNet, Data.nameOfOut);/////////////////////
            training.countPar = 0;


            if (radioButton1.Checked == true)
            { training.trainMistake(Convert.ToDouble(textBox3.Text), Data.net, Convert.ToDouble(textBox1.Text));
            Data.Mistake = Convert.ToDouble(textBox3.Text);
            }
            else { training.trainTime(Convert.ToInt32(textBox2.Text), Data.net);
            Data.valueOfZycles = Convert.ToInt32(textBox2.Text);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)// kartinki
        {
            string[] Pictures = new string [40];
            double[] naborAktivPixel = new double[40];

            int k = 0; int n = 1;
            Data.lernData = new DiagnostData [Data.valueOfOut, Data.valueOfLern / Data.valueOfOut];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Pictures[n-1] = "C:\\Users\\Alex\\Desktop\\kursleo\\Новая папка\\" + Convert.ToString(n) + ".bmp";
                    naborAktivPixel = Training.BuildArray(Image.FromFile(Pictures[n-1]));   
                    Data.lernData[i, j] = new DiagnostData( i+1 ,naborAktivPixel);
                    k++; n++;
                }
            }
            
            if (radioButton1.Checked == true)
            { training.trainMistake(Convert.ToDouble(textBox3.Text), Data.net, Convert.ToDouble(textBox1.Text)); }
            else { training.trainTime(Convert.ToInt32(textBox2.Text), Data.net); }

            
            ///////////////////////////////////////////////////////////////////////////////
           /* string[] lines = new string [500000];
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < 500000; i++ )
                { lines[i] = Convert.ToString(Data.mistake[i]); }
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, lines);
            }*/
            ///////////////////////////////////////////////////////////////////////////
            /*for (int j = 0; j < net.layers[0].neiron.Length;j++ )
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < 50000; i++)
                    { lines[i] = Convert.ToString(Data.mistake[i]); }
                    System.IO.File.WriteAllLines(saveFileDialog1.FileName, lines);
                }
            }*/
        }

        static public double[] BuildArray(Image pic)
        {
            int k = 0;
            Bitmap bmp = new Bitmap(pic);
            double[] masOfPixel = new double[1024];
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color a = bmp.GetPixel(j, i);
                    if ((bmp.GetPixel(j, i).R == bmp.GetPixel(j, i).G) && (bmp.GetPixel(j, i).G == bmp.GetPixel(j, i).B) && (bmp.GetPixel(j, i).R == 0))
                    {
                        masOfPixel[k] = 0.9;
                        k++;

                    }
                    else
                    {
                        masOfPixel[k] = 0.1;
                        k++;
                    }

                }
            }
            return masOfPixel;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c1 = 1;
            c2 = 1;
            c3 = 1;
            c4 = 1;
            c5 = 1;
            c6 = 1;
            c7 = 1;
            c8 = 1;
            c9 = 1;
            c10 = 1;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Maximum = Data.net.layers[(int)numericUpDown2.Value-1].neiron.Length;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown4.Maximum = Data.net.layers[(int)numericUpDown2.Value-1].neiron[(int)numericUpDown3.Value-1].w.Length;
        }

        private void button6_Click(object sender, EventArgs e)  //отображение графиков результата обучения
        {
            if (radioButton4.Checked == true)
            {
                Grafic.CreateGraph(zedGraphControl1, training.energyOfM, "Величина", "номер образа", "Энергия ошибки"); }
            else
            {
                if (checkBox1.Checked == false)
                {
                    double[] p = new double[5000];
                    for (int i = 0; i < p.Length; i++)
                    {
                        
                            p[i] = Data.net.layers[(int)numericUpDown2.Value - 1].neiron[(int)numericUpDown3.Value - 1].historyOfW[i,(int)numericUpDown4.Value - 1];
                        
                    }
                
                    Grafic.CreateGraph(zedGraphControl1, p, "Величина", "n", "Изменение весового коэфициента");}
                else{
                       Grafic.CreateGraph(zedGraphControl1, Data.net.layers[(int)numericUpDown2.Value - 1].neiron[(int)numericUpDown3.Value - 1].historyOfPW, "Величина", "n", "Изменение порогового коэфициента");
                    }
                }
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void button7_Click(object sender, EventArgs e)// очистка контрола
        {
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //"C:\\Users\\Alex\\Desktop\\kursleo\\Новая папка\\" + Convert.ToString(n) + ".bmp";
            int cnt = 0;
            for (int i = 0; i < 8;i++ )
            {
                string[] lines = null;
                lines = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Desktop\\лграф\\без повреждения\\"+Convert.ToString(i+1)+" без повреждения 1 канал 3 сек");
                ch = new double[lines.Length];
                ch = DiagnostData.StringToDouble(lines);
                Data.lernData[0, cnt] = new DiagnostData(1, ch);
                cnt++;
            }
            for (int i = 0; i < 8; i++)
            {
                string[] lines = null;
                lines = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Desktop\\лграф\\без повреждения\\" + Convert.ToString(i + 1) + " без повреждения 1 канал 7 сек");
                ch = new double[lines.Length];
                ch = DiagnostData.StringToDouble(lines);
                Data.lernData[0, cnt] = new DiagnostData(1, ch);
                cnt++;
            }
                cnt=0;
            for (int i = 0; i < 8; i++)
            {
                string[] lines = null;
                lines = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Desktop\\лграф\\с повреждением\\" + Convert.ToString(i + 1) + " с повреждением 1 канал 3 сек");
                ch = new double[lines.Length];
                ch = DiagnostData.StringToDouble(lines);
                Data.lernData[1,cnt] = new DiagnostData(2, ch);
                cnt++;
            }
            for (int i = 0; i < 8; i++)
            {
                string[] lines = null;
                lines = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Desktop\\лграф\\с повреждением\\" + Convert.ToString(i + 1) + " с повреждением 1 канал 7 сек");
                ch = new double[lines.Length];
                ch = DiagnostData.StringToDouble(lines);
                Data.lernData[1, cnt] = new DiagnostData(2, ch);
                cnt++;
            }
            MessageBox.Show("Файлы загружены", "Ура!", MessageBoxButtons.OK);
        }
       
///////////////////////////////////////////////////////////////////////
    }
    class training
    {
        //public static double[,] trObrz;
        double[] mistakes = new double[Data.valueOfOutNeiro];
        static public double[] energyOfM = new double [40000];
        static int count1 = 0;
        public static int countPar = 0;
        //Net net;
        public training()
        {
 
        }

        static public void trainMistake(double minMistake, Net net, double alfa)
        {
            double []outs;
            bool isEndTr = false;
            int count = 0;
            
            int k = Data.lernData.Length / Data.valueOfOut;
            Random rnd = new Random();
            //int p = Data.valueOfLern / Data.valueOfOut;
            //int d =0;
            //Data.weights = new double[net.layers[0].neiron.Length, net.layers[0].neiron[0].w.Length, 40000];
            while (isEndTr == false)
            {
                isEndTr = true;
                for (int a = 0; a < k; a++)
                    {
                        for (int b = 0; b < Data.valueOfOut; b++)
                        {  //d = rnd.Next(p);
                           double sum = 0;
                           outs=Net.netRun(Data.lernData[b, a].dInputs, net);
                           training.updateNet(net, outs, Data.lernData[b, a].etalon, alfa, Data.lernData[b, a].dInputs);
                           for (int c = 0; c < net.layers[net.layers.Length - 1].neiron.Length; c++)
                           {
                               
                               sum += Math.Pow(net.layers[net.layers.Length - 1].neiron[c].m,2);
                           }
                           training.energyOfM[count1] = sum / 2.0;
                           count1++;
                        }
                    }
                //////////////////////////////////////////////////////////////////////////////////////
                /*for (int i = 0; i < net.layers[0].neiron.Length; i++)
                {
                    for (int j = 0; j < net.layers[0].neiron[0].w.Length; j++)
                    {
                        Data.weights[i, j, count] = net.layers[0].neiron[i].w[j];
                    }
                }*/
                /////////////////////////////////////////////////////////////////////////////////////
                for (int i = 0; i < Data.valueOfOutNeiro; i++)
                {
                    if (Math.Abs( net.layers[net.layers.Length - 1].neiron[i].m) > minMistake)
                    { isEndTr = false; }
                }
                count++;
                training.countPar++;
                if(count==1000)
                { alfa = 0.1; }
                else if (count == 2000)
                { alfa = 0.05; }
                else if (count == 3000)
                { alfa = 0.025; }
               /* else if (count == 4000)
                { alfa = 0.01; }
                else if (count == 5000)
                { alfa = 0.005; }*/

            }
            Data.valueOfZycles = count;
            MessageBox.Show("Обучение закончено", "Ура!", MessageBoxButtons.OK);
            Data.isLearned = true;
        }
        static public void updateNet(Net net, double [] outs,int [] etalon, double alfa, double [] inputData)
        {
            outDelta(etalon,outs,net.layers[net.layers.Length-1].neiron);
            int k = net.layers.Length - 1;
            for (int a = 0; a < k; a++)
            {
                Delta(net.layers[net.layers.Length - 2 - a].neiron, net.layers[net.layers.Length - 1 - a].neiron);
            }
            for (int a = k; a >0; a--)
            {
                for (int b = 0; b < net.layers[a].neiron.Length; b++)
                {
                    for (int c = 0; c < net.layers[a].neiron[b].w.Length; c++)
                    {
                        net.layers[a].neiron[b].w[c] = net.layers[a].neiron[b].w[c] + alfa * net.layers[a].neiron[b].delta * net.layers[a-1].neiron[c].Out;
                        net.layers[a].neiron[b].historyOfW[count1, c] = net.layers[a].neiron[b].w[c];
                    }
                    net.layers[a].neiron[b].pw = net.layers[a].neiron[b].pw - alfa * net.layers[a].neiron[b].delta;
                    net.layers[a].neiron[b].historyOfPW[count1] = net.layers[a].neiron[b].pw;
                }
            }
           
            for (int b = 0; b < net.layers[0].neiron.Length; b++)
            {
                for (int c = 0; c < net.layers[0].neiron[b].w.Length; c++)
                {
                    net.layers[0].neiron[b].w[c] = net.layers[0].neiron[b].w[c] + alfa * net.layers[0].neiron[b].delta * inputData[c];
                    //net.layers[0].neiron[b].historyOfW[count1,c] = net.layers[0].neiron[b].w[c];
                }
                net.layers[0].neiron[b].pw = net.layers[0].neiron[b].pw - alfa * net.layers[0].neiron[b].delta;
               // net.layers[0].neiron[b].historyOfPW[count1] = net.layers[0].neiron[b].pw;
            }

        }

        static public void outDelta(int [] etalon,double[] Out, Neiron []n)
        {
            double []m= new double[Out.Length];
            m = outMistake(etalon,Out);
            for (int i = 0; i < Data.valueOfOutNeiro; i++)
            {
                n[i].delta = m[i] * Out[i] * (1.0 - Out[i]);
                n[i].m = m[i];
            } 
            
        }
        static public void Delta(Neiron[] n, Neiron[] neiron) // Neiron[] n нейроны у которых вычисляем delta
        {
            for (int a = 0; a < n.Length; a++)
            {   double sum=0;
                for (int b = 0; b < neiron.Length; b++)
                { sum += neiron[b].delta * neiron[b].w[a]; }  //neiron - массив нейронов след. слоя                                      
                n[a].delta = n[a].Out * (1.0 - n[a].Out) * sum;
            } 
        
        }
        static public Neiron updateWeights(Neiron neiron, Neiron[] n, double alfa, double [] delta) 
        {
            //NewMasOfWeight2[i, j] = masOfWeight2[i, j] + alfa * Delta2[i] * Out1Sloy[j];
            for (int a = 0; a < neiron.w.Length; a++)
            {
                neiron.w[a] = neiron.w[a] + alfa * delta[a] * n[a].Out;        
            }
           // neiron.pw = neiron.pw +alfa
            return neiron;
        }
        static public double [] outMistake(int [] dt, double []Out)
        {   double [] m = new double [Out.Length]; 
            for (int i = 0; i < Data.valueOfOutNeiro; i++ )
            { m[i] = dt[i] - Out[i]; } return m;         
        }


        static public void trainTime(int valueOfLernTime,Net net)
        {

        }
        public void frStep()
        { }

    }
}
