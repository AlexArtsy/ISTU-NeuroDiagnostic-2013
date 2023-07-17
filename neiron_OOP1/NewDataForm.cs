using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace neiron_OOP1
{
    public partial class NewDataForm : Form
    {
        int[] etalon;
        string name;
        int num;
        double[] inputData;
        double[] Spec1;
        double[] Spec2;
        double[] Spec3;

        static int count=0;
        static public NewDataForm [] datas = new NewDataForm[Data.valueOfLern];
        public NewDataForm()
        {
            InitializeComponent();
            //numericUpDown2.Maximum = Data.valueOfOut;
        }
        public NewDataForm(double []d, int n, string st)
        {
            /*num = n;
            name = st;
            etalon = new int[Data.valueOfOutNeiro];
            inputData = d;
            if (numericUpDown2.Value ==1)
            {   
                if ((Data.valueOfOutNeiro / Data.valueOfOut)==1)
                {
                    etalon[0] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[0] = 1;
                    etalon[1] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[0] = 1;
                    etalon[1] = 1;
                    etalon[2] = 1;
                }
            }
            else if (numericUpDown2.Value == 2)
            {
               
                if ((Data.valueOfOutNeiro / Data.valueOfOut) == 1)
                {
                    etalon[1] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[2] = 1;
                    etalon[3] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[3] = 1;
                    etalon[4] = 1;
                    etalon[5] = 1;
                }
            }
            else if (numericUpDown2.Value == 3)
            {
               
                if ((Data.valueOfOutNeiro / Data.valueOfOut) == 1)
                {
                    etalon[2] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[4] = 1;
                    etalon[5] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[6] = 1;
                    etalon[7] = 1;
                    etalon[8] = 1;
                }
            }
            else if (numericUpDown2.Value == 4)
            {
                if ((Data.valueOfOutNeiro / Data.valueOfOut) == 1)
                {
                    etalon[3] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[6] = 1;
                    etalon[7] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[9] = 1;
                    etalon[10] = 1;
                    etalon[11] = 1;
                }
            }
            else if (numericUpDown2.Value == 5)
            {
                if ((Data.valueOfOutNeiro / Data.valueOfOut) == 1)
                {
                    etalon[4] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[8] = 1;
                    etalon[9] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[12] = 1;
                    etalon[13] = 1;
                    etalon[14] = 1;
                }
            }
            else if (numericUpDown2.Value == 6)
            {
                if ((Data.valueOfOutNeiro / Data.valueOfOut) == 1)
                {
                    etalon[5] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[10] = 1;
                    etalon[11] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[15] = 1;
                    etalon[16] = 1;
                    etalon[17] = 1;
                }
            }
            else if (numericUpDown2.Value == 7)
            {
                if ((Data.valueOfOutNeiro / Data.valueOfOut) == 1)
                {
                    etalon[6] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[12] = 1;
                    etalon[13] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[18] = 1;
                    etalon[19] = 1;
                    etalon[20] = 1;
                }
            }
            else if (numericUpDown2.Value == 8)
            {
                if ((Data.valueOfOutNeiro / Data.valueOfOut) == 1)
                {
                    etalon[7] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[14] = 1;
                    etalon[15] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[21] = 1;
                    etalon[22] = 1;
                    etalon[23] = 1;
                }
            }
            else if (numericUpDown2.Value == 9)
            {
                if ((Data.valueOfOutNeiro / Data.valueOfOut) == 1)
                {
                    etalon[8] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[16] = 1;
                    etalon[17] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[24] = 1;
                    etalon[25] = 1;
                    etalon[26] = 1;
                }
            }
            else if (numericUpDown2.Value == 10)
            {
                if ((Data.valueOfOutNeiro / Data.valueOfOut) == 1)
                {
                    etalon[9] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 2)
                {
                    etalon[18] = 1;
                    etalon[19] = 1;
                }
                else if ((Data.valueOfOutNeiro / Data.valueOfOut) == 3)
                {
                    etalon[27] = 1;
                    etalon[28] = 1;
                    etalon[29] = 1;
                }
            }*/
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = null;
                textBox21.Text = openFileDialog1.SafeFileName;
                //openFileDialog1.FileName;
                label19.Text = openFileDialog1.SafeFileName;
                label19.Visible = true;
                numericUpDown1.Visible = true;
                label18.Visible = true;
                lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                Data.ch1 = DiagnostData.StrToDVA(lines, 0);
                
                Data.ch2 = DiagnostData.StrToDVA(lines, 1);

                Data.ch3 = DiagnostData.StrToDVA(lines, 2);
                

                Grafic.CreateGraph(zedGraphControl1, Data.ch1, "Амплитуда", "Время", "Виброускорение");
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();


            }
        }

        private void button2_Click(object sender, EventArgs e) //обработка данных
        {
            int count=0;
            if (checkBox1.Checked == true)
            { count = Spec1.Length; }
            if (checkBox2.Checked == true)
            { count+=Spec2.Length;}
            if (checkBox3.Checked == true)
            { count+= Spec3.Length;}

            double[] Spec = new double[count];
            count = 0;
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < Spec1.Length; i++)
                { Spec[count] = Spec1[i]; count++; }
            }
            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < Spec1.Length; i++)
                { Spec[count] = Spec2[i]; count++; }
            }
            if (checkBox3.Checked == true)
            {
                for (int i = 0; i < Spec1.Length; i++)
                { Spec[count] = Spec3[i]; count++; }
            }
            saveFileDialog1.FileName = textBox21.Text;
            //saveFileDialog1.DefaultExt = "spec";
            //saveFileDialog1.Filter = "Спектр виброускорения|*.spec";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string []str = new string [Spec.Length];

                for (int i = 0; i < str.Length;i++ )
                { str[i] = Convert.ToString(Spec[i]); }
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, str);
            }
            
        }

        private void Graf_Resize(object sender, EventArgs e)
        {
            SetSize();
        }
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10); // задаем положение графика
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 20, ClientRectangle.Height - 20); // размеры графика
        }
        // обработчик события Load формы с графиком
        
        // Функция построения графика

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button2.Visible = false;
            if(numericUpDown1.Value == 1)
                Grafic.CreateGraph(zedGraphControl1, Data.ch1,"Амплитуда","Время","Виброускорение"); // строим график
            else if (numericUpDown1.Value == 2)
                Grafic.CreateGraph(zedGraphControl1, Data.ch2, "Амплитуда", "Время", "Виброускорение");
            else if (numericUpDown1.Value == 3)
                Grafic.CreateGraph(zedGraphControl1, Data.ch3, "Амплитуда", "Время", "Виброускорение");
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            button2.Visible = true;
            Data.secunde = Convert.ToInt32(textBox22.Text);
            int inputs;
            int d = 1;
            inputs = Convert.ToInt32(textBox1.Text);
            while (inputs > d)
            {
                d *= 2;
            }
            inputs = d;
            double[] chSpec = new double[2 * inputs];

            for (int i = 0; i < chSpec.Length; i++)
            { chSpec[i] = Data.ch1[i + Data.secunde * 78125]; }
            chSpec = Data.spec(chSpec);
            Spec1 = new double[chSpec.Length / 2];            
            for (int i = 0; i < Spec1.Length; i++)
            { Spec1[i] = chSpec[i]; }

            for (int i = 0; i < chSpec.Length; i++)
            { chSpec[i] = Data.ch2[i + Data.secunde * 78125]; }
            chSpec = Data.spec(chSpec);
            Spec2 = new double[chSpec.Length / 2];
            for (int i = 0; i < Spec2.Length; i++)
            { Spec2[i] = chSpec[i]; }

            for (int i = 0; i < chSpec.Length; i++)
            { chSpec[i] = Data.ch3[i + Data.secunde * 78125]; }
            chSpec = Data.spec(chSpec);
            Spec3 = new double[chSpec.Length / 2];
            for (int i = 0; i < Spec3.Length; i++)
            { Spec3[i] = chSpec[i]; }

            double[] Spec = new double [Spec1.Length];
            if (numericUpDown1.Value == 1)
            {
                Spec = Spec1;
            }
            else if (numericUpDown1.Value == 2)
            {
                Spec = Spec2;
            }
            else if (numericUpDown1.Value == 3)
            {
                Spec = Spec3;
            }


            Grafic.CreateGraph(zedGraphControl1, Spec, "Амплитуда","N", "Спектр");
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            //datas[count] = new NewDataForm( polDat, (int)numericUpDown2.Value, textBox21.Text);
        }

       


        
    }
    class Grafic
    {
        public Grafic()
        { }
        static public void CreateGraph(ZedGraphControl zgc, double[] ch, string str1, string str2, string str3)
        {

            GraphPane myPane = zgc.GraphPane;

            // Задаем название графика и сторон
            myPane.Title.Text = str3;
            myPane.XAxis.Title.Text = str2;
            myPane.YAxis.Title.Text = str1;

            // --------------------------------
            // строим синусойду

            double x1;

            PointPairList list1 = new PointPairList();
            myPane.CurveList.Clear();

            for (int i = 0; i < ch.Length; i++)
            {
                x1 = i;
                list1.Add(x1, ch[i]);
            }

            LineItem myCurve1 = myPane.AddCurve(str3, list1, Color.Red, SymbolType.None);
            zgc.AxisChange();

        }
    }
}
