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
        public partial class Form3 : Form
        {
            Entities db = new Entities();
            public Form3()
            {
                InitializeComponent();
                label1.Text = db.lvl1.Select(s => s.question).First();
                checkBox1.Text = db.lvl1.Select(s => s.answer).First();
                checkBox2.Text = db.lvl1.Select(s => s.answer1).First();
                checkBox3.Text = db.lvl1.Select(s => s.answer2).First();
                checkBox4.Text = db.lvl1.Select(s => s.answer3).First();

            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (checkBox1.Checked == true)
                {
                    // label1.Text = db.lvl1.Where(w => w.id == '2').Select(s => s.question).FirstOrDefault();
                }
            }
            List<lvl1> listlvl1()
            {
                int id;
                List<lvl1> lvl1s = new List<lvl1>();


                var res = from o in db.lvl1
                          where o.id == id
                          select new
                          {

                          }
    
          return lvl1s();

            }

            private void checkBox4_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void checkBox3_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void checkBox2_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }
        }
    }
