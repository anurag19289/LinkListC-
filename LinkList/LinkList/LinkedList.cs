using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkList
{
    class LinkedList<T> : ICollection<T>
    {

        public LInkedListNode<T> Head { get; private set; }
        public LInkedListNode<T> Tail { get; private set; }

        //Priavate set coz the list should be managing it nothing else

        #region Add 
        #endregion

        public void AddFirst(T value)
        {
            AddFirst(new LInkedListNode<T>(value));
        }

        public void AddFirst(LInkedListNode<T> node)
        {
            LInkedListNode<T> temp = Head;

            Head = node;
            node.Next = temp;

            Count++;

        }

        public void AddLast(T value)
        {
            AddLast(new LInkedListNode<T>(value));
        }

        private void AddLast(LInkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        #region Remove

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;

                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }

            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {

                    LInkedListNode<T> current = Head;

                    while (current.Next != null)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }
                Count--;
            }
        }

        #endregion


        //int coun
        #region Icollection
        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            LInkedListNode<T> current = Head;

            while (current.Next != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LInkedListNode<T> current = Head;
            while (current.Next != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

       

        //Remove item from the list
        public bool Remove(T item)
        {
           // var z= (((IEnumerable<T>)this).GetEnumerator());
            //IEnumerator IEnumerable.GetEnumerator()
            //var z1 = (((IEnumerable<T>)this).GetEnumerator());
            LInkedListNode<T> previous = null;
            LInkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {

                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (previous.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            LInkedListNode<T> current = Head;
            while (current.Next != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (((IEnumerable<T>)this).GetEnumerator());
        }
        #endregion
    }
}
