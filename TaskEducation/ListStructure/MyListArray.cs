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
        public int indexCurrent = 0;
        Data emptyData = new Data { member1 = 0, member2 = "" };
        public void Add(Data d)
        {
            
            int count = object.Equals(data,null)? 1:data.Length+1;

            Data[] newData = new Data[count-1];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            data=new Data[count];
            for (int i = 0; i < indexCurrent; i++)
            {
                data[i] = newData[i];
            }
            data[indexCurrent] = d;
            for (int i = indexCurrent+1; i < count; i++)
            {
                data[i] = newData[i-1];
            }
                
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
                data[0] = value;

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
                data[indexCurrent]=value;
            }
        }
        public int GetLength()
        {
            return data.Length;
        }
        
    }
}
