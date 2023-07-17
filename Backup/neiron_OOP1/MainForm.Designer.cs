namespace neiron_OOP1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemProject = new System.Windows.Forms.ToolStripMenuItem();
            this.PrjMenuItemCreateProject = new System.Windows.Forms.ToolStripMenuItem();
            this.PrjMenuItemOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDiagnosticMethode = new System.Windows.Forms.ToolStripMenuItem();
            this.MethMenuItemVibro = new System.Windows.Forms.ToolStripMenuItem();
            this.MethMenuItemFuzzy = new System.Windows.Forms.ToolStripMenuItem();
            this.MethMenuItemGate = new System.Windows.Forms.ToolStripMenuItem();
            this.MethMenuItemSPM = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьОбToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьОбьектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "число нейронов 1слоя ";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "число нейронов 3 слоя";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "число нейронов 2 слоя";
            this.label3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(505, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(677, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "гистограмма";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(46, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "N";
            this.label4.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(337, 79);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(460, 23);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(46, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(32, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(46, 147);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(129, 44);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(32, 20);
            this.textBox7.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProject,
            this.MenuItemDiagnosticMethode,
            this.MenuItemObjLibrary});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemProject
            // 
            this.MenuItemProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrjMenuItemCreateProject,
            this.PrjMenuItemOpenProject});
            this.MenuItemProject.Name = "MenuItemProject";
            this.MenuItemProject.Size = new System.Drawing.Size(59, 20);
            this.MenuItemProject.Text = "Проект";
            // 
            // PrjMenuItemCreateProject
            // 
            this.PrjMenuItemCreateProject.Name = "PrjMenuItemCreateProject";
            this.PrjMenuItemCreateProject.Size = new System.Drawing.Size(162, 22);
            this.PrjMenuItemCreateProject.Text = "Создать проект";
            this.PrjMenuItemCreateProject.Click += new System.EventHandler(this.PrjMenuItemCreateProject_Click);
            // 
            // PrjMenuItemOpenProject
            // 
            this.PrjMenuItemOpenProject.Name = "PrjMenuItemOpenProject";
            this.PrjMenuItemOpenProject.Size = new System.Drawing.Size(162, 22);
            this.PrjMenuItemOpenProject.Text = "Открыть проект";
            this.PrjMenuItemOpenProject.Click += new System.EventHandler(this.PrjMenuItemOpenProject_Click);
            // 
            // MenuItemDiagnosticMethode
            // 
            this.MenuItemDiagnosticMethode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MethMenuItemVibro,
            this.MethMenuItemFuzzy,
            this.MethMenuItemGate,
            this.MethMenuItemSPM});
            this.MenuItemDiagnosticMethode.Name = "MenuItemDiagnosticMethode";
            this.MenuItemDiagnosticMethode.Size = new System.Drawing.Size(126, 20);
            this.MenuItemDiagnosticMethode.Text = "Метод диагностики";
            this.MenuItemDiagnosticMethode.Visible = false;
            // 
            // MethMenuItemVibro
            // 
            this.MethMenuItemVibro.Name = "MethMenuItemVibro";
            this.MethMenuItemVibro.Size = new System.Drawing.Size(185, 22);
            this.MethMenuItemVibro.Text = "Вибродиагностика";
            // 
            // MethMenuItemFuzzy
            // 
            this.MethMenuItemFuzzy.Name = "MethMenuItemFuzzy";
            this.MethMenuItemFuzzy.Size = new System.Drawing.Size(185, 22);
            this.MethMenuItemFuzzy.Text = "Нечеткая логика";
            // 
            // MethMenuItemGate
            // 
            this.MethMenuItemGate.Name = "MethMenuItemGate";
            this.MethMenuItemGate.Size = new System.Drawing.Size(185, 22);
            this.MethMenuItemGate.Text = "Пороговый";
            // 
            // MethMenuItemSPM
            // 
            this.MethMenuItemSPM.Name = "MethMenuItemSPM";
            this.MethMenuItemSPM.Size = new System.Drawing.Size(185, 22);
            this.MethMenuItemSPM.Text = "Ударных импульсов";
            // 
            // MenuItemObjLibrary
            // 
            this.MenuItemObjLibrary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОбToolStripMenuItem,
            this.удалитьОбьектToolStripMenuItem});
            this.MenuItemObjLibrary.Name = "MenuItemObjLibrary";
            this.MenuItemObjLibrary.Size = new System.Drawing.Size(137, 20);
            this.MenuItemObjLibrary.Text = "Библиотека обьектов";
            this.MenuItemObjLibrary.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // добавитьОбToolStripMenuItem
            // 
            this.добавитьОбToolStripMenuItem.Name = "добавитьОбToolStripMenuItem";
            this.добавитьОбToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.добавитьОбToolStripMenuItem.Text = "Добавить обьект";
            // 
            // удалитьОбьектToolStripMenuItem
            // 
            this.удалитьОбьектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.удалитьОбьектToolStripMenuItem.Name = "удалитьОбьектToolStripMenuItem";
            this.удалитьОбьектToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.удалитьОбьектToolStripMenuItem.Text = "Удалить обьект";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 39);
            this.button4.TabIndex = 16;
            this.button4.Text = "среднеквадратичное отклонение";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "экспорт";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProject;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDiagnosticMethode;
        private System.Windows.Forms.ToolStripMenuItem MenuItemObjLibrary;
        private System.Windows.Forms.ToolStripMenuItem MethMenuItemVibro;
        private System.Windows.Forms.ToolStripMenuItem MethMenuItemFuzzy;
        private System.Windows.Forms.ToolStripMenuItem MethMenuItemGate;
        private System.Windows.Forms.ToolStripMenuItem MethMenuItemSPM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem PrjMenuItemCreateProject;
        private System.Windows.Forms.ToolStripMenuItem PrjMenuItemOpenProject;
        private System.Windows.Forms.ToolStripMenuItem добавитьОбToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьОбьектToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        
    }
}

