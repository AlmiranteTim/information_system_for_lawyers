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
    public partial class СпискиЛогиновПаролей : Form
    {

        public СпискиЛогиновПаролей()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Главное_меню myForm;
            myForm = new Главное_меню();
            myForm.Show();
            this.Hide();
        }

        private void СпискиЛогиновПаролей_Load(object sender, EventArgs e)
        {

            textBox5.Enabled = false;
            DataClasses1DataContext db = new DataClasses1DataContext();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Учетные_записи d = new Учетные_записи();
            d.AkkLoad(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Учетные_записи d = new Учетные_записи();
         bool result = d.Akk(dataGridView1, numericUpDown2.Value, textBox1, textBox2);

        }



        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            label8.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown2.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Учетные_записи d = new Учетные_записи();
            
                if ( textBox5.Text != "")
                {
                    

                    bool result = d.AkkRed(dataGridView1,numericUpDown1.Value,textBox5);
                    if (result)
                    {
                        MessageBox.Show("Запись успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else {
                        textBox5.Enabled = false;
                        label9.Text = "Выберите запись";
                        label9.ForeColor = Color.Red;
                        numericUpDown1.Value = 0;

                        textBox5.Clear();
                    }
                        
                }
                else { MessageBox.Show("Пароль обязателен для заполнения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Создать аккаунт")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;

            }
            else if (comboBox1.SelectedItem.ToString() == "Изменить аккаунт")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            
                Учетные_записи d = new Учетные_записи();

                bool result = d.AkkRedVB(dataGridView1,numericUpDown1.Value,textBox5);
            if (result)
            {

                textBox5.Enabled = true;
                label9.Text = "Запись выбрана";
                label9.ForeColor = Color.Green;

            }
            else
            {
                MessageBox.Show("Запись не найдена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label9.Text = "Выберите запись";
                label9.ForeColor = Color.Red;
                textBox5.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 3)
            {
                label8.Text = "Не менее 3 символов";
                button4.Enabled = false;
            }

            else
            {
                button4.Enabled = true;
                label8.Text = "";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void СпискиЛогиновПаролей_FormClosing(object sender, FormClosingEventArgs e)
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
                Главное_меню aForm = new Главное_меню();
                aForm.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
    

    

