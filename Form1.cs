using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Box
{
    public partial class Form1 : Form
    {
        Color color1 = Color.Blue;
        public Form1()
        {
            InitializeComponent();
            label1.MouseDown+=Label1_MouseDown;
            label2.MouseDown+=Label2_MouseDown;
            label3.MouseDown+=Label3_MouseDown;
            label4.MouseDown+=Label4_MouseDown;

        }

        private void Label4_MouseDown(object sender, MouseEventArgs e)
        {
            label4.BackColor = Color.Blue;
        }

        private void Label3_MouseDown(object sender, MouseEventArgs e)
        {
            color1 = label3.BackColor;
            label4.BackColor = color1;
        }

        private void Label2_MouseDown(object sender, MouseEventArgs e)
        {
            color1 = label2.BackColor;
            label4.BackColor = color1;
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            color1 = label1.BackColor;
            label4.BackColor = color1;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(10, 0);
            label1.AutoSize = false;
            label1.Width = 100;
            label1.Height = 50;
            label1.BackColor = Color.Green;
            label1.Text = string.Empty;

            label2.Location = new Point(120, 0);
            label2.AutoSize = false;
            label2.Width = 100;
            label2.Height = 50;
            label2.BackColor = Color.Yellow;
            label2.Text = string.Empty;

            label3.Location = new Point(230, 0);
            label3.AutoSize = false;
            label3.Width = 100;
            label3.Height = 50;
            label3.BackColor = Color.Red;
            label3.Text = string.Empty;

            label4.Location = new Point(350, 0);
            label4.AutoSize = false;
            label4.Width = 400;
            label4.Height = 400;
            label4.BackColor = color1;
            label4.Text = string.Empty;
        }
    }
}
