using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueue
{
    class LinkedQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;
        public int Count { get; private set; }

        public LinkedQueue() {
            head = null;
            tail = null;
            Count = 0;
        }

        public void Enqueue(T element) {
            if (Count == 0) head = tail = new QueueNode<T>(element);
            else {
                var newHead = new QueueNode<T>(element);
                newHead.NextNode = head;
                head.PrevNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public T Dequeue() {
            if (Count == 0) throw new InvalidOperationException("Queue empty");

            var firstElement = head.Value;
            head = head.NextNode;

            if (head != null) head.PrevNode = null;
            else { tail = null; }

            Count--;
            return firstElement;
        }

        public T[] ToArray() {
            var arr = new T[Count];
            int index = 0;
            var currentNode = head;

            while (currentNode != null)
            {
                arr[index++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }
    }
}
