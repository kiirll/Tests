using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATest
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createTest_Click(object sender, EventArgs e)
        {
            CreateTest CrT = new CreateTest();
            CrT.ShowDialog();
        }

        private void useTest_Click(object sender, EventArgs e)
        {
            CheckTest ChT = new CheckTest();
            ChT.ShowDialog();
        }
    }

}
