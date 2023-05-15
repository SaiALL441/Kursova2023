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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppKursova.Forms
{
    public partial class SSD : Form
    {
        public SSD()
        {
            InitializeComponent();
        }

        private void sSDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            sSDBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataSSD.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SSD_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/dataSSD.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataSSD.dat");

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

        private void txtSSDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                sSDBindingSource.Filter = $"ПІБ like '*{txtSSDSearch.Text}*' or Телефон ='{txtSSDSearch.Text}' or Посада like '*{txtSSDSearch.Text}*'";
        }
    }
}
