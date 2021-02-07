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
    public partial class FormVSq : Form
    {
        Form1 mform;
        public FormVSq(Form1 mform)
        {
            InitializeComponent();
            this.mform = mform;
        }

        private void FillData()
        {
            string str = mform.fileRW.GetVigAlph();
            int N = str.Length;

            dataGridView1.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns[i].Width = 18;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 18;
            }
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = str[(N + j + i) % N];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mform.fileRW.GenerateVigAlph();
            FillData();
        }

        private void FormVSq_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
