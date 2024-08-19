using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Service
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            myProgress.Value = startpoint;
            if (myProgress.Value == 100)
            {
                startpoint = 0;
                Login login = new Login();
                timer1.Stop();
                login.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
           /* Form1 conn=new Form1();*/
        }
    }
}
