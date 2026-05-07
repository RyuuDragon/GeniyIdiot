using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше имя: ");
            var user = new User(GetUserName());

            var questionsStorage = new QuestionsStorage();

            Console.WriteLine($"Здравствуйте, {user.Name}! Введите команду:" +
                $" 1 - Создать и пройти тест; 2 - добавить новый вопрос(ы); 3 - удалить вопрос(ы)");
            var command = GetUserCommand();

            ChooseCommand(user, command);

            Console.WriteLine();
            ShowTestsResults();
        }

        private static void ChooseCommand(User user, int command)
        {
            if (command == 1)
            {
                CreateTest(user);
            }

            if (command == 2)
            {
                PerformAddCommand(user);
            }

            if (command == 3)
            {
                PerformDeleteCommand(user);
            }
        }

        private static void PerformAddCommand(User user)
        {
            AddQuestions();

            Console.WriteLine("Вопрос(ы) добавлен(ы)!");

            Console.WriteLine($"{user.Name}! Если хотите начать тест нажмите - Enter");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                CreateTest(user);
            }
            else
            {
                return;
            }
        }

        private static void PerformDeleteCommand(User user)
        {
            DeleteQuestions();

            Console.WriteLine("Вопрос(ы) удален(ы)!");

            Console.WriteLine($"{user.Name}! Выберите команду: 1 - Начать тест; 2 - Добавить вопрос(ы); 3 - Завершить программу");
            var command = GetUserCommand();

            if (command == 1)
            {
                CreateTest(user);
            }

            if (command == 2)
            {
                PerformAddCommand(user);
            }

            return;
        }

        private static void CreateTest(User user)
        {
            var diagnoses = DiagnosesStorage.GetAll();
            var random = new Random();

            do
            {
                Console.Clear();

                var questions = QuestionsStorage.GetAll();
                var questionsCount = questions.Count;
                var correctAnswersCount = 0;

                PrintQuestions(random, questions, questionsCount, ref correctAnswersCount);

                Console.WriteLine($"Количество правильных ответов: {correctAnswersCount}");

                var diagnosis = DiagnosesStorage.GetDiagnosisAssessment(correctAnswersCount, questionsCount);
                Console.WriteLine($"{user.Name}, Ваш диагноз - {diagnosis.Text}");

                var testResults = new string[] { user.Name, correctAnswersCount.ToString(), diagnosis.Text };
                UsersResultStorage.Append(testResults);

                Console.WriteLine($"{user.Name}, если хотите попробовать снова нажмите - Enter");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        private static void PrintQuestions(Random random, List<Question> questions, int questionsCount, ref int correctAnswersCount)
        {
            for (var i = 0; i < questionsCount; i++)
            {
                Console.Clear();

                var randomQuestionIndex = random.Next(0, questions.Count);

                Console.WriteLine();
                Console.WriteLine($"Вопрос № {i + 1}");
                Console.WriteLine(questions[randomQuestionIndex].Text);
                Console.Write("Введите ответ: ");

                var cts = new CancellationTokenSource();
                var token = cts.Token;

                var userAnswer = 0;
                var answerReceived = false;

                var inputTask = Task.Run(() =>
                {
                    userAnswer = GetUserAnswer();
                    answerReceived = true;
                    cts.Cancel();
                });

                int haveSeconds = 10;
                for (int j = haveSeconds; j >= 0; j--)
                {
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }

                    var left = Console.CursorLeft;
                    var top = Console.CursorTop;

                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Следующий вопрос через: {j} секунд");
                    Console.SetCursorPosition(left, top);

                    Thread.Sleep(1000);
                }

                if (answerReceived)
                {
                    cts.Cancel();
                }

                var correctAnswer = questions[randomQuestionIndex].Answer;

                if (userAnswer == correctAnswer)
                {
                    correctAnswersCount++;
                }

                questions.RemoveAt(randomQuestionIndex);
            }
        }

        private static void AddQuestions()
        {
            var questions = QuestionsStorage.GetAll();

            Console.WriteLine("Введите количество вопросов, которые желаете добавить");
            var questionsCount = GetUserAnswer();

            for (var i = 0; i < questionsCount; i++)
            {
                Console.Clear();

                Console.WriteLine("Список существующих вопросов:");
                ShowListQuestions();

                Question question;
                while (true)
                {
                    Console.WriteLine("Введите вопрос который хотите добавить:");
                    var questionText = GetQuestion();

                    Console.WriteLine("Введите ответ на вопрос:");
                    var questionAnswer = GetUserAnswer();

                    bool questionExists = questions.Any(q => q.Text == questionText);

                    if (!questionExists)
                    {
                        question = new Question(questionText, questionAnswer);
                        QuestionsStorage.Add(question);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Такой вопрос уже существует. Пожалуйста введите вопрос снова:");
                    }
                }
            }
        }

        private static void DeleteQuestions()
        {
            Console.WriteLine("Введите количество вопросов, которые желаете удалить");
            var questionsCount = GetUserAnswer();

            var questions = QuestionsStorage.GetAll();

            for (var i = 0; i < questionsCount; i++)
            {
                Console.Clear();

                Console.WriteLine("Список существующих вопросов:");
                ShowListQuestions();

                Console.WriteLine("Выберите номер вопроса который хотите удалить:");
                var questionIndex = GetUserAnswer() - 1;

                if (questions.Count == 3)
                {
                    Console.WriteLine("Должно остаться минимум 3 вопроса! Больше вопросов удалить нельзя!");
                    break;
                }

                QuestionsStorage.Delete(questionIndex);
            }
        }

        private static void ShowListQuestions()
        {
            var questions = QuestionsStorage.GetAll();
            var numberQuestion = 1;

            foreach (var question in questions)
            {
                Console.WriteLine($"{numberQuestion}. {question.Text} = {question.Answer}");
                numberQuestion++;
            }
            Console.WriteLine();
        }

        private static int GetUserCommand()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int command))
                {
                    var message = string.Empty;
                    if (Validator.IsAvailableCommand(command, out message))
                    {
                        return command;
                    }

                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите число!!!");
                }
            }
        }

        private static int GetUserAnswer()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int answer))
                {
                    return answer;
                }

                Console.WriteLine("Пожалуйста, введите число!!!");
            }
        }

        private static string GetUserName()
        {
            var name = Console.ReadLine();
            var message = string.Empty;

            do
            {
                if (!Validator.IsValidName(name, out message))
                {
                    Console.WriteLine(message);
                    name = Console.ReadLine();
                }
                else
                {
                    break;
                }
            } while (true);

            return name;
        }

        private static string GetQuestion()
        {
            var question = Console.ReadLine();
            var message = string.Empty;

            do
            {
                if (!Validator.IsValidQuestion(question, out message))
                {
                    Console.WriteLine(message);
                    question = Console.ReadLine();
                }
                else
                {
                    break;
                }
            } while (true);

            return question;
        }

        private static void ShowTestsResults()
        {
            var headers = new string[] { "ФИО", "Кол-во верных ответов", "Диагноз" };

            var headerLine = string.Format("{0,-10} {1,-25} {2}", headers[0], headers[1], headers[2]);
            Console.WriteLine(headerLine);

            var usersResultsStorage = UsersResultStorage.GetAll();
            foreach (var result in usersResultsStorage)
            {
                var line = string.Format("{0,-10} {1,-25} {2}", result[0], result[1], result[2]);
                Console.WriteLine(line);
            }
        }
    }
}

