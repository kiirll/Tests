using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ATest
{
    public partial class CheckTest : Form
    {
        public CheckTest()
        {
            InitializeComponent();
        }
        ClassTest mytest = new ClassTest();
        public void openTest_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "xml files (*.xml) | *.xml | All files(*.*) | *.* " ;
            
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string text = File.ReadAllText(filename);
                //BinaryFormatter binFormat = new BinaryFormatter();
               XmlSerializer formatter = new XmlSerializer(typeof(ClassTest));
                try
                {
                    using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                    {

                       mytest = (ClassTest)formatter.Deserialize(fs);
                        numq = 0;
                        nameTest.Text = mytest.name;
                       
                        showQ();
                        button1.Enabled = true;

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Нужно выбрать dat файл созданный этой программой");
                }
            }
           
        }
        int colcorrans = 0;
        int numq = 0;
        int trueansw = 0;
        public void showQ()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            ClassQuestion quest =  mytest.Questions[numq];
            textQuestion.Text = quest.name;
            List<ClassVar> n = quest.Varieblles;

            int xx = 0;
            int yy = 0;
            int col=0;
          
            for (int i=0; i < n.Count; i++)
            {
                
                RadioButton rb = new RadioButton();
                rb.Name = col.ToString();
                col++;
                rb.Width = 60;
                rb.Location = new Point(0, yy);



                TextBox tb = new TextBox();
                tb.Text = n[i].name;
                if (n[i].correctly == true) trueansw = i;
                tb.Location = new Point(0, xx);
                tb.Width = 400;

                panel1.Controls.Add(rb);
                panel2.Controls.Add(tb);

                yy += 20;
                xx += 20;
                
            }
            numq++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numq == mytest.Questions.Count)
            {
                pravotv();
                MessageBox.Show("Тест завершен. Кол-во правильных ответов:"+colcorrans +" из " + mytest.Questions.Count);
                this.Close();
            }
            else
            {
                pravotv();
                int con = 0;
                foreach (RadioButton i in panel1.Controls)
                {
                    if (i.Checked == true)
                    {
                        con++;

                        break;
                    }
                    
                }
                if (con==0)
                {
                    MessageBox.Show("Выберите правильный ответ");
                    return;
                }
                showQ();
                
            }
        }

        public void pravotv()
        {
            int con = 0;

            foreach (RadioButton i in panel1.Controls)
            {
                if (i.Checked == true)
                {
                    //con++;

                    break;
                }
                con++;
            }


            if (con == trueansw)
            {
                colcorrans++;
            }
        }
    }
}
