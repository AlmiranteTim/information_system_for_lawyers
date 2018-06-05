using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_1._0
{
    public partial class ИнтерфейсАдвокатов : Form
    {
        public ИнтерфейсАдвокатов()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Дело d = new Дело();
            d.Search(dataGridView1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Вход myForm;
            myForm = new Вход();
            myForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Дело d = new Дело();
            d.Search1(dataGridView1);
        }

        private void ИнтерфейсАдвокатов_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                                                 "Вы действительно хотите выйти из системы?",
                                                 "Выход из системы",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning
                                                );
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
                Вход aForm = new Вход();
                aForm.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            if (comboBox1.Text == "Закрытые дела")
            {

                Дело d = new Дело();
                d.Search2(dataGridView1);

            }
            else if (comboBox1.Text == "Открытые дела")
            {
                Дело d = new Дело();
                d.Search3(dataGridView1);
            }
            }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        public void Method1()
        {
            throw new System.NotImplementedException();
        }

        public void ПоискКлиентов()
        {
            throw new System.NotImplementedException();
        }

        public void ПоискДел()
        {
            throw new System.NotImplementedException();
        }

        public void ПоискДелПоСтатусу()
        {
            throw new System.NotImplementedException();
        }

        public void СменитьПользователя()
        {
            throw new System.NotImplementedException();
        }

        public void ЗакрытьФорму()
        {
            throw new System.NotImplementedException();
        }
    }
    }

