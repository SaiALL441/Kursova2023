using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppKursova.Forms
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new OTG().Show();
            this.Hide();
        }

        private void btn75_Click(object sender, EventArgs e)
        {
            new Form75().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SocServ().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Court().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CenterSoc().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Ban().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Works().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Fine().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Police().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new StudyPlace().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new SSD().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
