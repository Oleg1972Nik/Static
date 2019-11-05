using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Static1
{
    public partial class Form1 : Form
    {
        public bool m = false;
        public int count = 0;
        public Color BackColor { get; set; }
        int x, y;
        public Form1()
        {
            InitializeComponent();
            
           
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }

            
        }

           
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
                 if (e.Button == MouseButtons.Right)
                 this.Text = $" Площадь прямоугольника -  {(e.X - x)* (e.Y - y)}, координаты - x1 = {x}, x2 = {e.X}, y1 = {y}, y2 = {e.Y} ";
        }

       
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if(e.Button == MouseButtons.Left)
            foreach(Label L in Controls)
            {
                    if(L.Text < )
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            Random r = new Random();
            Label label = new Label();
            if ((e.X - x <= 10) && (e.Y - y <= 10))
            MessageBox.Show("Размер меньше 10");
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Location = new Point(x, y);
            label.Size = new Size((e.X - x), (e.Y - y));
            label.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            Controls.Add(label);
            label.Text = Convert.ToString(++count);
            label.TextAlign = ContentAlignment.MiddleCenter;
                               
        }
    }
}
