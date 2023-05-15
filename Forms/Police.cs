using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppKursova.Forms
{
    public partial class Police : Form
    {
        public Police()
        {
            InitializeComponent();
        }

        private void policeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            policeBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataPolice.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Police_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/dataPolice.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataPolice.dat");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage Obj = new MainPage();
            Obj.Show();
            this.Hide();
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                policeBindingSource.Filter = $"ПІБ like '*{textBox1.Text}*' or Телефон ='{textBox1.Text}' or Посада like '*{textBox1.Text}*'";
        }
    }
}
