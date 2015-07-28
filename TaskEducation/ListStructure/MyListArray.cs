using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStructure
{
    class MyListArray : IMyList
    {
        private Data[] data =  new Data[0];
        int length = 0;
        private int indexFirst=0;
        private int indexCurrent = 0;
        Data emptyData = new Data { member1 = 0, member2 = "" };

        private void AddElementWithIndex(Data d, int index)
        {
            if (index <= data.Length && index>=0)
            {
                Data[] newData = new Data[data.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    newData[i] = data[i];
                }
                data = new Data[data.Length+1];
                for (int i = 0; i < index; i++)
                {
                    data[i] = newData[i];
                }
                data[index] = d;
                for (int i = indexCurrent + 1; i < data.Length; i++)
                {
                    data[i] = newData[i - 1];
                }
            }
        }

        public void Add(Data d)
        {
            AddElementWithIndex(d, indexCurrent);
        }

        public void Clear()
        {
            data = new Data[0];
        }

        public void RemoveCurrent()
        {
            if (data.Length > 0)
            {
                int count = data.Length - 1;
                Data[] newData = new Data[count];
                for (int i = 0; i < indexCurrent; i++)
                {
                    newData[i] = data[i];
                }
                for (int i = indexCurrent ; i < newData.Length; i++)
                {
                    newData[i] = data[i + 1];
                }
                data = new Data[count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = newData[i];
                }
                while (indexCurrent >= data.Length)
                    indexCurrent -= 1;
            }
        }

        public void RestartCurrent()
        {
            indexCurrent = 0;
        }

        public void IncrementCurrent()
        {
            if (indexCurrent < data.Length-1)
                indexCurrent++;
        }

        public Data First
        {
            get
            {
                if (data.Length == 0)
                    return emptyData;
                else
                    return data[0];
            }
            set
            {
                AddElementWithIndex(value, 0);
            }
        }

        public Data Current
        {
            get
            {
                if (data.Length == 0)
                    return emptyData;
                else
                    return data[indexCurrent];
            }
            set
            {
                AddElementWithIndex(value, indexCurrent);
            }
        }

        public int GetLength()
        {
            return data.Length;
        }


        public IEnumerator<Data> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
