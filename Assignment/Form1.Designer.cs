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
            this.Run = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_draw = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.textBox_multi = new System.Windows.Forms.TextBox();
            this.SingleLine = new System.Windows.Forms.TextBox();
            this.Console = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(752, 341);
            this.Run.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(324, 41);
            this.Run.TabIndex = 0;
            this.Run.Text = "RUN";
            this.Run.UseVisualStyleBackColor = true;
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
            this.helpToolStripMenuItem});
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
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(752, 402);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(324, 41);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(752, 465);
            this.Execute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(324, 41);
            this.Execute.TabIndex = 9;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(16, 528);
            this.Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(1060, 52);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "RESET";
            this.Reset.UseVisualStyleBackColor = true;
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
            // SingleLine
            // 
            this.SingleLine.Location = new System.Drawing.Point(16, 474);
            this.SingleLine.Margin = new System.Windows.Forms.Padding(4);
            this.SingleLine.Name = "SingleLine";
            this.SingleLine.Size = new System.Drawing.Size(711, 22);
            this.SingleLine.TabIndex = 12;
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Console.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Console.Location = new System.Drawing.Point(16, 598);
            this.Console.Margin = new System.Windows.Forms.Padding(4);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(1059, 95);
            this.Console.TabIndex = 13;
            this.Console.Text = "Console:";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 702);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.SingleLine);
            this.Controls.Add(this.textBox_multi);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.panel_draw);
            this.Controls.Add(this.Run);
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

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel_draw;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox textBox_multi;
        private System.Windows.Forms.TextBox SingleLine;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

