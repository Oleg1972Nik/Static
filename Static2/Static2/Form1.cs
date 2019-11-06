using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static2
{
    public partial class Form1 : Form
    {
        public Color BackColor { get; set; }
        Label label;
        public Form1()
        {
            InitializeComponent();
            int X;
            int Y;
            
            label = new Label();
            Controls.Add(label);
            label.BackColor = Color.Coral;
            label.Text = "Static";
            label.Visible = true;
            label.Size = new Size(100, 100);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Left = ClientSize.Width / 2;
            label.Top = ClientSize.Height / 2;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X > label.Location.X - 20 && e.X < label.Location.X + label.Width + 20) && (e.Y > label.Location.Y -20 && e.Y < label.Location.Y + label.Height - 20))
            {
                if (e.X > label.Location.X - 20 && e.X < label.Location.X)
                    label.Left += 10;
                else if (e.X < label.Location.X + label.Width + 20)
                    label.Left -= 10;
                if (e.Y < label.Location.Y - 20 && e.Y < label.Location.Y)
                    label.Top += 10;
                else if (e.Y < label.Location.Y + label.Height && e.Y < label.Location.Y + label.Height + 20)
                    label.Top -= 10;

            }

        }


    }
}
