using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace AK_1._0
{
    public partial class СпискиАдвокатов : Form
    {
        
        public СпискиАдвокатов()
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

        private void СпискиАдвокатов_Load(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            label14.Text = "Выберите адвоката";
            button8.Enabled = false;
            DataClasses1DataContext db = new DataClasses1DataContext();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            Адвокаты d = new Адвокаты();
            d.Deal22(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }



        private void button5_Click(object sender, EventArgs e)
        {
         
            Адвокаты d = new Адвокаты();
            
                bool result = d.AdvDel(dataGridView1, numericUpDown1.Value);
            if (result)
            {
                MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else           
            {
                MessageBox.Show("Адвокат не найден.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

                   
        }

        private void button4_Click(object sender, EventArgs e)
        {
                    
            Адвокаты d = new Адвокаты();
          
                    if (textBox1.Text != "" && textBox2.Text != ""  && textBox8.Text != "")
                    {
                        {                         
                              bool result =  d.Adv(dataGridView1, textBox1, textBox2, textBox3, textBox8);
                        if (result)
                        {
                            MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                    {
                        MessageBox.Show("Номер телефона уже занят!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox8.Clear();
                    }
                        }
                    }
                    else
            {
                MessageBox.Show("Поля - Имя, Фамилия, Телефон обязательны для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                  
        }
        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox8.Clear();
            label12.Text = "";
            button4.Enabled = true;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;      
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            if (textBox5.Text != "" && textBox6.Text != "" && textBox4.Text != "" )
                    {
                        
                    Адвокаты d = new Адвокаты();
                    bool result = d.AdvRed(dataGridView1, numericUpDown2.Value, textBox5, textBox6, textBox7, textBox4);
                    if(result)
                    { 
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    numericUpDown2.Value = 0;

                    label14.Text = "Выберите адвоката";
                    label14.ForeColor = Color.Red;
                    label15.Text = "";

                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox7.Enabled = false;
                }
                        else
                        {
                            MessageBox.Show("Неверный формат одного или нескольких полей, введите корректные значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                        MessageBox.Show("Запись успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else { MessageBox.Show("Поля Имя, Фамилия, Телефон обязательны для заполнения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
    private void button10_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox4.Clear();
            numericUpDown2.Value = 0;

            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;

            label14.Text = "Выберите адвоката";
            label14.ForeColor = Color.Red;
            label15.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            else if (comboBox1.SelectedItem.ToString()== "Удалить анкету")
            {
                groupBox3.Visible = true;
                groupBox2.Visible = false;
                groupBox1.Visible = false;
            };
            }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
          
            Адвокаты d = new Адвокаты();
           
                bool result = d.AdvRedVB(dataGridView1, numericUpDown2.Value, textBox5, textBox6, textBox7, textBox4);
                if(result)
                { 

                button8.Enabled = true;

                label14.Text = "Адвокат выбран";
                label14.ForeColor = Color.Green;

                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
            }
            else
            {
                MessageBox.Show("Адвокат не найден.","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox4.Clear();

                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;

                label14.Text = "Выберите адвоката";
                label14.ForeColor = Color.Red;


            }
            }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') )
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // не вводим нажатый символ в поле
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.Handled = true;  // не вводим нажатый символ в поле
                MessageBox.Show("Ввод цифр в поля Ф.И.О. запрещен.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);   //выводим сообщение об ошибке
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {

                if (Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {

                if (Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;
            }
        }

        private void СпискиАдвокатов_FormClosing(object sender, FormClosingEventArgs e)
        {
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

      

       

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
    | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.TextLength < 5)
            {
                label12.Text = "Не менее 5 цифр.";
                button4.Enabled = false;
            }


            else  
                {
                    button4.Enabled = true;
                    label12.Text = "";
                }
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength < 5)
            {
                label15.Text = "Не менее 5 цифр.";
                button8.Enabled = false;
            }


            else
            {
                button8.Enabled = true;
                label15.Text = "";
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
    | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
    }
    

