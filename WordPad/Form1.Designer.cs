
namespace WordPad
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmB_Color = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Center = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Italic = new System.Windows.Forms.Button();
            this.cmB_Size = new System.Windows.Forms.ComboBox();
            this.btn_underline = new System.Windows.Forms.Button();
            this.cmB_Font = new System.Windows.Forms.ComboBox();
            this.btn_Bold = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.cmB_Color);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_Right);
            this.panel2.Controls.Add(this.btn_Center);
            this.panel2.Controls.Add(this.btn_Left);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Italic);
            this.panel2.Controls.Add(this.cmB_Size);
            this.panel2.Controls.Add(this.btn_underline);
            this.panel2.Controls.Add(this.cmB_Font);
            this.panel2.Controls.Add(this.btn_Bold);
            this.panel2.Location = new System.Drawing.Point(1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 70);
            this.panel2.TabIndex = 1;
            // 
            // cmB_Color
            // 
            this.cmB_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmB_Color.FormattingEnabled = true;
            this.cmB_Color.Location = new System.Drawing.Point(697, 37);
            this.cmB_Color.Name = "cmB_Color";
            this.cmB_Color.Size = new System.Drawing.Size(136, 24);
            this.cmB_Color.TabIndex = 14;
            this.cmB_Color.SelectedIndexChanged += new System.EventHandler(this.cmB_Color_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(737, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(509, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alignment";
            // 
            // btn_Right
            // 
            this.btn_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Right.Location = new System.Drawing.Point(575, 40);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(30, 23);
            this.btn_Right.TabIndex = 11;
            this.btn_Right.Text = "R";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Center
            // 
            this.btn_Center.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Center.Location = new System.Drawing.Point(539, 40);
            this.btn_Center.Name = "btn_Center";
            this.btn_Center.Size = new System.Drawing.Size(30, 23);
            this.btn_Center.TabIndex = 10;
            this.btn_Center.Text = "C";
            this.btn_Center.UseVisualStyleBackColor = true;
            this.btn_Center.Click += new System.EventHandler(this.btn_Center_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Left.Location = new System.Drawing.Point(503, 40);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(30, 23);
            this.btn_Left.TabIndex = 9;
            this.btn_Left.Text = "L";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(327, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Font Style";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(193, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font";
            // 
            // btn_Italic
            // 
            this.btn_Italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Italic.Location = new System.Drawing.Point(388, 40);
            this.btn_Italic.Name = "btn_Italic";
            this.btn_Italic.Size = new System.Drawing.Size(30, 23);
            this.btn_Italic.TabIndex = 6;
            this.btn_Italic.Text = "I";
            this.btn_Italic.UseVisualStyleBackColor = true;
            this.btn_Italic.Click += new System.EventHandler(this.btn_Italic_Click);
            // 
            // cmB_Size
            // 
            this.cmB_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmB_Size.FormattingEnabled = true;
            this.cmB_Size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cmB_Size.Location = new System.Drawing.Point(206, 39);
            this.cmB_Size.Name = "cmB_Size";
            this.cmB_Size.Size = new System.Drawing.Size(36, 23);
            this.cmB_Size.TabIndex = 2;
            this.cmB_Size.Text = "8";
            this.cmB_Size.SelectedIndexChanged += new System.EventHandler(this.cmB_Size_SelectedIndexChanged);
            // 
            // btn_underline
            // 
            this.btn_underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_underline.Location = new System.Drawing.Point(352, 40);
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Size = new System.Drawing.Size(30, 23);
            this.btn_underline.TabIndex = 5;
            this.btn_underline.Text = "U";
            this.btn_underline.UseVisualStyleBackColor = true;
            this.btn_underline.Click += new System.EventHandler(this.btn_underline_Click);
            // 
            // cmB_Font
            // 
            this.cmB_Font.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmB_Font.FormattingEnabled = true;
            this.cmB_Font.Location = new System.Drawing.Point(11, 38);
            this.cmB_Font.Name = "cmB_Font";
            this.cmB_Font.Size = new System.Drawing.Size(136, 24);
            this.cmB_Font.TabIndex = 3;
            this.cmB_Font.SelectedIndexChanged += new System.EventHandler(this.cmB_Font_SelectedIndexChanged);
            // 
            // btn_Bold
            // 
            this.btn_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bold.Location = new System.Drawing.Point(316, 40);
            this.btn_Bold.Name = "btn_Bold";
            this.btn_Bold.Size = new System.Drawing.Size(30, 23);
            this.btn_Bold.TabIndex = 4;
            this.btn_Bold.Text = "B";
            this.btn_Bold.UseVisualStyleBackColor = true;
            this.btn_Bold.Click += new System.EventHandler(this.btn_Bold_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(924, 334);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = " ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(940, 489);
            this.MinimumSize = new System.Drawing.Size(940, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Italic;
        private System.Windows.Forms.ComboBox cmB_Size;
        private System.Windows.Forms.Button btn_underline;
        private System.Windows.Forms.ComboBox cmB_Font;
        private System.Windows.Forms.Button btn_Bold;
        private System.Windows.Forms.ComboBox cmB_Color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Center;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

