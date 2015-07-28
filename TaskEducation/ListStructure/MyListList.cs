using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStructure
{
    class MyListList : IMyList
    {
        private class Pair
        {
            Data data;
            Pair next;

            public Pair(Data d,Pair n=null)
            {
                data=d;
                next = n;
            }
            public Data GetData()
            {
                return data;
            }
            public Pair GetPair()
            {
                return next;
            }

            public void SetPair(Pair a)
            {
                next = a;
            }
        }
        private Pair head = null;
        private Pair currentElement = null;
        private Pair predElement = null;
        Data emptyData = new Data { member1 = 0, member2 = "" };


        private void AddNewHead(Data d)
        {
            Pair newElement = new Pair(d,head);
            head = newElement;
        }

        
        public void Add(Data d)
        {
            Pair newElement = new Pair(d);

            if (object.Equals(head, null))
            {
                predElement = newElement;
                head = newElement;
                currentElement = newElement;
            }
            else
            {
                predElement = currentElement;
                newElement.SetPair(currentElement.GetPair());
                currentElement.SetPair(newElement);
            }
        }

        public void AddAfter(Data d)
        {
            Pair newElement = new Pair(d, currentElement.GetPair());
            currentElement.SetPair(newElement);
        }

        public void Clear()
        {
            head = null;
            currentElement = null;
            predElement = null;
        }

        public void RemoveCurrent()
        {
            if (!object.Equals(currentElement, null))
            {
                if (!object.Equals(currentElement.GetPair(), null))
                {
                    currentElement = currentElement.GetPair();
                    predElement.SetPair(currentElement);
                }
                else
                {
                    currentElement = predElement;
                    SetEndCurrent();
                    
                }
            }
        }

        public void RestartCurrent()
        {
            currentElement = head;
            predElement = head;
        }

        public void IncrementCurrent()
        {
            if (!object.Equals(currentElement, null) && !object.Equals(currentElement.GetPair(), null))
            {
                predElement = currentElement;
                currentElement = currentElement.GetPair();
            }
        }
             
        
        public Data First
        {
            get
            {
                if (object.Equals(head, null))
                    return emptyData;
                else
                    return head.GetData();
            }
            set
            {
                AddNewHead(value);
            }
        }

        public Data Current
        {
            get
            {
                if (object.Equals(currentElement, null))
                    return emptyData;
                else
                    return currentElement.GetData();
            }
            set
            {
                Add(value);
            }
        }

        public void SetEndCurrent()
        {
            RestartCurrent();
            while (!object.Equals(currentElement, null) && !object.Equals(currentElement.GetPair(), null))
            {
                IncrementCurrent();
            }
        }

        public int GetLength()
        {
            Pair p = currentElement;
            Pair q = predElement;
            int n = 0;
            RestartCurrent();
            if (!object.Equals(currentElement, null) && object.Equals(currentElement.GetPair(), null))
            {
                n++;
            } 
            while (!object.Equals(currentElement, null) && !object.Equals(currentElement.GetPair(),null))
            {
                n++;
                IncrementCurrent();
            }
           
            currentElement = p;
            predElement = q;
            return n;

        }
    }
}
