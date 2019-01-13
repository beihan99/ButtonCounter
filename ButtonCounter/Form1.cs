using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCounter
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btclick_Click(object sender, EventArgs e)
        {
            count += 1;
            lbcounter.Text = "Counter: " + Convert.ToString(count);
             if (count == 5)
             {
                this.BackColor = Color.FromArgb(100,209,65);
             }
             if (count == 10)
             {
                this.BackColor = Color.FromArgb(222, 58, 105);
             }
             if (count == 15)
             {
                this.BackColor = Color.FromArgb(95, 120, 159);
             }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            count = 0;
            lbcounter.Text = "Counter: " + Convert.ToString(count);
            this.BackColor = DefaultBackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
