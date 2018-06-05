using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Linq;

namespace AK_1._0
{
    public partial class Вход : Form
    {
      
        public Вход()
        {
            InitializeComponent();
        }
        //последняя версия
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            Учетные_записи d = new Учетные_записи();
            bool result = d.Vhod(textBox1, textBox2);
            if (result)
            {

                if (result && CurrentUser.Value != 0)
                {
                    ИнтерфейсАдвокатов myForm = new ИнтерфейсАдвокатов();
                    myForm.Show();
                    this.Hide();
                }
                else if (result && CurrentUser.Value == 0)
                {
                    Главное_меню myForm2 = new Главное_меню();
                    myForm2.Show();
                    this.Hide();
                }


            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        public void Закрыть()
        {
            throw new System.NotImplementedException();
        }

        public void Войти()
        {
            throw new System.NotImplementedException();
        }
    }
}
