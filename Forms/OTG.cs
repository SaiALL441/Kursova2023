using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppKursova.Forms
{
    public partial class OTG : Form
    {
        public OTG()
        {
            InitializeComponent();
           otgList1.SelectedIndexChanged += otgList_SelectedIndexChanged;
        }
        private void otgList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = otgList1.SelectedItem.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage Obj = new MainPage();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (otgList1.SelectedIndex == 0)
            {
                listBox2.Items.Add("село Абрикосове");
                listBox2.Items.Add("село Авидівка");
                listBox2.Items.Add("село Адамівка");
                listBox2.Items.Add("село Біленьке");
                listBox2.Items.Add("село Благодатне");
                listBox2.Items.Add("село Бритівка");
                listBox2.Items.Add("село Вигон");
                listBox2.Items.Add("село Польове");
                listBox2.Items.Add("село Прибережне");
                listBox2.Items.Add("село Привітне");
                listBox2.Items.Add("село Салгани");
                listBox2.Items.Add("село Софіївка");
                listBox2.Items.Add("село Черкеси");
                listBox2.Items.Add("село Шабо");
            }
            else if (otgList1.SelectedIndex == 1)
            {
                listBox2.Items.Add("село Великомар'янівка");
                listBox2.Items.Add("село Долинівка");
                listBox2.Items.Add("село Зелене");
                listBox2.Items.Add("село Маразліївка");
                listBox2.Items.Add("село Монаші");
                listBox2.Items.Add("село Олексіївка");
                listBox2.Items.Add("село Полянка");
                listBox2.Items.Add("село Романівка");
                listBox2.Items.Add("село Широке");

            }
            else if (otgList1.SelectedIndex == 2)
            {
                listBox2.Items.Add("село Андріївка");
                listBox2.Items.Add("село Бикоза");
                listBox2.Items.Add("село Випасне");
                listBox2.Items.Add("село Молога");
                listBox2.Items.Add("село Нове");
                listBox2.Items.Add("село Розкішне");
                listBox2.Items.Add("село Садове");
                listBox2.Items.Add("село Сухолужжя");
            }
            else if (otgList1.SelectedIndex == 3)
            {
                listBox2.Items.Add("село Веселе");
                listBox2.Items.Add("село Володимирівка");
                listBox2.Items.Add("село Гончарівка");
                listBox2.Items.Add("село Дальнічень");
                listBox2.Items.Add("село Зеленівка");
                listBox2.Items.Add("село Карналіївка");
                listBox2.Items.Add("село Козацьке");
                listBox2.Items.Add("село Красна Коса");
                listBox2.Items.Add("село Крутоярівка");
                listBox2.Items.Add("село Нова Царичанка");
                listBox2.Items.Add("село Петрівка");
                listBox2.Items.Add("село Південне");
                listBox2.Items.Add("село Підгірне");
                listBox2.Items.Add("село Руськоіванівка");
                listBox2.Items.Add("село Семенівка");
                listBox2.Items.Add("село Стара Царичанка");
                listBox2.Items.Add("село Старокозаче");
                listBox2.Items.Add("село Чистоводне");
            }
            else if (otgList1.SelectedIndex == 4)
            {
                listBox2.Items.Add("селище міського типу Затока");
                listBox2.Items.Add("село Кароліно-Бугаз");

            }
            else if (otgList1.SelectedIndex == 5)
            {
                listBox2.Items.Add("село Вільне");
                listBox2.Items.Add("село Косівка");
                listBox2.Items.Add("село Курортне");
                listBox2.Items.Add("село Миколаївка");
                listBox2.Items.Add("село Попаздра");
                listBox2.Items.Add("село Приморське");
                listBox2.Items.Add("селище міського типу Сергіївка");
            }
            else
            {
                MessageBox.Show("Ви не обрали ОТГ");
            }
        }

        private void oTGTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            oTGTableBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/data.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void OTG_Load(object sender, EventArgs e)
        {
            
            if (File.Exists($"{Application.StartupPath}/dataOtg.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataOtg.dat");

        }

      

       

        private void oTGTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.oTGTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample1DataSet);
            oTGTableBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataOtg.dat");
            MessageBox.Show("Your data has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       

        private void телефонTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void txtboxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                
                oTGTableBindingSource.Filter = $"ПІБ like '*{txtboxSearch.Text}*' or Телефон ='{txtboxSearch.Text}'";
        }

        
    }
}
