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
    public partial class СпискиДел : Form
    {

        public СпискиДел()
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



        private void СпискиДел_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            Дело d = new Дело();
            d.Deal(dataGridView1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            try
            {
                if (textBox1.Text == "")
                {
                    throw new Exception();
                }
                Дело d = new Дело();
                bool result = d.Deal1(dataGridView1,numericUpDown4.Value, textBox1.Text);
                if (result)
                {                    
                    MessageBox.Show("Дело закрыто!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    label7.Text = "Выберите дело";
                    label7.ForeColor = Color.Red;
                    numericUpDown4.Value = 0;
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox1.Enabled = false;
                }              
            }
            catch (Exception)
            {
                MessageBox.Show(" Выберите дело и заполните поле гонорар!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (numericUpDown1.Value != 0 && numericUpDown2.Value != 0 && numericUpDown3.Value != 0)
            {
               
                    
                    Дело d = new Дело();
                 bool result =   d.DealCreate(dataGridView1,numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value);

                    if(result == true)
                    {
                        MessageBox.Show("Судебное дело создано!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                
                else
                {
                    MessageBox.Show("Адвокат или клиент не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }






            }
            else { MessageBox.Show("Поля Код клиента, Код адвоката, Статья, обязательны для заполнения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Создать дело")
            {
                groupBox2.Visible = true;
                groupBox1.Visible = false;

            }
            else if (comboBox1.SelectedItem.ToString() == "Закрыть дело")
            {
                groupBox2.Visible = false;
                groupBox1.Visible = true;


            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }



        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            

            textBox1.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
                      
            Дело d = new Дело();

            bool result = d.Deal1_1(numericUpDown4.Value, textBox1,textBox2 );

            if (result == false)
            {
                label7.ForeColor = Color.Red;
                label7.Text = "Выберите дело";
                MessageBox.Show("Дело не найдено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label7.ForeColor = Color.Red;

                textBox1.Enabled = false;
            }
           else if (textBox2.Text == "Открыто" || textBox2.Text == "")
            {
                label7.ForeColor = Color.Green;
                label7.Text = "Дело выбрано";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text=="Закрыто")
            {
               
                button4.Enabled = false;
                textBox1.Enabled = false;
               
                label7.Text = "Дело уже закрыто.";
                label7.ForeColor = Color.Red;
            }
            else if(textBox2.Text == "Открыто" || textBox2.Text =="")
            {
                button4.Enabled = true;
                textBox1.Enabled = true;
                
               
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
    | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void СпискиДел_FormClosing(object sender, FormClosingEventArgs e)
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

