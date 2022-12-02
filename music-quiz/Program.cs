using System;

namespace music_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION OBJECTS
            Question q1 = new Question(
                "What is the name of Radiohead's first album?",
                " ",
                "The Bends",
                "Ok Computer",
                "Pablo Honey",
                "Hail to the Thief",
                "C",
                "c",
                false,
                1
                );

            Question q2 = new Question(
                "What is the name of Bloc Party's first album?",
                " ",
                "Silent Alarm",
                "A Weekend in the City",
                "Intimacy",
                "Mercury",
                "A",
                "a",
                false,
                2
                );

            Question q3 = new Question(
                "Which of these rappers was in the group 'De La Soul'?",
                " ",
                "Rakim",
                "Posdanous",
                "LL Cool J",
                "MF DOOM",
                "B",
                "b",
                false,
                3
                );

            Question q4 = new Question(
                "Which of these groups is NOT a Les Claypool project?",
                " ",
                "Primus",
                "Duo de Twang",
                "The Lennon Claypool Delirium",
                "Gorilaz",
                "D",
                "d",
                false,
                4
                );

            Question q5 = new Question(
                "In what year did Kurt Cobain die?",
                " ",
                "1992",
                "1993",
                "1994",
                "1995",
                "C",
                "c",
                false,
                5
                );

            Question q6 = new Question(
                "What is Elton John's real name?",
                " ",
                "John Elton-Way",
                "Ben Elton",
                "Reginald Dwight",
                "John Len-Elton",
                "C",
                "c",
                false,
                6
                );

            Question q7 = new Question(
                "Where was Slash born?",
                " ",
                "Los Angeles",
                "Stoke-on-Trent",
                "British Columbia",
                "Zimbabwe",
                "B",
                "b",
                false,
                7
                );

            Question q8 = new Question(
                "Which Arctic Monkeys album entered the UK Album Charts at number 1?",
                " ",
                "Humbug",
                "AM",
                "Favourite Worst Nightmare",
                "Whatever people say I am, that's what I'm not",
                "D",
                "d",
                false,
                8
                );

            Question q9 = new Question(
                "Who played the guitar solo on 'Beat it' by Michael Jackson?",
                " ",
                "Rory Gallagher",
                "Slash",
                "Eddie Van Halen",
                "Joe Satriani",
                "C",
                "c",
                false,
                9
                );
                        
            Question q10 = new Question(
                "Who are the greatest band in the world?",
                " ",
                "Oasis",
                "The Beatles",
                "Led Zeppelin",
                "Morris Day and the Time",
                "D",
                "d",
                false,
                10
                );

            //QUIZ QUESTION DEFINTION AND OUTPUT
            //Score beginning value
            int score = 0;

            //Question 1 output
            q1.a = q1.a3;
            q1.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, C or D, then Press Enter");
            string userAnswer = Console.ReadLine();
            Console.WriteLine(" ");
            q1.processAnswer(userAnswer);
            if(q1.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Question 2 output
            q2.a = q2.a1;
            q2.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, C or D, then Press Enter");
            string userAnswer2 = Console.ReadLine();
            Console.WriteLine(" ");
            q2.processAnswer(userAnswer2);
            if (q2.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Question 3 output
            q3.a = q3.a2;
            q3.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, C or D, then Press Enter");
            string userAnswer3 = Console.ReadLine();
            Console.WriteLine(" ");
            q3.processAnswer(userAnswer3);
            if (q3.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Question 4 output
            q4.a = q4.a4;
            q4.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, C or D, then Press Enter");
            string userAnswer4 = Console.ReadLine();
            Console.WriteLine(" ");
            q4.processAnswer(userAnswer4);
            if (q4.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Question 5 output
            q5.a = q5.a3;
            q5.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, C or D, then Press Enter");
            string userAnswer5 = Console.ReadLine();
            Console.WriteLine(" ");
            q5.processAnswer(userAnswer5);
            if (q5.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Question 6 output
            q6.a = q6.a3;
            q6.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, C or D, then Press Enter");
            string userAnswer6 = Console.ReadLine();
            Console.WriteLine(" ");
            q6.processAnswer(userAnswer6);
            if (q6.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Question 7 output
            q7.a = q7.a2;
            q7.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, C or D, then Press Enter");
            string userAnswer7 = Console.ReadLine();
            Console.WriteLine(" ");
            q7.processAnswer(userAnswer7);
            if (q7.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Question 8 output
            q8.a = q8.a4;
            q8.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, or C. Then Press Enter");
            string userAnswer8 = Console.ReadLine();
            Console.WriteLine(" ");
            q8.processAnswer(userAnswer8);
            if (q8.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Question 9 output
            q9.a = q9.a3;
            q9.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, or C. Then Press Enter");
            string userAnswer9 = Console.ReadLine();
            Console.WriteLine(" ");
            q9.processAnswer(userAnswer9);
            if (q9.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Question 10 output
            q10.a = q10.a4;
            q10.showQuestion();
            Console.WriteLine(" ");
            Console.WriteLine("Please type A, B, or C. Then Press Enter");
            string userAnswer10 = Console.ReadLine();
            Console.WriteLine(" ");
            q10.processAnswer(userAnswer10);
            if (q10.ca == true)
            {
                score++;
            }
            Console.WriteLine(" ");

            //Score output
            Console.WriteLine("Your score is: " + score +"/10");
        }
    }
}