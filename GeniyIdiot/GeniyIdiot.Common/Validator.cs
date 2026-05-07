using System.Text.RegularExpressions;

namespace GeniyIdiot.Common
{
    public class Validator
    {
        public static bool IsValidName(string name, out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                message = "Имя должно содержать больше одного символова. Пожалуйста введите имя снова!";
                return false;
            }

            var pattern = "^[A-Za-zА-Яа-яЁё-]+$";
            var regex = new Regex(pattern);

            if (!regex.IsMatch(name))
            {
                message = "Имя должно содержать только буквы и \"-\" (если имя является двойным)." +
                    " Пожалуйста введите имя снова!";
                return false;
            }

            if (char.IsLower(name[0]))
            {
                message = "Имя должно начинаться с большой буквы. Пожалуйста введите имя снова!";
                return false;
            }

            return true;
        }

        public static bool IsValidQuestion(string question, out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(question) || question.Length < 20)
            {
                message = "Вопрос должен содержать больше 20 символов. Пожалуйста введите вопрос снова!";
                return false;
            }

            bool containsOnlyDigit = true;
            foreach (char member in question)
            {
                if (!char.IsDigit(member))
                {
                    containsOnlyDigit = false;
                    break;
                }
            }

            if (containsOnlyDigit)
            {
                message = "Вопрос не может содержать только цифры. Пожалуйста введите вопрос снова!";
                return false;
            }

            return true;
        }

        public static bool IsAvailableCommand(int command, out string message)
        {
            message = string.Empty;

            if (command == 0 || command > 3)
            {
                message = "Такой комманды не существует, введите команду снова!";
                return false;
            }

            return true;
        }
    }
}
