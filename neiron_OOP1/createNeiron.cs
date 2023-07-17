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
    public partial class createNeiron : Form
    {
        string[] nameOfOut = new string[10];
        public int[] valueOfneiron = new int[5];
       
        
        
        public createNeiron()
        {
            InitializeComponent();
        }
        int convAndChek(string tb)
        {
            int n=0;
            if (tb == "")
            { MessageBox.Show("Укажите количество нейронов во всех слоях!", "Ошибка!", MessageBoxButtons.OK); }
            else
            {
                n = Convert.ToInt32(tb);
            }
            return n;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //numericUpDown1.Value; 
            if (textBox6.Text == ""&& textBox7.Text =="" &&textBox8.Text == "")
            { MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK); }
            else
            {
                if (numericUpDown1.Value == 1)
                {
                    Data.valueOfneiron = new int[1];
                    Data.valueOfneiron[0] = convAndChek(textBox1.Text);
                }
                else if (numericUpDown1.Value == 2)
                {
                    Data.valueOfneiron = new int[2];
                    Data.valueOfneiron[0] = convAndChek(textBox1.Text);
                    Data.valueOfneiron[1] = convAndChek(textBox2.Text);
                }
                else if (numericUpDown1.Value == 3)
                {
                    Data.valueOfneiron = new int[3];
                    Data.valueOfneiron[0] = convAndChek(textBox1.Text);
                    Data.valueOfneiron[1] = convAndChek(textBox2.Text);
                    Data.valueOfneiron[2] = convAndChek(textBox3.Text);
                }
                else if (numericUpDown1.Value == 4)
                {
                    Data.valueOfneiron = new int[4];
                    Data.valueOfneiron[0] = convAndChek(textBox1.Text);
                    Data.valueOfneiron[1] = convAndChek(textBox2.Text);
                    Data.valueOfneiron[2] = convAndChek(textBox3.Text);
                    Data.valueOfneiron[3] = convAndChek(textBox4.Text);
                }
                else if (numericUpDown1.Value == 5)
                {
                    Data.valueOfneiron = new int[5];
                    Data.valueOfneiron[0] = convAndChek(textBox1.Text);
                    Data.valueOfneiron[1] = convAndChek(textBox2.Text);
                    Data.valueOfneiron[2] = convAndChek(textBox3.Text);
                    Data.valueOfneiron[3] = convAndChek(textBox4.Text);
                    Data.valueOfneiron[4] = convAndChek(textBox5.Text);
                }
                //=================================================================================
                if (numericUpDown2.Value == 2 && (textBox18.Text == "" || textBox10.Text == ""))
                {
                    MessageBox.Show("Укажите названия для ВСЕХ входов!", "Ошибка!", MessageBoxButtons.OK);
                }
                else if (numericUpDown2.Value == 3 && (textBox18.Text == "" || textBox10.Text == "" || textBox11.Text == ""))
                {
                    MessageBox.Show("Укажите названия для ВСЕХ входов!", "Ошибка!", MessageBoxButtons.OK);
                }
                else if (numericUpDown2.Value == 4 && (textBox18.Text == "" || textBox10.Text == "" ||
                    textBox11.Text == "" || textBox12.Text == ""))
                {
                    MessageBox.Show("Укажите названия для ВСЕХ входов!", "Ошибка!", MessageBoxButtons.OK);
                }
                else if (numericUpDown2.Value == 5 && (textBox18.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == ""
                    || textBox13.Text == ""))
                {
                    MessageBox.Show("Укажите названия для ВСЕХ входов!", "Ошибка!", MessageBoxButtons.OK);
                }
                else if (numericUpDown2.Value == 6 && (textBox18.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == ""
                    || textBox13.Text == "" || textBox14.Text == ""))
                {
                    MessageBox.Show("Укажите названия для ВСЕХ входов!", "Ошибка!", MessageBoxButtons.OK);
                }
                else if (numericUpDown2.Value == 7 && (textBox18.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == ""
                    || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == ""))
                {
                    MessageBox.Show("Укажите названия для ВСЕХ входов!", "Ошибка!", MessageBoxButtons.OK);
                }
                else if (numericUpDown2.Value == 8 && (textBox18.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == ""
                    || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == ""))
                {
                    MessageBox.Show("Укажите названия для ВСЕХ входов!", "Ошибка!", MessageBoxButtons.OK);
                }
                else if (numericUpDown2.Value == 9 && (textBox18.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == ""
                    || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == ""
                    || textBox17.Text == ""))
                {
                    MessageBox.Show("Укажите названия для ВСЕХ входов!", "Ошибка!", MessageBoxButtons.OK);
                }
                else if (numericUpDown2.Value == 10 && (textBox18.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == ""
                    || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == ""
                    || textBox17.Text == "" || textBox19.Text == ""))
                {
                    MessageBox.Show("Укажите названия для ВСЕХ входов!", "Ошибка!", MessageBoxButtons.OK);
                }
                else
                {
                    //Data.valueOfChannel = (int)numericUpDown4.Value;
                    Data.valueOfInputs = Convert.ToInt32(textBox7.Text);
                    Data.valueOfLern = Convert.ToInt32(textBox8.Text);
                    Data.nameOfNet = textBox6.Text;
                    Data.valueOfOut = (int)numericUpDown2.Value;
                    Data.valueOfLayer = (int)numericUpDown1.Value;
                    //Data.valueOfNnaOut
                    Data.valueOfOutNeiro = Data.valueOfOut * (int)numericUpDown3.Value;
                    Data.nameOfOut[0] = textBox18.Text;
                    Data.nameOfOut[1] = textBox10.Text;
                    Data.nameOfOut[2] = textBox11.Text;
                    Data.nameOfOut[3] = textBox12.Text;
                    Data.nameOfOut[4] = textBox13.Text;
                    Data.nameOfOut[5] = textBox14.Text;
                    Data.nameOfOut[6] = textBox15.Text;
                    Data.nameOfOut[7] = textBox16.Text;
                    Data.nameOfOut[8] = textBox17.Text;
                    Data.nameOfOut[9] = textBox19.Text;
                    Data.lernData = new DiagnostData[Data.valueOfOut, Data.valueOfLern / Data.valueOfOut];
                    Data.isLearned = false;
                    //Training tr = new Training();
                    
                    this.Close();
                    
                    //tr.Show();
                    //neironMeth nm = new  neironMeth();
                    
                    
                  
                }
                //=======================================
                
               
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 1)
            {
                label3.Visible = false; textBox2.Visible = false;
                label4.Visible = false; textBox3.Visible = false;
                label5.Visible = false; textBox4.Visible = false;
                label6.Visible = false; textBox5.Visible = false;
            }
            if (numericUpDown1.Value == 2)
            {
                label3.Visible = true; textBox2.Visible = true;
                label4.Visible = false; textBox3.Visible = false;
                label5.Visible = false; textBox4.Visible = false;
                label6.Visible = false; textBox5.Visible = false;
            }
            else if (numericUpDown1.Value == 3)
            { 
                label4.Visible = true; textBox3.Visible = true;
                label5.Visible = false; textBox4.Visible = false;
                label6.Visible = false; textBox5.Visible = false;
                
            }
            else if (numericUpDown1.Value == 4)
            {
                label4.Visible = true; textBox3.Visible = true;
                label5.Visible = true; textBox4.Visible = true;
                label6.Visible = false; textBox5.Visible = false;
                
            }
            else if (numericUpDown1.Value == 5)
            {
                label4.Visible = true; textBox3.Visible = true;
                label5.Visible = true; textBox4.Visible = true;
                label6.Visible = true; textBox5.Visible = true;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label21.Text = Convert.ToString(numericUpDown3.Value*numericUpDown2.Value);
            if (numericUpDown2.Value == 2)
            {
                label12.Visible = false; textBox11.Visible = false;
                
            }
            else if (numericUpDown2.Value == 3)
            {
                label12.Visible = true; textBox11.Visible = true;
                label13.Visible = false; textBox12.Visible = false;
            }
            else if (numericUpDown2.Value == 4)
            {
                label13.Visible = true; textBox12.Visible = true;
                label14.Visible = false; textBox13.Visible = false;

            }
            else if (numericUpDown2.Value == 5)
            {
                label14.Visible = true; textBox13.Visible = true;
                label15.Visible = false; textBox14.Visible = false;
            }
            else if (numericUpDown2.Value == 6)
            {
                label15.Visible = true; textBox14.Visible = true;
                label16.Visible = false; textBox15.Visible = false;
            }
            else if (numericUpDown2.Value == 7)
            {
                label16.Visible = true; textBox15.Visible = true;
                label17.Visible = false; textBox16.Visible = false;
            }
            else if (numericUpDown2.Value == 8)
            {
                label17.Visible = true; textBox16.Visible = true;
                label18.Visible = false; textBox17.Visible = false;
            }
            else if (numericUpDown2.Value == 9)
            {
                label18.Visible = true; textBox17.Visible = true;
                label19.Visible = false; textBox19.Visible = false;
            }
            else if (numericUpDown2.Value == 10)
            {
                label19.Visible = true; textBox19.Visible = true;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            label21.Text = Convert.ToString(numericUpDown3.Value * numericUpDown2.Value);
        }

    }
}
