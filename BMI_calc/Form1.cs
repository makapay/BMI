using BMI_calcPavlova;
using System.Runtime.Serialization.Json;

namespace BMI_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox8.Visible = false;
            pictureBox3.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weights = Convert.ToDouble(textBox2.Text);
            double Heights = Convert.ToDouble(textBox1.Text);
            Heights = Heights / 100;
            double BMI = Math.Round(Weights / (Heights * Heights), 1);

            if (BMI < 18.5)
            { trackBar1.Value = 14; label9.Text = "Недостаточный"; pictureBox8.Visible = true; }

            else if (BMI <= 24.9)
            { trackBar1.Value = 22; label9.Text = "Здоровый"; pictureBox3.Visible = true; }

            else if (BMI <= 30)
            { trackBar1.Value = 27; label9.Text = "Избыточный"; pictureBox9.Visible = true; }

            else if (BMI > 30)
            { trackBar1.Value = 33; label9.Text = "Ожирение"; pictureBox10.Visible = true; }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label9.Text = " ";
            pictureBox3.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            Hide();
        }
    }
}