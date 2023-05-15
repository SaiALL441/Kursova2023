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
    public partial class Fine : Form
    {
        public Fine()
        {
            InitializeComponent();
        }

        private void fineTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            fineTableBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataFine.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Fine_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/dataFine.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataFine.dat");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage Obj = new MainPage();
            Obj.Show();
            this.Hide();
        }

        private void fineTableBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblFineN.Text = string.Format("Кількість справ: {0}", this.fineTableBindingSource.List.Count);
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void сумаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58))
            {
                e.Handled = true;
            }
        }

        private void txtFine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                fineTableBindingSource.Filter = $"ПІБ like '*{txtFine.Text}*' or Телефон ='{txtFine.Text}'";
        }
    }
}
