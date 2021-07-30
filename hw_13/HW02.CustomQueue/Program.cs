using HW02.CustomQueue.Controls;
using System;

namespace HW02.CustomQueue
{
    class Program
    {
        class TestObject
        {
            Guid Id { get; } = Guid.NewGuid();

            public override string ToString()
            {
                return Id.ToString();
            }
        }

        static void Main(string[] args)
        {
            var queueDateTime = new QueueDateTime();
            queueDateTime.Enqueue(new DateTime(2001, 01, 01));
            queueDateTime.Enqueue(new DateTime(2002, 02, 02));
            queueDateTime.Enqueue(new DateTime(2003, 03, 03));
            queueDateTime.Enqueue(new DateTime(2004, 04, 04));
            queueDateTime.Enqueue(new DateTime(2005, 05, 05));
            TestQueue(queueDateTime);

            var queueObject = new QueueObject();
            queueObject.Enqueue("abc");
            queueObject.Enqueue(123);
            queueObject.Enqueue(null);
            queueObject.Enqueue('c');
            queueObject.Enqueue(111.11);
            TestQueue(queueObject);

            var queueGeneric = new QueueGeneric<TestObject>();
            queueGeneric.Enqueue(new TestObject());
            queueGeneric.Enqueue(new TestObject());
            queueGeneric.Enqueue(new TestObject());
            queueGeneric.Enqueue(new TestObject());
            queueGeneric.Enqueue(new TestObject());
            TestQueue(queueGeneric);
        }

        static void TestQueue<T>(QueueBasics<T> queue)
        {
            Console.WriteLine($"Full queue: {queue}");

            var item = queue.Peek();
            Console.WriteLine($"Queue after Peek: {queue}");
            Console.WriteLine($"Peeked item: {item}");

            item = queue.Dequeue();
            Console.WriteLine($"Queue after Dequeue: {queue}");
            Console.WriteLine($"Dequeued item: {item}");
        }
    }
}
