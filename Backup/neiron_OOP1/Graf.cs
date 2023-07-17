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
    public partial class Graf : Form
    {
        public static double [] intDataCh;
        public static double[] dataCh;
        public Graf()
        {
            InitializeComponent();
        }
        private void Graf_Resize(object sender, EventArgs e)
        {
              SetSize();
        }
        private void SetSize()
        {
                zedGraphControl1.Location = new Point( 10, 10 ); // задаем положение графика
                zedGraphControl1.Size = new Size( ClientRectangle.Width - 20, ClientRectangle.Height - 20 ); // размеры графика
        }
        // обработчик события Load формы с графиком

        
        public void copy(double [] ch, double [] intCh)
        {
            dataCh = ch; intDataCh = intCh;
            
           
        }
        // Функция построения графика

        private void CreateGraph( ZedGraphControl zgc)
        {
            
          GraphPane myPane = zgc.GraphPane;
           
          //hScrollBar1.Visible = false;
          zgc.ScrollMaxX = dataCh.Length;
          zgc.ScrollMinX = 1000;

        // Задаем название графика и сторон
          myPane.Title.Text = "График";
          myPane.XAxis.Title.Text = "Ось X";
          myPane.YAxis.Title.Text = "Ось Y";

        // --------------------------------
        // строим синусойду

        double x1, x2;

        PointPairList list1 = new PointPairList();
        PointPairList list2 = new PointPairList();

       /* for (int i = 0; i < intDataCh.Length; i++)
        {
        x1 = i;
       // y = Math.Sin(x);
        list1.Add(x1, intDataCh[i]);
        }

        LineItem myCurve1 = myPane.AddCurve("виброскорость", list1, Color.Red, SymbolType.None);
        zgc.AxisChange();*/

        for (int i = 0; i < dataCh.Length; i++)
        {
            x2 = i;
            // y = Math.Sin(x);
            list2.Add(x2, dataCh[i]);
        }
        // ----------------
        LineItem myCurve2 = myPane.AddCurve( "виброускорение", list2, Color.Blue, SymbolType.None ); // отрисовываем график
        zgc.AxisChange();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateGraph(zedGraphControl1); // строим график
            SetSize(); // и устанавливаем его положение и размер
        }
    }
        
}
