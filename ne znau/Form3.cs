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
    public partial class Form3 : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
       
        
        public Form3()
        {
            InitializeComponent();


            SuspendLayout();
            button1.Text = "Открыть";
            button1.Click += new EventHandler(button1_Click);

            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Изображения|*.jpg";
            //,|Текстовые файлы|*.txt";

            this.Controls.Add(button1);
            ResumeLayout();
        
        
     
           
        }

        private void tabPage2_OsnovnayaChast_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // выход, если была нажата кнопка Отмена и прочие (кроме ОК)
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            // всё. имя файла теперь хранится в openFileDialog1.FileName
            // MessageBox.Show("Выбран файл: "+openFileDialog1);
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            //string g = System.IO.Path.GetFileName(openFileDialog1.FileName);


            //   PictureBox pb = new PictureBox();

            // PictureBox lemp = new PictureBox();

            // lemp.Width = pb.Width;
            //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
            // lemp.Location = new Point(pb.Location.X + pb.Width + 600, pb.Location.Y + pb.Width + 800);
            //Добавляем событие нажатия на новую кнопку 
            //(то же что и при нажатии на исходную)
            //lemp.Click += new EventHandler(button1_Click);
            //Добавляем элемент на форму
            //this.Controls.Add(lemp);

            //MessageBox.Show("Выбран файл: " + openFileDialog1.FileName);


            //получаем ссылку на кнопку, на которую мы нажали


        }
    }
}
