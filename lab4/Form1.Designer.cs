namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown_cVal = new System.Windows.Forms.NumericUpDown();
            this.richTextBox_Dec = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Enc = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Orig = new System.Windows.Forms.RichTextBox();
            this.button_cStart = new System.Windows.Forms.Button();
            this.button_LoadFile = new System.Windows.Forms.Button();
            this.button_vStart = new System.Windows.Forms.Button();
            this.button_vShowSq = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_ShortFN = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cVal)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_cVal
            // 
            this.numericUpDown_cVal.Location = new System.Drawing.Point(190, 14);
            this.numericUpDown_cVal.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_cVal.Name = "numericUpDown_cVal";
            this.numericUpDown_cVal.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown_cVal.TabIndex = 3;
            // 
            // richTextBox_Dec
            // 
            this.richTextBox_Dec.Location = new System.Drawing.Point(560, 56);
            this.richTextBox_Dec.Name = "richTextBox_Dec";
            this.richTextBox_Dec.ReadOnly = true;
            this.richTextBox_Dec.Size = new System.Drawing.Size(266, 271);
            this.richTextBox_Dec.TabIndex = 2;
            this.richTextBox_Dec.Text = "";
            // 
            // richTextBox_Enc
            // 
            this.richTextBox_Enc.Location = new System.Drawing.Point(288, 56);
            this.richTextBox_Enc.Name = "richTextBox_Enc";
            this.richTextBox_Enc.ReadOnly = true;
            this.richTextBox_Enc.Size = new System.Drawing.Size(266, 271);
            this.richTextBox_Enc.TabIndex = 2;
            this.richTextBox_Enc.Text = "";
            // 
            // richTextBox_Orig
            // 
            this.richTextBox_Orig.Location = new System.Drawing.Point(16, 56);
            this.richTextBox_Orig.Name = "richTextBox_Orig";
            this.richTextBox_Orig.ReadOnly = true;
            this.richTextBox_Orig.Size = new System.Drawing.Size(266, 271);
            this.richTextBox_Orig.TabIndex = 2;
            this.richTextBox_Orig.Text = "";
            // 
            // button_cStart
            // 
            this.button_cStart.Location = new System.Drawing.Point(250, 13);
            this.button_cStart.Name = "button_cStart";
            this.button_cStart.Size = new System.Drawing.Size(75, 22);
            this.button_cStart.TabIndex = 1;
            this.button_cStart.Text = "Start";
            this.button_cStart.UseVisualStyleBackColor = true;
            this.button_cStart.Click += new System.EventHandler(this.button_cStart_Click);
            // 
            // button_LoadFile
            // 
            this.button_LoadFile.Location = new System.Drawing.Point(16, 12);
            this.button_LoadFile.Name = "button_LoadFile";
            this.button_LoadFile.Size = new System.Drawing.Size(75, 23);
            this.button_LoadFile.TabIndex = 0;
            this.button_LoadFile.Text = "FIle";
            this.button_LoadFile.UseVisualStyleBackColor = true;
            this.button_LoadFile.Click += new System.EventHandler(this.button_File_Click);
            // 
            // button_vStart
            // 
            this.button_vStart.Location = new System.Drawing.Point(598, 14);
            this.button_vStart.Name = "button_vStart";
            this.button_vStart.Size = new System.Drawing.Size(75, 23);
            this.button_vStart.TabIndex = 4;
            this.button_vStart.Text = "Start";
            this.button_vStart.UseVisualStyleBackColor = true;
            this.button_vStart.Click += new System.EventHandler(this.button_vStart_Click);
            // 
            // button_vShowSq
            // 
            this.button_vShowSq.Location = new System.Drawing.Point(407, 13);
            this.button_vShowSq.Name = "button_vShowSq";
            this.button_vShowSq.Size = new System.Drawing.Size(75, 23);
            this.button_vShowSq.TabIndex = 4;
            this.button_vShowSq.Text = "ShowSq";
            this.button_vShowSq.UseVisualStyleBackColor = true;
            this.button_vShowSq.Click += new System.EventHandler(this.button_vShowSq_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_ShortFN
            // 
            this.label_ShortFN.AutoSize = true;
            this.label_ShortFN.Location = new System.Drawing.Point(97, 18);
            this.label_ShortFN.Name = "label_ShortFN";
            this.label_ShortFN.Size = new System.Drawing.Size(46, 13);
            this.label_ShortFN.TabIndex = 4;
            this.label_ShortFN.Text = "filename";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(745, 14);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 341);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox_Dec);
            this.Controls.Add(this.label_ShortFN);
            this.Controls.Add(this.richTextBox_Enc);
            this.Controls.Add(this.richTextBox_Orig);
            this.Controls.Add(this.numericUpDown_cVal);
            this.Controls.Add(this.button_LoadFile);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_vStart);
            this.Controls.Add(this.button_vShowSq);
            this.Controls.Add(this.button_cStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox_Orig;
        private System.Windows.Forms.Button button_cStart;
        private System.Windows.Forms.Button button_LoadFile;
        private System.Windows.Forms.RichTextBox richTextBox_Dec;
        private System.Windows.Forms.RichTextBox richTextBox_Enc;
        private System.Windows.Forms.Button button_vStart;
        private System.Windows.Forms.Button button_vShowSq;
        private System.Windows.Forms.NumericUpDown numericUpDown_cVal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_ShortFN;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox1;
    }
}

