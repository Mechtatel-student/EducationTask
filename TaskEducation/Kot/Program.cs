using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kot
{
    class Program
    {
        /// <summary>
        /// 2)
        ///  на ввод поступает длинная строка из случайным образом введённых русских букв, 
        ///  цифр, пробелов и других символов (кот потанцевал по клавиатуре). Посчитайте,
        ///  сколько раз коту удалось ввести слово кот (Кот, кОт итд).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            string str1 = str.ToLower();
            Console.WriteLine(str1);
            Console.ReadKey();

            if (str.Contains("кот"))
                Console.WriteLine("1111");
            if (str1.Contains("кот"))
                Console.WriteLine("2222");
            int i = 0;
            int a = 0;
            i = str1.IndexOf("кот", i);
            if (i >= 0)
                a++;
            while (i >= 0)
            {
                i = str1.IndexOf("кот", i + 1);
                if (i >= 0)
                    a++;
            }
            Console.WriteLine("Количество слов \"кот\" в строке: " + a);
            i = -1;
            a = 0;
            Console.WriteLine(str1.IndexOf("кот"));
            do
            {
                i = str1.IndexOf("кот", i + 1);
                if (i >= 0)
                    a++;
            }
            while (i >= 0);
            Console.WriteLine("Количество слов \"кот\" в строке: " + a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
