using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsAndNumbers
{
    class Program
    {

        /// <summary>
        /// 4)
        ///     Существует некий текст со словами и числами. Нужно подсчитать, сколько в нём слов,
        ///     и выбросить из текста каждое третье слово (не считая чисел, которые должны остаться). 
        ///     Результат вывести на экран, используя всего одну инструкцию Console.WriteLine.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text with words and numbers:");
            string str = Console.ReadLine();
            string str1 = str.Replace("  ", " ");
            StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries;

            string[] st = str.Split(new char[] { ' ' }, options);

            Console.WriteLine(str);
            Console.WriteLine(str1);
            int[] a = new int[st.Length];
            int n = 0;
            for (int i = 0; i < st.Length; i++)
                if (String.IsNullOrWhiteSpace(st[i]))
                {
                    a[i] = 0;

                }
                else
                {
                    a[i] = 1;
                    n++;
                }

            string[] st1 = new string[n];
            int j = 0;
            for (int i = 0; i < st.Length; i++)
                if (a[i] == 1)
                {
                    st1[j] = st[i];
                    j++;
                }

            Console.WriteLine("Numbers and words ");
            foreach (string el in st)
                Console.WriteLine(el + ",");
            Console.WriteLine("Numbers and words ");
            foreach (string el in st1)
                Console.WriteLine(el + ",");
            Console.WriteLine("Count words and numbers in consistency is " + st1.Length);
            a = new int[st1.Length];
            n = 0;
            for (int i = 0; i < st1.Length; i++)
            {
                a[i] = 0;
                for (j = 0; j < st1[i].Length; j++)
                    if (char.IsDigit(st1[i], j))
                    {
                        a[i] = 1;
                        break;
                    }
                if (a[i] == 0)
                    n++;

            }
            Console.WriteLine("                         " + n + "    " + a.Length);
            string[] st2 = new string[n];
            j = 0;
            n = 1;
            for (int i = 0; i < st1.Length; i++)
            {
                if (a[i] == 0)
                {
                    if (n % 3 > 0)
                    {
                        st2[j] = st1[i];
                        j++;
                    }
                    n++;
                }
                else
                {
                    st2[j] = st1[i];
                    j++;

                }

                /*
                if (a[i]==0 && n%3>0 || a[i]==1)
                {
                    st2[j] = st1[i];
                      j++;
                }
                if (a[i]==0)
                    n++
                 */

            }
            Console.WriteLine("Numbers and words ");
            foreach (string el in st2)
                Console.WriteLine(el + ",");
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", st2));
            Console.ReadKey();
        }
        //public static void Main()
        //{
        //    Console.WriteLine("Press CTRL+C to exit, otherwise press any key.");
        //    ConsoleKeyInfo cki;
        //    do
        //    {
        //        cki = Console.ReadKey(true);
        //        if (!Char.IsNumber(cki.KeyChar))
        //        {
        //            Console.WriteLine("Non-numeric input");
        //        }
        //        else
        //        {
        //            Int32 number;
        //            if (Int32.TryParse(cki.KeyChar.ToString(), out number))
        //            {
        //                Console.WriteLine("Number received: {0}; <9? {1}", number, number < 9);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Unable to parse input");
        //            }
        //        }
        //    }
        //    while (cki.KeyChar != 27);
        //}
    }
}
