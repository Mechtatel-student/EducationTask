using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStructure
{
    class Element
    {
        int data=0;
        int number=0;
        Element postElement = null;


        public Element(int b=0, Element t=null)
        {
            data = b;
            postElement = t;

        }

        
        public Element GetPostElement()
        {
            return postElement;
        }
        public int GetPole()
        {
            return data;
        }
        public void SetPostElement(Element t)
        {
            postElement = t;
        }
    }

    class List
    {
        Element first = null;
        Element current = null;

        public void FirstElement(Element a)
        {
            first = a;
            current = a;
        }

        public void Add(Element a)
        {
            if (object.Equals(first, null))
            {
                first = a;
                current = a;
            }
            else
            {
                current.SetPostElement(a);
                current = a;
            }

        }

         void AddAfterElement(Element a, Element p)
        {
            a.SetPostElement(p.GetPostElement());
            p.SetPostElement(a);
        }

         

        public void AddNumber(Element a, int n)
        {
            Element p = first;
            int i=1;
            if (n >= 1)
            {
                while (!object.Equals(p, null) && i < n)
                {
                    p = p.GetPostElement();
                    i++;
                }
                if (i == n)
                {
                    AddAfterElement(a, p);
                }
                
            }

        }

        public void Delete(int x)
        {
            Element p = first;
            Element q = first;
            while (!object.Equals(p, null))
            {
                if (p.GetPole() == x)
                {
                    if (object.Equals(p, first))
                    {
                        first = first.GetPostElement();
                        p = first;
                        q = first;
                    }
                    else
                    {
                        q.SetPostElement(p.GetPostElement());
                        p = p.GetPostElement();
                    }
                }
                else
                {
                    q = p;
                    p = p.GetPostElement();
                }
            }
        }

        public int CountElenents()
        {
            int count = 0;
            Element p = first;
            while (!object.Equals(p, null))
            {
                count++;
                p = p.GetPostElement();
          
            }
            return count;
        }

        public void Print(string st=" ")
        {
            Element p = first;
            while (!object.Equals(p, null))
            {
                Console.Write(p.GetPole() + st);
                p = p.GetPostElement();
            }
            Console.WriteLine();
            

        }
    }

}
