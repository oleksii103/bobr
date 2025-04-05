using System;
using System.Collections.Generic;

namespace exam1
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; } = new List<string>();
        public List<int> CorrectAnswers { get; set; } = new List<int>(); 
    }
}
