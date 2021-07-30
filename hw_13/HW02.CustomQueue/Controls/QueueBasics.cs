using System;
using System.Collections.Generic;
using System.Text;

namespace HW02.CustomQueue.Controls
{
    abstract class QueueBasics<T>
    {
        private class QueueItem<T>
        {
            public QueueItem<T> Prev { get; set; } = null;
            public T Item { get; set; }

            public QueueItem(T item, QueueItem<T> prev)
            {
                Item = item;
                Prev = prev;
            }
        }

        QueueItem<T> _head = null;

        public T Dequeue()
        {
            QueueItem<T> result = _head;
            if (!(_head is null))
            {
                _head = _head.Prev;
                return result.Item;
            }
            else
            {
                // Not the brightest idea to return default(T) if queue is empty, but
                //   1) "T?" usage was restricted for REF types only and this class was meant to be "all in one"
                //   2) "A nullable type parameter must be known to be a value type or
                //      non-nullable reference type unless language version '9.0' or greater is used" - that's what compiler said
                return default(T);
            }
        }

        public void Enqueue(T item)
        {
            var newItem = new QueueItem<T>(item, _head);
            _head = newItem;
        }

        public T Peek()
        {
            if (!(_head is null))
            {
                return _head.Item;
            }
            else
            {
                return default(T);
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            var pointer = _head;

            while (!(pointer is null))
            {
                yield return pointer.Item is null ? "null" : pointer.Item.ToString();
                pointer = pointer.Prev;
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in this)
            {
                result += $"=>{item}";
            }
            return result;
        }
    }
}
