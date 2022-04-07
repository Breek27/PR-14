using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнили студенты 2 курса  Широнин Николай и Пилипенко Богдан");
            Console.WriteLine("Задание№6");
            StreamReader sr = new StreamReader(@"input.txt");
            string text = sr.ReadToEnd();
            Console.WriteLine(text);
            int Rus = 0;
            int Eng = 0;
            String textArray = string.Empty;
            foreach (char ch in text)
            {
                if ((int)ch >= 'а' && (int)ch <= 'я' || (int)ch >= 'А' && (int)ch <= 'Я')
                    Rus++;

                if ((int)ch >= 'a' && (int)ch <= 'z' || (int)ch >= 'A' && (int)ch <= 'Z')
                    Eng++;
            }

            if (Rus > Eng)
                textArray = "Кириллицы больше";

            if (Rus < Eng)
                textArray = "Латиницы больше";

            if (Rus == Eng)
                textArray = "Одинаково";
            Console.WriteLine("Букв");
            Console.WriteLine(Rus);
            Console.WriteLine(textArray);
            StreamWriter sw = new StreamWriter(@"result.txt");
            sw.WriteLine($"Букв кол-во{Rus},{textArray}");
            sw.Close();
            Console.ReadKey();
            Console.WriteLine("Задание№4");
            StreamReader sr1 = new StreamReader(@"input1.txt");
            string text1 = sr1.ReadToEnd();
            Console.WriteLine(text1);
            string[] text1Array = text1.Split(' ');
            int[] lenghtArray = new int[text1Array.Length];
            lenghtArray = text1Array.Select(x => x.Length).ToArray();
            Console.WriteLine(lenghtArray.Min());
            int Count = text1Array.Count(x => x.Length == lenghtArray.Min());
            Console.WriteLine(Count);
            Console.ReadKey();
            StreamWriter sw1 = new StreamWriter(@"result1.txt");
            sw1.WriteLine($"кол-во самых коротких слов{Count}");
            sw1.Close();
            Console.ReadKey();
            Console.WriteLine("Задание 3");
            StreamReader sr2 = new StreamReader(@"input1.txt");
            string text2 = sr2.ReadToEnd();
            Console.WriteLine(text2);
            string[] text2Array = text1.Split(' ');
            foreach (string w in text2Array.OrderBy(x => x).Distinct())
            {
                Console.WriteLine(w);
                sw.WriteLine(w);
            }
            StreamWriter sw2 = new StreamWriter(@"result2.txt");
            sw2.WriteLine(text2Array);
            sw2.Close();
            Console.WriteLine("Задание 8");
            StreamReader sr3 = new StreamReader(@"input.txt");
            string text3 = sr3.ReadToEnd();
            Console.WriteLine(text3);
            string newtext = "";
            foreach (char c in text)
            {
                if (Char.IsUpper(c))
                    newtext += c.ToString().ToLower();
                else
                    newtext += c.ToString().ToUpper();
            }
            Console.WriteLine($"{newtext}");
            sw.WriteLine($"Вариант 8{newtext}");
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите искомое слово");
            string word = Console.ReadLine();
            Console.WriteLine($"Входит ли искомое слово в текст?{text1Array.Contains(word)}");
            Console.WriteLine(text1Array.Count(x => x == word));
            sw.WriteLine("Вариант1");
            sw.WriteLine($"Входит ли искомое слово в текст?{text1Array.Contains(word)}");
            sw.WriteLine(text1Array.Count(x => x == word));
        }
    }
}

