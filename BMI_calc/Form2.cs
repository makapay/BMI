using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calcPavlova
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true; label1.Text = "Новодевичей\nмонастырь";
            label2.Visible = true; label2.Text = "Услуги:";
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true; label1.Text = "Метро\nКиевская";
            label2.Visible = true; label2.Text = "Услуги:";
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true; label1.Text = "МЦК Лужники";
            label2.Visible = true; label2.Text = "Услуги:";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true; label1.Text = "МИД";
            label2.Visible = true; label2.Text = "Услуги:";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true; label1.Text = "Парк Горького";
            label2.Visible = true; label2.Text = "Услуги:";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true; label1.Text = "Здания РАН";
            label2.Visible = true; label2.Text = "Услуги:";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true; label1.Text = "Метро\nВоробьевы Горы";
            label2.Visible = true; label2.Text = "Услуги:";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true; label1.Text = "Стадион\nЛужники";
            label2.Visible = true; label2.Text = "Услуги:";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }
    }
}
