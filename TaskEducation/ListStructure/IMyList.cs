using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStructure
{
    struct Data
    {
        public int member1;
        public string member2;
    }

    interface IMyList : IEnumerable<Data>
    {
        void Add(Data d);
        void Clear();
        void RemoveCurrent();

        void RestartCurrent();
        void IncrementCurrent();

        Data First { get; set; }
        Data Current { get; set; }
    }
}
