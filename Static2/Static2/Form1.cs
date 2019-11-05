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
            label.Left = 10;
            label.Top = 10;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            if( Cursor.Position.X < label.Location.X - 10 && label.Location.X > 20)
              label.Location = new Point(label.Location.X + rnd.Next(-10, 10), label.Location.X + rnd.Next(-10, 10);
            }

        }


    }
}
