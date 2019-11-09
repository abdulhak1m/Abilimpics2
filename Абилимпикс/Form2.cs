using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Абилимпикс
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void абилимпиксBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.абилимпиксBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.абилимпиксDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "абилимпиксDataSet.Абилимпикс". При необходимости она может быть перемещена или удалена.
            this.абилимпиксTableAdapter.Fill(this.абилимпиксDataSet.Абилимпикс);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.абилимпиксBindingSource.EndEdit();
            this.абилимпиксTableAdapter.Update(this.абилимпиксDataSet.Абилимпикс);
            Form1 form1 = new Form1();
            form1.Show();
            MessageBox.Show("Вы успешно зарегистрировались!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
