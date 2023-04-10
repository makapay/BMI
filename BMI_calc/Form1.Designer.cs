namespace BMI_calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            trackBar1 = new TrackBar();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(90, 371);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 0;
            button1.Text = "Расчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(246, 371);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 1;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(102, 278);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Рост:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = BMI_calcPavlova.Properties.Resources.male_icon;
            pictureBox1.Location = new Point(73, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = BMI_calcPavlova.Properties.Resources.female_icon;
            pictureBox2.Location = new Point(216, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 324);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 8;
            label2.Text = "Вес:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 278);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 10;
            label4.Text = "см";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(504, 371);
            trackBar1.Maximum = 35;
            trackBar1.Minimum = 10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(370, 45);
            trackBar1.TabIndex = 11;
            trackBar1.Value = 33;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = BMI_calcPavlova.Properties.Resources.bmi_healthy_icon;
            pictureBox3.Location = new Point(556, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 329);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 14;
            label3.Text = "кг";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Yellow;
            pictureBox4.Location = new Point(504, 425);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(138, 10);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Lime;
            pictureBox6.Location = new Point(639, 425);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(86, 10);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox7.Location = new Point(791, 425);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(83, 10);
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Yellow;
            pictureBox5.Location = new Point(722, 425);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(71, 10);
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 448);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 20;
            label5.Text = "Недостаточный ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(651, 448);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 21;
            label6.Text = "Здоровый";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(720, 448);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 22;
            label7.Text = "Избыточный ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(809, 448);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 23;
            label8.Text = "Ожирение";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = BMI_calcPavlova.Properties.Resources.bmi_underweight_icon;
            pictureBox8.Location = new Point(556, 43);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(250, 250);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 24;
            pictureBox8.TabStop = false;
            pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = BMI_calcPavlova.Properties.Resources.bmi_overweight_icon;
            pictureBox9.Location = new Point(556, 43);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(250, 250);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 25;
            pictureBox9.TabStop = false;
            pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = BMI_calcPavlova.Properties.Resources.bmi_obese_icon;
            pictureBox10.Location = new Point(556, 43);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(250, 250);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 26;
            pictureBox10.TabStop = false;
            pictureBox10.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(639, 318);
            label9.Name = "label9";
            label9.Size = new Size(0, 21);
            label9.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(108, 43);
            label10.Name = "label10";
            label10.Size = new Size(222, 37);
            label10.TabIndex = 28;
            label10.Text = "BMI калькулятор";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(90, 448);
            button3.Name = "button3";
            button3.Size = new Size(90, 30);
            button3.TabIndex = 29;
            button3.Text = "Далее";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(912, 539);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(trackBar1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI калькулятор";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label4;
        internal PictureBox pictureBox1;
        private TrackBar trackBar1;
        private PictureBox pictureBox3;
        private EventHandler label5_Click;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private Label label5;
        private EventHandler label5_Click_1;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private EventHandler button2_Click;
        private Label label9;
        private Label label10;
        private Button button3;
    }
}