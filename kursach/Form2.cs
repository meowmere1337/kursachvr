using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Form2 : Form
    {
        
        public Form2(string nickname)
        {
            
            InitializeComponent();
            labelNick.Text =$"Добро пожаловать {nickname}";
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void button1Start_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);            
            frm3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}