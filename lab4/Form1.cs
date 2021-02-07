using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public FileRW fileRW;

        bool file_loaded = false;
        public Form1()
        {
            InitializeComponent();

            fileRW = new FileRW();
        }

        private void button_File_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            fileRW.Full_fn = openFileDialog1.FileName;

            file_loaded = true;
            Change_ShortFN();
            Load_OrigT();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox_Dec.Clear();
            richTextBox_Enc.Clear();
        }


        private void Change_ShortFN()
        {
            label_ShortFN.Text = fileRW.Short_fn;
        }

        private void Load_OrigT()
        {
            fileRW.ReloadOrigT();
            richTextBox_Orig.Text = fileRW.OrigT;
        }

        private void button_cStart_Click(object sender, EventArgs e)
        {
            if (file_loaded)
            {
                fileRW.CaesarStart((int)numericUpDown_cVal.Value);

                richTextBox_Enc.Text = fileRW.EncT;
                richTextBox_Dec.Text = fileRW.DecT;
            }
        }

        private void button_vStart_Click(object sender, EventArgs e)
        {
            if (file_loaded)
            {
                fileRW.VigenerStart(textBox1.Text);

                richTextBox_Enc.Text = fileRW.EncT;
                richTextBox_Dec.Text = fileRW.DecT;
            }
        }
        private void button_vShowSq_Click(object sender, EventArgs e)
        {
            FormVSq formVSq = new FormVSq(this);
            formVSq.Show();
        }
    }
}
