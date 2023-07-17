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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemProject = new System.Windows.Forms.ToolStripMenuItem();
            this.PrjMenuItemCreateProject = new System.Windows.Forms.ToolStripMenuItem();
            this.PrjMenuItemOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDiagnosticMethode = new System.Windows.Forms.ToolStripMenuItem();
            this.MethMenuItemNeiro = new System.Windows.Forms.ToolStripMenuItem();
            this.MethMenuItemFuzzy = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProject,
            this.MenuItemDiagnosticMethode,
            this.справкаToolStripMenuItem});
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
            this.MethMenuItemNeiro,
            this.MethMenuItemFuzzy});
            this.MenuItemDiagnosticMethode.Name = "MenuItemDiagnosticMethode";
            this.MenuItemDiagnosticMethode.Size = new System.Drawing.Size(126, 20);
            this.MenuItemDiagnosticMethode.Text = "Метод диагностики";
            // 
            // MethMenuItemNeiro
            // 
            this.MethMenuItemNeiro.Name = "MethMenuItemNeiro";
            this.MethMenuItemNeiro.Size = new System.Drawing.Size(189, 22);
            this.MethMenuItemNeiro.Text = "Нейросетевой метод";
            this.MethMenuItemNeiro.Click += new System.EventHandler(this.MethMenuItemNeiro_Click);
            // 
            // MethMenuItemFuzzy
            // 
            this.MethMenuItemFuzzy.Name = "MethMenuItemFuzzy";
            this.MethMenuItemFuzzy.Size = new System.Drawing.Size(189, 22);
            this.MethMenuItemFuzzy.Text = "Нечеткая логика";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Программный комплекс диагностики систем приводов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProject;
        private System.Windows.Forms.ToolStripMenuItem MethMenuItemNeiro;
        private System.Windows.Forms.ToolStripMenuItem MethMenuItemFuzzy;
        private System.Windows.Forms.ToolStripMenuItem PrjMenuItemCreateProject;
        private System.Windows.Forms.ToolStripMenuItem PrjMenuItemOpenProject;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDiagnosticMethode;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        
    }
}

