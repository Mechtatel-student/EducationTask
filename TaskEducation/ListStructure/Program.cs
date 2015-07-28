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
            MyListList a2 = null;
            MyListArray a3 = null;
            Console.WriteLine(object.Equals(a2,a3));
           

            IMyList listList = new MyListList();
            Data a = new Data { member1 = 5, member2 = " 1212" };
            listList.Add(a);
            Console.WriteLine(listList.GetLength());
            Console.WriteLine(listList.Current.member1 + " " + listList.Current.member2);
            Console.ReadKey();
            //Console.WriteLine(listList.Current.member1);
            //Console.WriteLine(listList.First.member1);
            Console.WriteLine("                       List ");
            Print1(listList);
            listList.Add(a);
            Console.WriteLine("                       List ");
            Print1(listList);
            Console.ReadKey();
            listList.Add(new Data { member1 = 23, member2 = "ssewewwwwe" });
            listList.Add(new Data { member1 = 2, member2 = "t" });
            listList.Add(new Data { member1 = 1, member2 = "13232422" });
            listList.Add(new Data { member1 = 2, member2 = "243242342" });
           
            Console.WriteLine(listList.GetLength());
            Console.WriteLine("                       List ");
            Print1(listList);
            Console.ReadKey();











            //MyListArray listArray = new MyListArray();
            
            //Console.WriteLine(listArray.GetLength());
            //Console.ReadKey();
            //Console.WriteLine(listArray.Current.member1);
            //Console.WriteLine(listArray.First.member1);
            //listArray.Current = a;
            
            //listArray.Add(a);
            //listArray.Add(new Data {member1=23, member2= "ssewewwwwe" });
            //listArray.Add(new Data { member1 = 2, member2 = "t" });
            //listArray.Add(new Data { member1 = 1, member2 = "13232422" });
            //listArray.Add(new Data { member1 = 2, member2 = "243242342" });
            //Print(listArray);
            //Console.WriteLine("-----");

            
            //listArray.RemoveCurrent();
            //listArray.RemoveCurrent();
            //Print(listArray);
            //Console.WriteLine("-----");
            //Console.ReadKey();
            //Console.WriteLine();
            //listArray.RestartCurrent();
            //listArray.IncrementCurrent();
            //listArray.IncrementCurrent();
            //listArray.RemoveCurrent();
            //Print(listArray);
            //Console.ReadKey();

        }

        static void Print1(MyListList a)
        {
            a.RestartCurrent();
            for (int i = 1; i <= a.GetLength(); i++)
            {
                Console.WriteLine(a.Current.member1 + " " + a.Current.member2);
                a.IncrementCurrent();
            }
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
