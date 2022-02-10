using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        class Question
        {
           public string Text; //Текст вопроса
           public List<string> Answer;//Лист для вариантов ответов
           public int RightAnswer;//Правильный ответ           
           public int CurAnswer;//Ответ, который выбрал пользователь 

            //Проверка правильности ответов
            public int Check()
            {
                if (CurAnswer == RightAnswer)
                    return 1;
                else return 0;
            }

            //Метод для отображения вопросов и вариантов ответов на форме
             public void Show(TextBox x, RadioButton a, RadioButton b, RadioButton c)
            {
                x.Text = Text;
                a.Text = Answer[0]; 
                b.Text = Answer[1]; 
                c.Text = Answer[2]; 

                switch (CurAnswer)
                {
                    case 0: a.Checked = true; break;
                    case 1: b.Checked = true; break;
                    case 2: c.Checked = true; break;
                }
            }

            //Метод для перемешивания вариантов ответов в вопросе
            public void Shuffle()
            {
                Random rnd = new Random();
                for (int i = 0; i < 5; i++)
                {
                    int x = rnd.Next(3);
                    int y = rnd.Next(3);
                    string t = Answer[x]; Answer[x] = Answer[y]; Answer[y] = t;
                    //Cмещаем правильный ответ
                    if (x == RightAnswer)
                        RightAnswer = y;
                    else if (y == RightAnswer)
                        RightAnswer = x;
                }
            }

            //Конструктор вопроса
            public Question()
            {
                Answer = new List<string>(); //Создание листа ответов
                CurAnswer = -1;//По умолчанию текущий ответ равен -1
            }

        }

        List<Question> QS;//Лист из вопросов
        int CurQ;//Храним номер текущего вопроса
        string User; //Переменная для хранения имени пользователя
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {  
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QS = new List<Question>();//Cоздаем новый список вопросов


            /*Организуем доступ к файлу с вопросами.
             Структура файла: 1-ая строка - количество вопросов;
                              2-ая строка - вопрос;
                              3, 4, 5 строки - варианты ответов;
                              6-ая строка - номер правильного варианта ответов
             */
            System.IO.StreamReader sr = new System.IO.StreamReader("input.txt", Encoding.Default);//Создаем поток чтения и напривляем его на файл input.txt
            //Читаем из открытого файла input.txt 1-ую строку как число
            
            int n = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < n; i++)//n раз 
            {
                Question Q1 = new Question();
                Q1.Text = sr.ReadLine();//Формируем текст вопроса

                //Добавляем в лист варианты ответов
                Q1.Answer.Add(sr.ReadLine());
                Q1.Answer.Add(sr.ReadLine());
                Q1.Answer.Add(sr.ReadLine());

                //Считываем правильный ответ как число
                Q1.RightAnswer = Convert.ToInt32(sr.ReadLine());

                //Устанавливаем текущий ответ на -1
                Q1.CurAnswer = -1;

                //Перемешиваем варианты ответов
               Q1.Shuffle();
                
                //Тот вопрос, который считали, добавляем в список вопросов QS
                QS.Add(Q1);
            }
            sr.Close();//Закрываем файл с вопросами после прочтения

            //Если в списке только один вопрос, то кнопка "Следующий вопрос" не активна
            if (QS.Count() == 1)
                nextBtn.Enabled = false;

            //Перемешиваем вопросы
            Random rnd = new Random();//Заводим объект Random
           for (int i = 0; i < QS.Count*5; i++)
            {//Выбираем два случайных числа в диапазоне QS.Count
                int x = rnd.Next(QS.Count);
                int y = rnd.Next(QS.Count);

            //Перемешиваем вопросы
                Question t = QS[x]; QS[x] = QS[y]; QS[y] = t;
            }
           
            
            previousBtn.Enabled = false;//При загрузке формы кнопка "Предыдущий вопрос" не активна

            CurQ = 0;//Указываем номер текущего вопроса. При загрузке он равен 0

            //Отображение вопроса с вариантами ответов
            QS[CurQ].Show(QTBox, Answ1rB, Answ2rB, Answ3rB);

            //Делаем невидимыми элементы формы, кроме компонентов регистрации
            QTBox.Visible = false;
            Answ1rB.Visible = false;
            Answ2rB.Visible = false;
            Answ3rB.Visible = false;
            previousBtn.Visible = false;
            nextBtn.Visible = false;
            stopBtn.Visible = false;
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {    
            
             CurQ--;//Уменьшаем номер текущего вопроса на 1
             QS[CurQ].Show(QTBox, Answ1rB, Answ2rB, Answ3rB);//Показываем новый вопрос
             
            if (CurQ == 0) //Если номер текущего вопроса равен 0
               previousBtn.Enabled = false;//Кнопку "Предыдущий вопрос" делаем не активной
            
            nextBtn.Enabled = true;//Кнопку "Следующий вопрос" делаем активной

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            for (int i = 0; i < QS.Count; i++)
                result += QS[i].Check();
            //Записываем результаты в лог-файл
            System.IO.StreamWriter sw = new System.IO.StreamWriter("output.txt", true, Encoding.Default);
            sw.WriteLine(User);
            sw.WriteLine("You answer right " + result + " for " + QS.Count + " questions.");
            sw.WriteLine();
            sw.Close();
            MessageBox.Show("You answer right " + result + " for " + QS.Count + " questions.");

            Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            CurQ++;//Увеличиваем номер текущего вопроса на 1
            QS[CurQ].Show(QTBox, Answ1rB, Answ2rB, Answ3rB);//Показываем текущий вопрос
            
            if (CurQ == QS.Count - 1)//Если вопрос последний в списке
                nextBtn.Enabled = false;//Кнопку "Следующий вопрос" делаем не активной
            
            previousBtn.Enabled = true;//Кнопку "Предыдущий вопрос" делаем активной
        }

        private void Answ1rB_CheckedChanged(object sender, EventArgs e)
        {
            //Если пользователь выбрал первый чекбокс, меняем его св-во CurAnswer
            QS[CurQ].CurAnswer = 0;
            if (QS[CurQ].CurAnswer == QS[CurQ].RightAnswer)
                BackColor = Color.Green;
            else
                BackColor = Color.LightGray;
        }

        private void Answ2rB_CheckedChanged(object sender, EventArgs e)
        {
            QS[CurQ].CurAnswer = 1;
            if (QS[CurQ].CurAnswer == QS[CurQ].RightAnswer)
                BackColor = Color.Green;
            else
                BackColor = Color.LightGray;
        }

        private void Answ3rB_CheckedChanged(object sender, EventArgs e)
        {
            QS[CurQ].CurAnswer = 2;
            if (QS[CurQ].CurAnswer == QS[CurQ].RightAnswer)
                BackColor = Color.Green;
            else
                BackColor = Color.LightGray;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text != "")
            {
                User = NameTb.Text;
                QTBox.Visible = true;
                Answ1rB.Visible = true;
                Answ2rB.Visible = true;
                Answ3rB.Visible = true;
                previousBtn.Visible = true;
                nextBtn.Visible = true;
                stopBtn.Visible = true;

                label1.Visible = false;
                NameTb.Visible = false;
                OkBtn.Visible = false;
            }


        }
    }
}
