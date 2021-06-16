using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Press 'OK' button";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 'OK' has been clicked");
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int width = button1.Size.Width;
            int height = button1.Size.Height;
            Random x = new Random();
            Random y = new Random();
            int xPoint = Convert.ToInt32(x.Next(100, 250));
            int yPoint = Convert.ToInt32(y.Next(150, 300));
            button1.Location = new Point(xPoint, yPoint);
            button1.Size = new Size(width - 3, height - 3);
            if (width < 3 || height < 3)
            {
                MessageBox.Show("Button 'OK' has been clicked");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
