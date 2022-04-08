using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label15.Text = "Rua Lisboa";

            tableLayoutPanel1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            label3.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label11.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label15.Text = "Марафон 25 км ";
            tableLayoutPanel1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label15.Text = "Avenida Rudge"; 
            tableLayoutPanel1.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label7.Visible = false; 
            label9.Visible = false;
            label11.Visible = false; 





        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            label15.Text = "Theatro Municipal";
            tableLayoutPanel1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label11.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label3.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = false;
            label11.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = false;
            label11.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label3.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = false;
            label11.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label11.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label11.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label15.Text = "Марафон 45 км ";
            tableLayoutPanel1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label15.Text = "Марафон 5 км ";
            tableLayoutPanel1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
        }
    }
}
