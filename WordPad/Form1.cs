using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int countb, countu, counti = 0;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var font in FontFamily.Families)
            {
                cmB_Font.Items.Add(font.Name.ToString());
            }
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    cmB_Color.Items.Add(prop.Name);
            }
            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
        }

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (filenames != null)
                {
                    foreach (var name in filenames)
                    {
                        try
                        {
                            richTextBox1.AppendText(File.ReadAllText(name));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            
        }

        private void cmB_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font=new Font(cmB_Font.Text,int.Parse(cmB_Size.Text));
        }

        private void cmB_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text));         
        }

        private void btn_Bold_Click(object sender, EventArgs e)
        {
            ++countb;
            if (countb % 2 != 0 && counti % 2 != 0 && countu%2!=0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            else if (countb % 2 != 0 && counti % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Bold | FontStyle.Italic);
            else if (countb % 2 != 0 && countu % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Bold | FontStyle.Underline);
            else if(countb % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text),FontStyle.Bold);
            else if(countb%2==0 && counti%2!=0 && countu%2!=0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Italic | FontStyle.Underline);
            else if(countb%2==0 && counti%2!=0 ) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Italic);
            else if(countb%2==0 && countu%2!=0 ) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Underline);
            else if (countb % 2 == 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Regular);
        }

        private void btn_underline_Click(object sender, EventArgs e)
        {
            ++countu;
            if (countb % 2 != 0 && counti % 2 != 0 && countu % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            else if (countu % 2 != 0 && counti % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Underline | FontStyle.Italic);
            else if (countu % 2 != 0 && countb % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Underline | FontStyle.Bold);
            else if (countu % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Underline);
            else if (countu % 2 == 0 && countb % 2 != 0 && counti % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Italic | FontStyle.Bold);
            else if (countu % 2 == 0 && counti % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Italic);
            else if (countu % 2 == 0 && countb % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Bold);
            else if (countu % 2 == 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Regular);
        }


        private void btn_Italic_Click(object sender, EventArgs e)
        {
            ++counti;
            if (countb % 2 != 0 && counti % 2 != 0 && countu % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            else if (counti % 2 != 0 && countu % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Underline | FontStyle.Italic);
            else if (counti % 2 != 0 && countb % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Italic | FontStyle.Bold);
            else if (counti % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Italic);
            else if (counti % 2 == 0 && countb % 2 != 0 && countu % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Underline | FontStyle.Bold);
            else if (counti % 2 == 0 && countu % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Underline);
            else if (counti % 2 == 0 && countb % 2 != 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Bold);
            else if (counti % 2 == 0) richTextBox1.SelectionFont = new Font(cmB_Font.Text, int.Parse(cmB_Size.Text), FontStyle.Regular);
        }

        private void btn_Center_Click(object sender, EventArgs e)
        {
             richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "DefaultOutputName.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(richTextBox1.Text);
                writer.Dispose();
                writer.Close();
                MessageBox.Show("Succesfully saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files|*.*|Text files|*.txt";
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
             richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void cmB_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.FromName(cmB_Color.SelectedItem.ToString());
            richTextBox1.SelectionColor = color;
            
        }

       
    }
}
