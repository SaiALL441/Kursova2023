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
    public partial class CenterSoc : Form
    {
        public CenterSoc()
        {
            InitializeComponent();
        }

        private void centerSocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            centerSocBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataCenterSoc.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CenterSoc_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/dataCenterSoc.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataCenterSoc.dat");

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

        private void txtCenterSocSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                centerSocBindingSource.Filter = $"ПІБ like '*{txtCenterSocSearch.Text}*' or Телефон ='{txtCenterSocSearch.Text}' or Посада like '*{txtCenterSocSearch.Text}*'";
        }
    }
}
