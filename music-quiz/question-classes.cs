using System;

namespace music_quiz
{
    public class Question
    {
        public string q;
        public string a;
        public string a1;
        public string a2;
        public string a3;
        public string a4;
        public string al;
        public string all;
        public bool ca;
        public int qId;
        public void showQuestion()
        {
            Console.WriteLine(q);
            Console.WriteLine("A: " + a1);
            Console.WriteLine("B: " + a2);
            Console.WriteLine("C: " + a3);
            Console.WriteLine("D: " + a4);
        }
        public void processAnswer(string l)
        {
            if (l == al)
            {

                Console.WriteLine("Correct!");
                ca = true;

            } else if (l == all)
            {
                Console.WriteLine("Correct!");
                ca = true;
            } 
            else 
            {
                Console.WriteLine("Incorrect");
            }
        }

        public Question(string question, string answer, string answer1, string answer2, string answer3, string answer4, string answerLetter, string answerLetterLower, bool correctAnswer, int questionId)
        {
            q = question;
            a = answer;
            a1 = answer1;
            a2 = answer2;
            a3 = answer3;
            a4 = answer4;
            al = answerLetter;
            all = answerLetterLower;
            ca = correctAnswer;
            qId = questionId;
        }
    }
}