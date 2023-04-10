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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true; label1.Text = "МЦК Лужники";
            label2.Visible = true; label2.Text = "Услуги:";
            pictureBox2.Visible=true;
            pictureBox3.Visible=true;
            pictureBox4.Visible=false;
            pictureBox5.Visible=false;
            pictureBox6.Visible=false;
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
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;



        }
    }
}
