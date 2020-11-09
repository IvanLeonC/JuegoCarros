using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoCarros
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Splash_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 584)
            {
                Splash.Stop();
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }
    }
}
