using System;
using System.Collections.Generic;

namespace exam1
{
    public class Quiz
    {
        public string Topic { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void EditQuestion(int index, Question newQuestion)
        {
            if (index >= 0 && index < Questions.Count)
            {
                Questions[index] = newQuestion;
            }
        }

        public void DisplayQuestions()
        {
            for (int i = 0; i < Questions.Count; i++)
            {
                var question = Questions[i];
                Console.WriteLine($"Question {i + 1}: {question.Text}");
                for (int j = 0; j < question.Options.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {question.Options[j]}");
                }
            }
        }
    }
}
