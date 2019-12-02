namespace Assignment
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
            this.btn_wholeRun = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_draw = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.textBox_multi = new System.Windows.Forms.TextBox();
            this.textBox_single = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_wholeRun
            // 
            this.btn_wholeRun.Location = new System.Drawing.Point(752, 341);
            this.btn_wholeRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_wholeRun.Name = "btn_wholeRun";
            this.btn_wholeRun.Size = new System.Drawing.Size(324, 41);
            this.btn_wholeRun.TabIndex = 0;
            this.btn_wholeRun.Text = "RUN";
            this.btn_wholeRun.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1092, 28);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // panel_draw
            // 
            this.panel_draw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_draw.Location = new System.Drawing.Point(16, 33);
            this.panel_draw.Margin = new System.Windows.Forms.Padding(4);
            this.panel_draw.Name = "panel_draw";
            this.panel_draw.Size = new System.Drawing.Size(1059, 285);
            this.panel_draw.TabIndex = 5;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(752, 402);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(324, 41);
            this.clear.TabIndex = 8;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(752, 465);
            this.btn_run.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(324, 41);
            this.btn_run.TabIndex = 9;
            this.btn_run.Text = "Execute";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.button3_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(16, 528);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(1060, 52);
            this.reset.TabIndex = 10;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // textBox_multi
            // 
            this.textBox_multi.Location = new System.Drawing.Point(16, 341);
            this.textBox_multi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_multi.Multiline = true;
            this.textBox_multi.Name = "textBox_multi";
            this.textBox_multi.Size = new System.Drawing.Size(711, 112);
            this.textBox_multi.TabIndex = 11;
            // 
            // textBox_single
            // 
            this.textBox_single.Location = new System.Drawing.Point(16, 474);
            this.textBox_single.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_single.Name = "textBox_single";
            this.textBox_single.Size = new System.Drawing.Size(711, 22);
            this.textBox_single.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(16, 598);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(1059, 95);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Console:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 709);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox_single);
            this.Controls.Add(this.textBox_multi);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.panel_draw);
            this.Controls.Add(this.btn_wholeRun);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_wholeRun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel_draw;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox textBox_multi;
        private System.Windows.Forms.TextBox textBox_single;
        private System.Windows.Forms.TextBox textBox3;
    }
}

