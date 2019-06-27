using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class DoubleLinkedList<T> : IEnumerable<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;
        public int Count { get; private set; }

        public DoubleLinkedList() {
            head = null;
            tail = null;
            Count = 0;
        }

        public void AddFirst(T element) {
            if (Count == 0) head = tail = new ListNode<T>(element);
            else {
                var newHead = new ListNode<T>(element);
                newHead.NextNode = head;
                head.PrevNode = newHead;
                head = newHead;
            }
            
            Count++;
        }

        public void ForEach(Action<T> action) {
            var currentNode = head;

            while (currentNode != null) {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public void AddLast(T element) {
            if (Count == 0) head = tail = new ListNode<T>(element);
            else {
                var newTail = new ListNode<T>(element);
                newTail.PrevNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public T RemoveFirst(T element) {
            if (Count == 0) throw new InvalidOperationException("List empty");

            var firstElement = head.Value;
            head = head.NextNode;

            if (head != null) head.PrevNode = null;
            else { tail = null; }

            Count--;
            return firstElement;
        }

        public T RemoveLast(T element) {
            if (Count == 0) throw new InvalidOperationException("List empty");

            var lastElement = tail.Value;
            tail = tail.PrevNode;

            if (tail != null) tail.NextNode = null;
            else { head = null; }

            Count--;
            return lastElement;
        }

        public T[] ToArray() {
            var arr = new T[Count];
            int index = 0;
            var currentNode = head;

            while (currentNode != null) {
                arr[index++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }

        public IEnumerator<T> GetEnumerator() {
            var currentNode = head;

            while (currentNode != null) {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
