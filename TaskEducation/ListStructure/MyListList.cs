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
        }
        private Pair head = null;
        
        public void Add(Data d)
        {
            Pair newElement = new Pair(d); 
          
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void RemoveCurrent()
        {
            throw new NotImplementedException();
        }

        public void RestartCurrent()
        {
            throw new NotImplementedException();
        }

        public void IncrementCurrent()
        {
            throw new NotImplementedException();
        }

        
        public Data First
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Data Current
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
