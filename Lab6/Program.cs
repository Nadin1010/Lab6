using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Подлинно разумное обучение изменит и наш ум и наши нравы";
            string wordWithMaxLength = string.Empty;
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > wordWithMaxLength.Length)
                    wordWithMaxLength = words[i];
            Console.WriteLine(wordWithMaxLength);
            Console.ReadKey();
        }
    }
}

