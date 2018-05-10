using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bloodDonor
{
    public partial class donorRegistrationForm : Form
    {
        public donorRegistrationForm()
        {
            InitializeComponent();
        }

        private void donorRegistrationForm_Load(object sender, EventArgs e)
        {
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool c = true;
            bool p = true;
            bool g = true;
            DateTime m = new DateTime();
            localhost.Service1 s = new localhost.Service1();
            s.regesterDonor(donorNameTextBox.Text,donorPasswordTextBox.Text ,donorBloodGroupTextBox.Text, donorAddressTextBox.Text, int.Parse(donorContactTextBox.Text), c, int.Parse(donorAgeTextBox.Text), p, m, g);
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            
        }

        private void donorNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
