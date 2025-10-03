using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UsoltsevGP.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Проверяем каждый символ в строке
            foreach (char c in value)
            {
                // Символ должен быть в диапазоне русских строчных букв
                if (c < 'а' || c > 'я')
                {
                    // Если нашли символ, который не русская строчная буква
                    // Исключение: буква 'ё' имеет отдельный код
                    if (c != 'ё')
                        return false;
                }
            }

            return true;
        }
    }
}
