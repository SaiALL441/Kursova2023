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
    public partial class StudyPlace : Form
    {
        public StudyPlace()
        {
            InitializeComponent();
        }

        private void studyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            studyBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataStudy.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void StudyPlace_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/dataStudy.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataStudy.dat");

        }


        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage Obj = new MainPage();
            Obj.Show();
            this.Hide();
        }

        private void txtStudySearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                studyBindingSource.Filter = $"ПІБ like '*{txtStudySearch.Text}*' or Телефон ='{txtStudySearch.Text}' or Посада like '*{txtStudySearch.Text}*' or Назва уч_закладу like '*{txtStudySearch.Text}*'";
        }
    }
}
