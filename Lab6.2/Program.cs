using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab6._2
{
    class Program
    {
        static bool IsPalindrom(string text)
        {
            //удаляем пробелы
            var s = text.Replace(" ", string.Empty);
            //приводим в нижний регистр
            s = s.ToLower();
            //индекс последнего символа
            int lastIndex = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                //если символы не одинаковые, возвращаем false
                if (s[i] != s[lastIndex - i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите строку для проверки: ");
            var text = Console.ReadLine();
            var res = IsPalindrom(text) ? string.Empty : "не ";
            Console.WriteLine($"Строка \"{text}\" {res}является палиндромом");
            Console.ReadLine();
        }
    }
}



