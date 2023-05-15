using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppKursova.Forms;

namespace WindowsFormsAppKursova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }

            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "admin" && txtpass.Text == "1234")
            {
                new MainPage().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Неправильно введено логін чи пароль");

            }
        }
    }
}
