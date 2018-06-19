using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particals
{
    public partial class Form1 : Form
    {
        Particles a;
        Canva Screen;
        public Form1()
        {
            InitializeComponent();
            DefineCanvas();
            a = new Particles();
        }

        void DefineCanvas()
        {
            Screen = new Canva();
            this.Width = Screen.Width;
            this.Height = Screen.Hieght;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {//here drawing
            Screen.Show(e.Graphics);
            a.Show(e.Graphics); //OK
        }
        private void timer1_Tick(object sender, EventArgs e)
        {//iteration
            this.Refresh();
        }
    }
}
