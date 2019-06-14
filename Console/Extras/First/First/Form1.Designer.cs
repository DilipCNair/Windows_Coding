namespace First
{
    partial class First_Form
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
            this.Button_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.heyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howAreYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_1
            // 
            this.Button_1.Location = new System.Drawing.Point(330, 123);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(144, 27);
            this.Button_1.TabIndex = 0;
            this.Button_1.Text = "SUBMIT";
            this.Button_1.UseVisualStyleBackColor = true;
            this.Button_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ceaser Cypher Encryption";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(55, 85);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(243, 20);
            this.tb1.TabIndex = 2;
            this.tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Your  PLain Text Here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter The Security Key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(525, 85);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(113, 20);
            this.tb2.TabIndex = 5;
            this.tb2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(277, 215);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(286, 20);
            this.tb3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "The Cypher Text is";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filieToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filieToolStripMenuItem
            // 
            this.filieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heyToolStripMenuItem,
            this.whatsUpToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.filieToolStripMenuItem.Name = "filieToolStripMenuItem";
            this.filieToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filieToolStripMenuItem.Text = "File";
            this.filieToolStripMenuItem.Click += new System.EventHandler(this.filieToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.helpToolStripMenuItem.Text = "Edit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.exitToolStripMenuItem.Text = "View";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(290, 247);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::First.Properties.Resources.rvnd_2;
            this.pictureBox1.Location = new System.Drawing.Point(29, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 163);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // heyToolStripMenuItem
            // 
            this.heyToolStripMenuItem.Name = "heyToolStripMenuItem";
            this.heyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.heyToolStripMenuItem.Text = "New";
            // 
            // whatsUpToolStripMenuItem
            // 
            this.whatsUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howAreYouToolStripMenuItem});
            this.whatsUpToolStripMenuItem.Name = "whatsUpToolStripMenuItem";
            this.whatsUpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.whatsUpToolStripMenuItem.Text = "Open";
            // 
            // howAreYouToolStripMenuItem
            // 
            this.howAreYouToolStripMenuItem.Name = "howAreYouToolStripMenuItem";
            this.howAreYouToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howAreYouToolStripMenuItem.Text = "How are you";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(199, 166);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // First_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(769, 422);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "First_Form";
            this.Text = "Cryptography By DILIP";
            this.Load += new System.EventHandler(this.First_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem heyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howAreYouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

