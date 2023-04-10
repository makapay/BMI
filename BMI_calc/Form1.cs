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
            double rost = Convert.ToInt32(textBox1.Text) / 100;
            double ves =  Convert.ToInt32(textBox2.Text);
            double t = ves / rost;
            int BMI = Convert.ToInt32(t);
            if(BMI < 10)
            { trackBar1.Value = Convert.ToInt32(BMI); label9.Text = "Недостаточный"; pictureBox8.Visible = true; }
            if(BMI < 18.5 && BMI >= 10 )
            { trackBar1.Value = Convert.ToInt32(BMI); label9.Text = "Недостаточный";  pictureBox3.Visible = true; }
            if(BMI  >= 18.5 && BMI <= 24.9 )
            { trackBar1.Value = Convert.ToInt32(BMI); label9.Text = "Здоровый"; pictureBox3.Visible = true; }
            if(BMI <= 30 && BMI > 24.9 )
            { trackBar1.Value = Convert.ToInt32(BMI); label9.Text = "Избыточный"; pictureBox9.Visible = true; }
            if(BMI > 30 && BMI <= 35 )
            { trackBar1.Value = Convert.ToInt32(BMI); label9.Text = "Ожирение"; pictureBox10.Visible = true; }
            else
            { trackBar1.Value = 35; label9.Text = "Ожирение"; pictureBox10.Visible = true; }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle= BorderStyle.None;
            pictureBox2.BorderStyle= BorderStyle.Fixed3D;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label9.Text = " ";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            Hide();
        }
    }
}