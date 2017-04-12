using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ATest
{
    public partial class CreateTest : Form
    {
        public CreateTest()
        {
            InitializeComponent();
        }

        private void CreateTest_Load(object sender, EventArgs e)
        {
            
        }

        public ClassTest mytest = new ClassTest();   
        public int xx = 0;
        public int yy = 0;

        public int stcol = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int col = Convert.ToInt32(numericUpDown1.Value);

            if (col > stcol)
            {
                RadioButton rb = new RadioButton();
                
                rb.Name = "var" + col;
                rb.Width = 60;
                rb.Location = new Point(0, yy);



                TextBox tb = new TextBox();
                tb.Location = new Point(0, xx);
                tb.Width = 400;

                panel1.Controls.Add(rb);
                panel2.Controls.Add(tb);
                

                yy += 20;
                xx += 20;
                stcol++;
            }
            else if (col < stcol)
            {
                panel1.Controls.RemoveAt(stcol - 1);
                panel2.Controls.RemoveAt(stcol - 1);
                xx -= 20;
                yy -= 20;
                stcol--;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<bool> ArRB = new List<bool>();
            List<string> ArTB = new List<string>();

            foreach (RadioButton c in panel1.Controls)
            {
                //if (c.GetType() == typeof(RadioButton)) MessageBox.Show(c.Text + " " + c.Checked
                ArRB.Add(c.Checked);
            }

            foreach (TextBox c in panel2.Controls)
            {
                //if (c.GetType() == typeof(RadioButton)) MessageBox.Show(c.Text + " " + c.Checked
                ArTB.Add(c.Text);

            }
            int stAns = 0;
            for (int i = 0; i < ArRB.Count; i++)
            {
                if (ArTB[i] ==  "")
                {
                    stAns++;
                }
            }
            if (stAns != 0)
            {
                MessageBox.Show("Заполните все варианты ответов");
                return;
            }

            if (ArRB.Count < 2)
            {
                MessageBox.Show("Введите 2 или более вариантов ответов");
                return;
            }
            int trueone = 0;
            for (int i = 0; i < ArRB.Count; i++)
            {
                if (ArRB[i] == true)
                {
                    trueone++;
                }
            }
            if (textQuestion.Text == "")
            {
                MessageBox.Show("Введите вопрос");
                return;
            }
           
            if (trueone == 0)
            { 
                MessageBox.Show("Выберете правильный ответ");
                return;
            }
                newquestion();
                panel1.Controls.Clear();
                panel2.Controls.Clear();
                int n= Convert.ToInt32(numberQ.Text);
                n++;
                numberQ.Text = n.ToString();
        }

        private void numberQ_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numberQ.Text) == 1)
            {
                MessageBox.Show("Вопросов нужно больше одного");
                return;
            }
            mytest.name = nameTest.Text;
            if (mytest.name != "")
            {

            }
            else
            {
                MessageBox.Show("Введите название теста");
                return;
            }
            newquestion();
            XmlSerializer formatter = new XmlSerializer(typeof(ClassTest));
            //BinaryFormatter binFormat = new BinaryFormatter();
            using (FileStream fs = new FileStream(mytest.name+".dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, mytest);

                MessageBox.Show("Тест сохранен как: "+ mytest.name + ".dat");
                
            }
                this.Close();
        }

        public void newquestion()
        {

            List<bool> ArRB = new List<bool>();
            List<String> ArTB = new List<string>();

            foreach (RadioButton c in panel1.Controls)
            {
                //if (c.GetType() == typeof(RadioButton)) MessageBox.Show(c.Text + " " + c.Checked
                ArRB.Add(c.Checked);
            }
           
            foreach (TextBox c in panel2.Controls)
            {
                //if (c.GetType() == typeof(TextBox)) MessageBox.Show(c.Text);
                ArTB.Add(c.Text);
            }
            ClassQuestion question = new ClassQuestion();
            question.name = textQuestion.Text;
            int itter = 0;
            foreach (string s in ArTB)
            {
                ClassVar varr = new ClassVar();
                varr.name = s;
                varr.correctly = ArRB[itter];
                itter++;
                question.Varieblles.Add(varr);
            }
            mytest.Questions.Add(question);
            numericUpDown1.Value = 0;
            xx = 0;
            yy = 0;
            stcol = 0;
    }
    }
}
