namespace villamos116
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFileHely = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonVonal = new System.Windows.Forms.Button();
            this.buttonGyors = new System.Windows.Forms.Button();
            this.buttonLassu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonMegallo = new System.Windows.Forms.Button();
            this.készítőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csóréLeventeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File elérési útvonala:";
            // 
            // buttonFileHely
            // 
            this.buttonFileHely.Location = new System.Drawing.Point(450, 47);
            this.buttonFileHely.Name = "buttonFileHely";
            this.buttonFileHely.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonFileHely.Size = new System.Drawing.Size(75, 23);
            this.buttonFileHely.TabIndex = 2;
            this.buttonFileHely.Text = "Beolvasás";
            this.buttonFileHely.UseVisualStyleBackColor = true;
            this.buttonFileHely.Click += new System.EventHandler(this.buttonFileOlvas_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(849, 264);
            this.listBox1.TabIndex = 3;
            // 
            // buttonVonal
            // 
            this.buttonVonal.Location = new System.Drawing.Point(3, 355);
            this.buttonVonal.Name = "buttonVonal";
            this.buttonVonal.Size = new System.Drawing.Size(118, 23);
            this.buttonVonal.TabIndex = 5;
            this.buttonVonal.Text = "Vonal összidő";
            this.buttonVonal.UseVisualStyleBackColor = true;
            this.buttonVonal.Click += new System.EventHandler(this.buttonVonal_Click);
            // 
            // buttonGyors
            // 
            this.buttonGyors.Location = new System.Drawing.Point(127, 355);
            this.buttonGyors.Name = "buttonGyors";
            this.buttonGyors.Size = new System.Drawing.Size(75, 23);
            this.buttonGyors.TabIndex = 6;
            this.buttonGyors.Text = "Leggyorsabb";
            this.buttonGyors.UseVisualStyleBackColor = true;
            this.buttonGyors.Click += new System.EventHandler(this.buttonGyors_Click);
            // 
            // buttonLassu
            // 
            this.buttonLassu.Location = new System.Drawing.Point(208, 355);
            this.buttonLassu.Name = "buttonLassu";
            this.buttonLassu.Size = new System.Drawing.Size(75, 23);
            this.buttonLassu.TabIndex = 7;
            this.buttonLassu.Text = "Leglassabb";
            this.buttonLassu.UseVisualStyleBackColor = true;
            this.buttonLassu.Click += new System.EventHandler(this.buttonLassu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.készítőToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonMegallo
            // 
            this.buttonMegallo.Location = new System.Drawing.Point(289, 355);
            this.buttonMegallo.Name = "buttonMegallo";
            this.buttonMegallo.Size = new System.Drawing.Size(75, 23);
            this.buttonMegallo.TabIndex = 9;
            this.buttonMegallo.Text = "Megállók";
            this.buttonMegallo.UseVisualStyleBackColor = true;
            this.buttonMegallo.Click += new System.EventHandler(this.buttonMegallo_Click);
            // 
            // készítőToolStripMenuItem
            // 
            this.készítőToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csóréLeventeToolStripMenuItem,
            this.cToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.készítőToolStripMenuItem.Name = "készítőToolStripMenuItem";
            this.készítőToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.készítőToolStripMenuItem.Text = "Készítő";
            // 
            // csóréLeventeToolStripMenuItem
            // 
            this.csóréLeventeToolStripMenuItem.Name = "csóréLeventeToolStripMenuItem";
            this.csóréLeventeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.csóréLeventeToolStripMenuItem.Text = "Csóré Levente";
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem1.Text = "12.C";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "2024";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 390);
            this.Controls.Add(this.buttonMegallo);
            this.Controls.Add(this.buttonLassu);
            this.Controls.Add(this.buttonGyors);
            this.Controls.Add(this.buttonVonal);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonFileHely);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFileHely;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonVonal;
        private System.Windows.Forms.Button buttonGyors;
        private System.Windows.Forms.Button buttonLassu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonMegallo;
        private System.Windows.Forms.ToolStripMenuItem készítőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csóréLeventeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

