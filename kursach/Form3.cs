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
        public lvl1 Question { get; set; }
        public int Number { get; set; }
        public Form2 frm2 { get; set; }
        public Form3(Form2 frm2)
        {
            InitializeComponent();

            Number = 0;
            Question = GetNextQuestion();
            UpdateUI(Question);
            this.frm2 = frm2;
            


        }
        private List<Button> shuffle (List<Button> buttons) // Рандом для кнопок
        {
            var randomList = new List<Button>();
            Random r = new Random();
            int randomIndex = 0;
            while (buttons.Count > 0)
            {
                randomIndex = r.Next(0, buttons.Count);
                randomList.Add(buttons[randomIndex]);
                buttons.RemoveAt(randomIndex);
            }

            return randomList ;
        }
        private lvl1 GetNextQuestion()
        {
            
            try
            {
                var lvl1 = db.lvl1.OrderBy(x => x.id).Skip(Number).First();
                Number++;
                return lvl1;
            }
            catch
            {
                MessageBox.Show("Вы прошли игру))))))))))))))))))))))))))))))");
                frm2.Show();
                this.Close();
            }
            return null;
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            var txt = ((Button)sender).Text;
            if(Question.answer == txt)
            {
                Question = GetNextQuestion();                
                UpdateUI(Question);
                return; 
            }
            MessageBox.Show("Вы проиграли(");
            frm2.Show();
            this.Close();
            
        }
        private void UpdateUI(lvl1 question)
        {
            if(question == null)
            {
                return;
            }
            label1.Text = question.question;
            var buttons = new List<Button>
            {
                this.buttonAnswer,
                this.buttonAnswer1,
                this.buttonAnswer2,
                this.buttonAnswer3
            };
            buttons = this.shuffle(buttons);
            buttons[0].Text = question.answer;
            buttons[1].Text = question.answer1;
            buttons[2].Text = question.answer2;
            buttons[3].Text = question.answer3;

        }
    }

}
