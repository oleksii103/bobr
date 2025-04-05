using System;
using System.Collections.Generic;
using System.Linq;

namespace exam1
{
    public class QuizApp
    {
        private static List<User> users = new List<User>();
        private static User currentUser = null;
        private static List<Quiz> availableQuizzes = new List<Quiz>(); 

        public void Start()
        {
            Console.WriteLine("Welcome to the Quiz Program!");

            while (true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Register();
                }
                else if (choice == "2")
                {
                    Login();
                }
                else if (choice == "3")
                {
                    break;
                }
            }
        }

        private static void Register()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            if (users.Any(u => u.Username == username))
            {
                Console.WriteLine("This username is already taken.");
                return;
            }

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter birthdate (yyyy-mm-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            users.Add(new User { Username = username, Password = password, BirthDate = birthDate });
            Console.WriteLine("Registration successful!");
        }

        private static void Login()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            currentUser = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (currentUser != null)
            {
                Console.WriteLine($"Welcome, {currentUser.Username}!");
                ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Incorrect username or password.");
            }
        }

        private static void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Start a new quiz");
                Console.WriteLine("2. Create a new quiz (Add questions)");
                Console.WriteLine("3. View results");
                Console.WriteLine("4. Change settings");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    StartQuiz();
                }
                else if (choice == "2")
                {
                    CreateQuiz();
                }
                else if (choice == "3")
                {
                    ViewResults();
                }
                else if (choice == "4")
                {
                    ChangeSettings();
                }
                else if (choice == "5")
                {
                    break;
                }
            }
        }

        private static void CreateQuiz()
        {
            Console.WriteLine("Enter quiz topic: ");
            string topic = Console.ReadLine();

            Quiz quiz = new Quiz { Topic = topic };

            while (true)
            {
                Console.WriteLine("\n1. Add new question");
                Console.WriteLine("2. Done adding questions");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddQuestionToQuiz(quiz);
                }
                else if (choice == "2")
                {
                    break;
                }
            }

            availableQuizzes.Add(quiz); 
            Console.WriteLine($"Quiz '{quiz.Topic}' created with {quiz.Questions.Count} questions!");
        }

        private static void AddQuestionToQuiz(Quiz quiz)
        {
            Console.Write("Enter question text: ");
            string questionText = Console.ReadLine();

            List<string> options = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter option {i + 1}: ");
                options.Add(Console.ReadLine());
            }

            Console.Write("Enter correct answer numbers (comma separated, e.g., 1,2): ");
            string correctAnswersInput = Console.ReadLine();
            List<int> correctAnswers = correctAnswersInput.Split(',').Select(int.Parse).Select(n => n - 1).ToList();

            Question newQuestion = new Question
            {
                Text = questionText,
                Options = options,
                CorrectAnswers = correctAnswers
            };

            quiz.AddQuestion(newQuestion);
        }

        private static void StartQuiz()
        {
            if (availableQuizzes.Count == 0)
            {
                Console.WriteLine("No quizzes available. Please create a quiz first.");
                return;
            }

            Console.WriteLine("Select a quiz to start:");

            for (int i = 0; i < availableQuizzes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableQuizzes[i].Topic}");
            }

            Console.Write("Choose a quiz: ");
            int quizChoice = int.Parse(Console.ReadLine()) - 1;

            if (quizChoice >= 0 && quizChoice < availableQuizzes.Count)
            {
                Quiz selectedQuiz = availableQuizzes[quizChoice];
                QuizGame quizGame = new QuizGame(selectedQuiz, currentUser);
                quizGame.Start();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        private static void ViewResults()
        {
            Console.WriteLine("Your results:");
        }

        private static void ChangeSettings()
        {
            Console.WriteLine("1. Change password");
            Console.WriteLine("2. Change birthdate");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter new password: ");
                currentUser.Password = Console.ReadLine();
                Console.WriteLine("Password changed.");
            }
            else if (choice == "2")
            {
                Console.Write("Enter new birthdate (yyyy-mm-dd): ");
                currentUser.BirthDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Birthdate changed.");
            }
        }
    }
}
