using System;
using System.Collections.Generic;
using System.Linq;

namespace exam1
{
    public class QuizGame
    {
        public Quiz Quiz { get; set; }
        public User User { get; set; }

        public int Score { get; private set; }

        public QuizGame(Quiz quiz, User user)
        {
            Quiz = quiz;
            User = user;
            Score = 0;
        }

        public void Start()
        {
            for (int i = 0; i < Quiz.Questions.Count; i++)
            {
                var question = Quiz.Questions[i];
                Console.WriteLine($"Question {i + 1}: {question.Text}");

                for (int j = 0; j < question.Options.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {question.Options[j]}");
                }

                Console.Write("Choose correct answers (separated by commas): ");
                string answerInput = Console.ReadLine();
                List<int> userAnswers = answerInput.Split(',').Select(a => int.Parse(a.Trim()) - 1).ToList();

                if (userAnswers.OrderBy(a => a).SequenceEqual(question.CorrectAnswers.OrderBy(a => a)))
                {
                    Score++;
                }
            }

            Console.WriteLine($"Your number of correct answers: {Score}");
        }
    }
}
