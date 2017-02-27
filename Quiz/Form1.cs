using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        int index = 0;
        
        List<QuestionAndAnswers> Questions = new List<QuestionAndAnswers>();
        public Form1()
        {
            InitializeComponent();


            
            
            Questions.Add(new QuestionAndAnswers() { Question = "Frage 1", Answers = "Antwort 1", Answers0 = "Antwort 2", Answers1 = "Antwort 3", Answers2 = "Antwort 4" });
            Questions.Add(new QuestionAndAnswers() { Question = "Frage 2", Answers = "Antwort 1", Answers0 = "Antwort 2", Answers1 = "Antwort 3", Answers2 = "Antwort 4" });
            Questions.Add(new QuestionAndAnswers() { Question = "Frage 3", Answers = "Antwort 1", Answers0 = "Antwort 2", Answers1 = "Antwort 3", Answers2 = "Antwort 4" });
            Questions.Add(new QuestionAndAnswers() { Question = "Frage 4", Answers = "Antwort 1", Answers0 = "Antwort 2", Answers1 = "Antwort 3", Answers2 = "Antwort 4" });
            Questions.Add(new QuestionAndAnswers() { Question = "Frage 5", Answers = "Antwort 1", Answers0 = "Antwort 2", Answers1 = "Antwort 3", Answers2 = "Antwort 4" });
       d(); }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (radioButton1.Checked)
            {
                Console.WriteLine("2");
            }
            if (radioButton2.Checked)
            {
                Console.WriteLine("sender3");
            }
            if (radioButton3.Checked)
            {
                Console.WriteLine("sender4");
            }
            if (radioButton4.Checked)
            {
                Console.WriteLine("sender");
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            if (index < 4)
            {
                index++;
                d();
            }

        }


        public class QuestionAndAnswers
        {
            public string Question { get; set; }
            public string Answers { get; set; }
            public string Answers0 { get; set; }
            public string Answers1 { get; set; }
            public string Answers2 { get; set; }
            public int CorrectAnswer { get; set; }

        }


            private void d()
        {

            QuestionAndAnswers question = Questions[index];
                textBox1.Text = question.Question;
                radioButton1.Text = question.Answers;
                radioButton2.Text = question.Answers0;
                radioButton3.Text = question.Answers1;
                radioButton4.Text = question.Answers2;

            }
        }
    }


