namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_MoveX = new System.Windows.Forms.TextBox();
            this.textBox_MoveY = new System.Windows.Forms.TextBox();
            this.textBox_MoveZ = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_RotateZ = new System.Windows.Forms.TextBox();
            this.textBox_RotateY = new System.Windows.Forms.TextBox();
            this.textBox_RotateX = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Полигон";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_MoveX
            // 
            this.textBox_MoveX.Location = new System.Drawing.Point(12, 110);
            this.textBox_MoveX.Name = "textBox_MoveX";
            this.textBox_MoveX.Size = new System.Drawing.Size(43, 20);
            this.textBox_MoveX.TabIndex = 5;
            this.textBox_MoveX.TextChanged += new System.EventHandler(this.textBox_MoveX_TextChanged);
            // 
            // textBox_MoveY
            // 
            this.textBox_MoveY.Location = new System.Drawing.Point(61, 110);
            this.textBox_MoveY.Name = "textBox_MoveY";
            this.textBox_MoveY.Size = new System.Drawing.Size(43, 20);
            this.textBox_MoveY.TabIndex = 6;
            this.textBox_MoveY.TextChanged += new System.EventHandler(this.textBox_MoveY_TextChanged);
            // 
            // textBox_MoveZ
            // 
            this.textBox_MoveZ.Location = new System.Drawing.Point(110, 110);
            this.textBox_MoveZ.Name = "textBox_MoveZ";
            this.textBox_MoveZ.Size = new System.Drawing.Size(43, 20);
            this.textBox_MoveZ.TabIndex = 7;
            this.textBox_MoveZ.TextChanged += new System.EventHandler(this.textBox_MoveZ_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Изменить размер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Переместить (x, y, z)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Поворот (x, y, z)";
            // 
            // textBox_RotateZ
            // 
            this.textBox_RotateZ.Location = new System.Drawing.Point(110, 179);
            this.textBox_RotateZ.Name = "textBox_RotateZ";
            this.textBox_RotateZ.Size = new System.Drawing.Size(43, 20);
            this.textBox_RotateZ.TabIndex = 13;
            this.textBox_RotateZ.TextChanged += new System.EventHandler(this.textBox_RotateZ_TextChanged);
            // 
            // textBox_RotateY
            // 
            this.textBox_RotateY.Location = new System.Drawing.Point(61, 179);
            this.textBox_RotateY.Name = "textBox_RotateY";
            this.textBox_RotateY.Size = new System.Drawing.Size(43, 20);
            this.textBox_RotateY.TabIndex = 12;
            this.textBox_RotateY.TextChanged += new System.EventHandler(this.textBox_RotateY_TextChanged);
            // 
            // textBox_RotateX
            // 
            this.textBox_RotateX.Location = new System.Drawing.Point(12, 179);
            this.textBox_RotateX.Name = "textBox_RotateX";
            this.textBox_RotateX.Size = new System.Drawing.Size(43, 20);
            this.textBox_RotateX.TabIndex = 11;
            this.textBox_RotateX.TextChanged += new System.EventHandler(this.textBox_RotateX_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Переместить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Повернуть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_RotateZ);
            this.Controls.Add(this.textBox_RotateY);
            this.Controls.Add(this.textBox_RotateX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_MoveZ);
            this.Controls.Add(this.textBox_MoveY);
            this.Controls.Add(this.textBox_MoveX);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_MoveX;
        private System.Windows.Forms.TextBox textBox_MoveY;
        private System.Windows.Forms.TextBox textBox_MoveZ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_RotateZ;
        private System.Windows.Forms.TextBox textBox_RotateY;
        private System.Windows.Forms.TextBox textBox_RotateX;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

