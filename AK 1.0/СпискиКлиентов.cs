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
    public partial class СпискиКлиентов : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public СпискиКлиентов()
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

        private void СпискиКлиентов_FormClosing(object sender, FormClosingEventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (comboBox1.SelectedItem.ToString() == "Создать анкету")
                {
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                }
                else if (comboBox1.SelectedItem.ToString() == "Изменить анкету")
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    groupBox3.Visible = false;

                }
                else if (comboBox1.SelectedItem.ToString() == "Удалить анкету")
                {
                    groupBox3.Visible = true;
                    groupBox2.Visible = false;
                    groupBox1.Visible = false;
                };
            }
        }

        private void СпискиКлиентов_Load(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            label18.Text = "Выберите клиента";
            label18.ForeColor = Color.Red;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            Клиенты d = new Клиенты();
            d.CliLoad(dataGridView1);
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox10.Clear();
            textBox11.Clear();
           textBox12.Clear();
            label16.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Клиенты d = new Клиенты();
           
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "")
                    {
                bool result = d.Cli(dataGridView1, textBox1, textBox2, textBox3, textBox10, textBox11, textBox12);
                if(result)
                {
                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
                    else {

                    MessageBox.Show("Номер телефона уже занят!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox8.Clear();
                }
                
                    }
            else
            {
                MessageBox.Show("Поля Имя, Фамилия, Телефон, Серия и Номер паспорта обязательны для заполнения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
                    
                }
                
            
           
    
        private void button7_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
           textBox8.Clear();
            textBox9.Clear();
            numericUpDown1.Value = 0;
            label18.Text = "Выберите клиента";
            label18.ForeColor = Color.Red;

            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            label17.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                
                if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox9.Text != "" && textBox8.Text != "")
                {
                    Клиенты d = new Клиенты();
                    bool result = d.CliRed(dataGridView1, numericUpDown1.Value, textBox4, textBox5, textBox6, textBox8, textBox9, textBox7);
                        if(result)
                        { 

                        label18.Text = "Выберите клиента";
                        label18.ForeColor = Color.Red;
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox9.Clear();
                        numericUpDown1.Value = 0;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox8.Enabled = false;
                        textBox9.Enabled = false;
                        label17.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("Неверный формат одного или нескольких полей, введите корректные значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

               
                    MessageBox.Show("Запись успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else { MessageBox.Show("Поля Имя, Фамилия, Телефон, Серия и Номер паспорта обязательны для заполнения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Клиенты d = new Клиенты();
         
                bool result = d.CliRedVB(dataGridView1,numericUpDown1.Value, textBox4, textBox5, textBox6,  textBox8, textBox9, textBox7);
                if(result)
                { 

                label18.Text = "Клиент выбран";
                label18.ForeColor = Color.Green;

                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
            }
            else
            {
                MessageBox.Show("Клиент не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                numericUpDown1.Value = 0;
                label18.Text = "Выберите клиента";
                label18.ForeColor = Color.Red;

                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                label17.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Клиенты d = new Клиенты();

            bool result = d.CliDel(dataGridView1, numericUpDown2.Value);
            if(result)
                {               
                MessageBox.Show("Запись удалена.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Клиент не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.TextLength < 5)
            {
                label16.Text = "Не менее 5 цифр.";
                button4.Enabled = false;
            }


            else
            {
                button4.Enabled = true;
                label16.Text = "";
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
        | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
        | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
        | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
        | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
        | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
        | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.TextLength < 5)
            {
                label17.Text = "Не менее 5 цифр.";
                button6.Enabled = false;
            }


            else
            {
                button6.Enabled = true;
                label17.Text = "";
            }
        }

       
    }
    }
    
    

