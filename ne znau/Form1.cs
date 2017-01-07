using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ne_znau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //получаем ссылку на кнопку, на которую мы нажали
            Button b = (Button)sender;
            //Создаем новую кнопку
            Button temp = new Button();
            temp.Text = "Пример";
            temp.Width = b.Width;
            //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
            temp.Location = new Point(b.Location.X + b.Width + 10, b.Location.Y);
            //Добавляем событие нажатия на новую кнопку 
            //(то же что и при нажатии на исходную)
            temp.Click += new EventHandler(button1_Click);
            //Добавляем элемент на форму
            this.Controls.Add(temp);
        
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "1")
            {


                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Hide();
                Application.Exit();
            }

            else
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                MessageBox.Show("Неправильный логин или пароль!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true) textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        



            
        }
    }
