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
    public partial class Главное_меню : Form
    {
        public Главное_меню()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Вход myForm;
            myForm = new Вход();
            myForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                СпискиАдвокатов myForm;
                myForm = new СпискиАдвокатов();
                myForm.Show();
                this.Hide();
            }
            if (radioButton2.Checked)
            {
                СпискиКлиентов myForm;
                myForm = new СпискиКлиентов();
                myForm.Show();
                this.Hide();
            }
            if (radioButton3.Checked)
            {
                СпискиДел myForm;
                myForm = new СпискиДел();
                myForm.Show();
                this.Hide();
            }
            if (radioButton4.Checked)
            {
                СпискиЛогиновПаролей myForm;
                myForm = new СпискиЛогиновПаролей();
                myForm.Show();
                this.Hide();
            }
        }

        private void Главное_меню_FormClosing(object sender, FormClosingEventArgs e)
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

        
    }
}
