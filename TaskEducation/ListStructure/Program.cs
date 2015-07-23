using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStructure
{
    class Program
    {
        static void Main(string[] args)
        {


            MyListArray listArray = new MyListArray();
            Data a = new Data {member1=5, member2= " 1212"};
            Print(listArray);
            Console.ReadKey();
            Console.WriteLine(listArray.Current.member1);
            Console.WriteLine(listArray.First.member1);
            listArray.Add(a);
            listArray.Add(new Data {member1=23, member2= "ssewewwwwe" });
            listArray.Add(new Data { member1 = 2, member2 = "t" });
            listArray.Add(new Data { member1 = 1, member2 = "13232422" });
            listArray.Add(new Data { member1 = 2, member2 = "243242342" });
            Print(listArray);
            Console.WriteLine("-----");

            Console.WriteLine(listArray.indexCurrent);
                Console.ReadKey();
            listArray.RemoveCurrent();
            listArray.RemoveCurrent();
            Print(listArray);
            Console.WriteLine("-----");
            Console.ReadKey();
            Console.WriteLine();
            listArray.RestartCurrent();
            listArray.IncrementCurrent();
            listArray.IncrementCurrent();
            listArray.RemoveCurrent();
            Print(listArray);
            Console.ReadKey();
        }
        static void Print(MyListArray a)
        {
            a.RestartCurrent();
            for (int i = 1; i <= a.GetLength(); i++)
            {
                Console.WriteLine(a.Current.member1 + " " + a.Current.member2);
                a.IncrementCurrent();
            }

        }
    }
}
