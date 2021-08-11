using System;
using System.Collections.Generic;
using System.Text;

namespace HW02.CustomQueue.Controls
{
    abstract class QueueBasics<T>
    {
        private class QueueItem<T>
        {
            public QueueItem<T> Next { get; set; } = null;
            public QueueItem<T> Prev { get; set; } = null;
            public T Item { get; set; }

            public QueueItem(T item, QueueItem<T> next, QueueItem<T> prev)
            {
                Item = item;
                Next = next;
                Prev = prev;
            }
        }

        QueueItem<T> _tail = null;

        public T Dequeue()
        {
            QueueItem<T> head = GetQueueHead();
            if (!(head is null))
            {
                // Remove head item making a new head
                if (!(head.Prev is null))
                {
                    head.Prev.Next = null;
                }
                else // Which means that current item was the only one in the queue
                {
                    _tail = null;
                }

                return head.Item;
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
            var newItem = new QueueItem<T>(item, _tail, null);
            if (!(newItem.Next is null))
            {
                newItem.Next.Prev = newItem;
            }
            _tail = newItem;
        }

        public T Peek()
        {
            QueueItem<T> head = GetQueueHead();
            if (!(head is null))
            {
                return head.Item;
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

        private QueueItem<T> GetQueueHead()
        {
            QueueItem<T> result = _tail;
            if (!(result is null))
            {
                // Find queue head
                while (!(result.Next is null))
                {
                    result = result.Next;
                }
                return result;
            }
            else
            {
                return null;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            var pointer = _tail;

            while (!(pointer is null))
            {
                yield return pointer.Item is null ? "null" : pointer.Item.ToString();
                pointer = pointer.Next;
            }
        }

        public override string ToString()
        {
            string result = "===>";
            foreach (var item in this)
            {
                result += $"{item}||";
            }
            return result;
        }
    }
}
