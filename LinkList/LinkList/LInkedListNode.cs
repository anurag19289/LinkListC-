using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class LInkedListNode<T>
    {
        public LInkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public LInkedListNode<T> Next { get; set; }
    }
}
