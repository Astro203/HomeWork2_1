using System;

namespace HomeWork2_1
{
    class Program
    {

        /// <summary>
        /// Метод для проверки принадлежности введенной строки к вещественным числам
        /// </summary>
        /// <param name="ChisDouble"></param>
        /// <returns></returns>
        static bool ChisDouble(string s)
        {
            bool f = false;
            int i = 0;
            int j = 0;
            if (s.Length > 0)
            {
                while ((i < s.Length) && ((s[i] == ',') || (Char.IsNumber(s[i]))))
                {
                    if (s[i] == ',')
                        j++;
                    i++;
                }
                if ((s.Length == i) && (Char.IsNumber(s[i - 1])) && ((j == 0) ^ (j == 1)) && (s[0] != ','))
                    f = true;
            }
            return f;
        }

        /// <summary>
        /// Метод для проверки ринадлежности введенной строки к числам типа byte
        /// </summary>
        /// <param name="ChisInt"></param>
        /// <returns></returns>
        static bool ChisInt(string s)
        {
            bool f = false;
            int i = 0;
            if (s.Length > 0)
            {
                while ((i < s.Length) && (Char.IsNumber(s[i])))
                {
                    i++;
                }
                if ((s.Length == i) && (Char.IsNumber(s[i - 1])) && (Convert.ToInt32(s) <= 255) && (s[0] != '0'))
                    f = true;
            }
            return f;
        }

        static void Main(string[] args)
        {
            //Задание 1. Создание нескольких переменных разных типов, в которых могут храниться данные

            string str =""; //Вспомогательная строковая переменная
            //Ввод данных первого сотрудника
            #region "Первый сотрудник"
            Console.WriteLine("Первый сотрудник:");                      
 
            //Ввод имени первого сотрудника
            Console.Write("Введите имя: ");
            string FirstName1 = Console.ReadLine(); //Объявление переменной типа string для имени           
 
            //Ввод фамилии первого сотрудника
            Console.Write("Введите фамилию: ");   
            string LastName1 = Console.ReadLine(); //Объявление переменной типа string для фамилии           
 
            //Ввод роста первого сотрудника
            Console.Write("Введите рост: ");     
            str= Console.ReadLine(); //Ввод с клавиатуры
            //Проверка на принадлежность введенной строки к числам
            double Height1 = 0; //Объявление переменной типа byte для балла русскому языку
            if (ChisDouble(str))
            {
                Height1 = Convert.ToDouble(str); //Объявление переменной типа double для роста
            }
            else Console.WriteLine("             Нужно было ввести число!");
            
            //Ввод балла по русскому языку первого сотрудника
            Console.Write("Введите балл по русскому языку от 0 до 255: ");          
            str = Console.ReadLine(); //Ввод с клавиатуры
            //Проверка на принадлежность введенной строки к числам
            byte ScoreRussianLanguage1 = 0; //Объявление переменной типа byte для балла по русскому языку
            if (ChisInt(str))
            {
                ScoreRussianLanguage1 = Convert.ToByte(str); 
            }
            else Console.WriteLine("             Нужно было ввести число от 0 до 255");
            
            //Ввод балла по истории первого сотрудника
            Console.Write("Введите балл по истории: ");
            str = Console.ReadLine(); //Ввод с клавиатуры
            //Проверка на принадлежность введенной строки к числам
            byte ScoreHistory1 = 0; //Объявление переменной типа byte для балла истории
            if (ChisInt(str))
            {
                ScoreHistory1 = Convert.ToByte(str);
            }
            else Console.WriteLine("             Нужно было ввести число от 0 до 255");           
  
            //Ввод балла по математике первого сотрудника
            Console.Write("Введите балл по математике: ");  
            str = Console.ReadLine();
            //Проверка на принадлежность введенной строки к числам
            byte ScoreMath1 = 0; //Объявление переменной типа byte для балла математике
            if (ChisInt(str))
            {
                ScoreMath1 = Convert.ToByte(str); 
            }
            else Console.WriteLine("             Нужно было ввести число от 0 до 255");
            Console.WriteLine();
            #endregion

            //Ввод данных второго сотрудника
            #region "Второй сотрудник"        
            Console.WriteLine("Второй сотрудник:");

            //Ввод имени первого сотрудника
            Console.Write("Введите имя: ");
            string FirstName2 = Console.ReadLine(); //Объявление переменной типа string для имени

            //Ввод фамилии первого сотрудника
            Console.Write("Введите фамилию: ");
            string LastName2 = Console.ReadLine(); //Объявление переменной типа string для фамилии

            //Ввод роста первого сотрудника
            Console.Write("Введите рост: ");
            str = Console.ReadLine(); //Ввод с клавиатуры
            //Проверка на принадлежность введенной строки к числам
            double Height2 = 0; //Объявление переменной типа double для роста
            if (ChisDouble(str))
            {
                Height2 = Convert.ToDouble(str);
            }
            else Console.WriteLine("             Нужно было ввести число!");

            //Ввод балла по русскому языку первого сотрудника
            Console.Write("Введите балл по русскому языку от 0 до 255: ");
            str = Console.ReadLine(); //Ввод с клавиатуры
            //Проверка на принадлежность введенной строки к числам
            byte ScoreRussianLanguage2 = 0; //Объявление переменной типа byte для балла по русскому языку
            if (ChisInt(str))
            {
                ScoreRussianLanguage2 = Convert.ToByte(str);
            }
            else Console.WriteLine("             Нужно было ввести число от 0 до 255");

            //Ввод балла по истории первого сотрудника
            Console.Write("Введите балл по истории: ");
            str = Console.ReadLine(); //Ввод с клавиатуры
            //Проверка на принадлежность введенной строки к числам
            byte ScoreHistory2 = 0; //Объявление переменной типа byte для балла истории
            if (ChisInt(str))
            {
                ScoreHistory2 = Convert.ToByte(str);
            }
            else Console.WriteLine("             Нужно было ввести число от 0 до 255");

            //Ввод балла по математике первого сотрудника
            Console.Write("Введите балл по математике: ");
            str = Console.ReadLine();
            //Проверка на принадлежность введенной строки к числам
            byte ScoreMath2 = 0; //Объявление переменной типа byte для балла математике
            if (ChisInt(str))
            {
                ScoreMath2 = Convert.ToByte(str);
            }
            else Console.WriteLine("             Нужно было ввести число от 0 до 255");
            Console.WriteLine();
            #endregion;

            //Ввод данных третьего сотрудника
            #region "Третий сотрудник"
            Console.WriteLine("Третий сотрудник:");

            //Ввод имени первого сотрудника
            Console.Write("Введите имя: ");
            string FirstName3 = Console.ReadLine(); //Объявление переменной типа string для имени

            //Ввод фамилии первого сотрудника
            Console.Write("Введите фамилию: ");
            string LastName3 = Console.ReadLine(); //Объявление переменной типа string для фамилии

            //Ввод роста первого сотрудника
            Console.Write("Введите рост: ");
            str = Console.ReadLine(); //Ввод с клавиатуры
            //Проверка на принадлежность введенной строки к числам
            double Height3 = 0; //Объявление переменной типа double для роста
            if (ChisDouble(str))
            {
                Height1 = Convert.ToDouble(str);
            }
            else Console.WriteLine("             Нужно было ввести число!");

            //Ввод балла по русскому языку первого сотрудника
            Console.Write("Введите балл по русскому языку от 0 до 255: ");
            str = Console.ReadLine(); //Ввод с клавиатуры
            //Проверка на принадлежность введенной строки к числам
            byte ScoreRussianLanguage3 = 0; //Объявление переменной типа byte для балла по русскому языку
            if (ChisInt(str))
            {
                ScoreRussianLanguage3 = Convert.ToByte(str);
            }
            else Console.WriteLine("             Нужно было ввести число от 0 до 255");

            //Ввод балла по истории первого сотрудника
            Console.Write("Введите балл по истории: ");
            str = Console.ReadLine(); //Ввод с клавиатуры
            //Проверка на принадлежность введенной строки к числам
            byte ScoreHistory3 = 0; //Объявление переменной типа byte для балла истории
            if (ChisInt(str))
            {
                ScoreHistory3 = Convert.ToByte(str);
            }
            else Console.WriteLine("             Нужно было ввести число от 0 до 255");

            //Ввод балла по математике первого сотрудника
            Console.Write("Введите балл по математике: ");
            str = Console.ReadLine();
            //Проверка на принадлежность введенной строки к числам
            byte ScoreMath3 = 0; //Объявление переменной типа byte для балла математике
            if (ChisInt(str))
            {
                ScoreMath3 = Convert.ToByte(str);
            }
            else Console.WriteLine("             Нужно было ввести число от 0 до 255");
            Console.WriteLine();
            #endregion;

            //Задание 2. Реализация в системе автоматического подсчёта среднего балла по трём предметам, указанным в пункте 1

            double AverageScore1 = (ScoreRussianLanguage1 + ScoreHistory1 + ScoreMath1) / 3;
            Console.WriteLine("Средний балл первого сотрудника: ", AverageScore1.ToString("#.##"));

            double AverageScore2 = (ScoreRussianLanguage2 + ScoreHistory2 + ScoreMath2) / 3;
            Console.WriteLine("Средний балл второго сотрудника: ", AverageScore2.ToString("#:##"));

            double AverageScore3 = (ScoreRussianLanguage3 + ScoreHistory3 + ScoreMath3) / 3;
            Console.WriteLine("Средний балл третьего сотрудника: ", AverageScore3.ToString("#:##"));
            Console.WriteLine();

            //Задание 3. Реализация возможности вывода информации на консоли
            Console.WriteLine(AverageScore1.ToString("#:##")); //Обычный вывод для первого сотрудника

            Console.WriteLine("Средний балл второго сотрудника: {0}", AverageScore2.ToString("#:##")); //Форматированный вывод для второго сотрудника

            Console.WriteLine($"Средний балл третьего сотрудника: {AverageScore3:#.##}"); //Интерполяция строк для третьего сотрудника

            //Задание 4.Комментирование кода с использованием обычных или XML-комментариев

            /* Для выполнения домашнего задания использованы следующие типы переменных:
             *  - имя типа string
             *  - фамилия типа string
             *  - рост типа double
             *  - баллы типа byte
             *  - средний балл типа double
             * Использованы разные типы форматирования строк для вывода среднего балла: обычный, форматированный и интерполяция строк 
             */

            //Задание 5. Реализация возможности вывода данных в центре консоли

            Console.ReadKey();
            Console.Clear();
            int center = Console.WindowWidth / 2;
            //Первый сотрудник
            Console.SetCursorPosition(center - 10, 0);
            Console.WriteLine("Первый сотрудник");
            Console.SetCursorPosition(center - FirstName1.Length / 2, 1); Console.WriteLine(FirstName1);
            Console.SetCursorPosition(center - LastName1.Length / 2, 2); Console.WriteLine(LastName1);
            Console.SetCursorPosition(center - Convert.ToString(Height1).Length / 2, 3); Console.WriteLine(Convert.ToString(Height1));
            Console.SetCursorPosition(center - Convert.ToString(ScoreRussianLanguage1).Length / 2, 4); Console.WriteLine(Convert.ToString(ScoreRussianLanguage1));
            Console.SetCursorPosition(center - Convert.ToString(ScoreHistory1).Length / 2, 5); Console.WriteLine(Convert.ToString(ScoreHistory1));
            Console.SetCursorPosition(center - Convert.ToString(ScoreMath1).Length / 2, 6); Console.WriteLine(Convert.ToString(ScoreMath1));
            Console.WriteLine();

            //Второй сотрудник
            Console.SetCursorPosition(center - 10, 8);
            Console.WriteLine("Второй сотрудник");
            Console.SetCursorPosition(center - FirstName2.Length / 2, 9); Console.WriteLine(FirstName2);
            Console.SetCursorPosition(center - LastName2.Length / 2, 10); Console.WriteLine(LastName2);
            Console.SetCursorPosition(center - Convert.ToString(Height2).Length / 2, 11); Console.WriteLine(Convert.ToString(Height2));
            Console.SetCursorPosition(center - Convert.ToString(ScoreRussianLanguage2).Length / 2, 12); Console.WriteLine(Convert.ToString(ScoreRussianLanguage2));
            Console.SetCursorPosition(center - Convert.ToString(ScoreHistory2).Length / 2, 13); Console.WriteLine(Convert.ToString(ScoreHistory2));
            Console.SetCursorPosition(center - Convert.ToString(ScoreMath2).Length / 2, 14); Console.WriteLine(Convert.ToString(ScoreMath2));
            Console.WriteLine();

            //Третий сотрудник
            Console.SetCursorPosition(center - 10,16);
            Console.WriteLine("Третий сотрудник");
            Console.SetCursorPosition(center - FirstName3.Length / 2, 17); Console.WriteLine(FirstName3);
            Console.SetCursorPosition(center - LastName3.Length / 2, 18); Console.WriteLine(LastName3);
            Console.SetCursorPosition(center - Convert.ToString(Height3).Length / 2, 19); Console.WriteLine(Convert.ToString(Height3));
            Console.SetCursorPosition(center - Convert.ToString(ScoreRussianLanguage3).Length / 2, 20); Console.WriteLine(Convert.ToString(ScoreRussianLanguage3));
            Console.SetCursorPosition(center - Convert.ToString(ScoreHistory3).Length / 2, 21); Console.WriteLine(Convert.ToString(ScoreHistory3));
            Console.SetCursorPosition(center - Convert.ToString(ScoreMath3).Length / 2, 22); Console.WriteLine(Convert.ToString(ScoreMath3));
            Console.WriteLine();
        }
    }
}
