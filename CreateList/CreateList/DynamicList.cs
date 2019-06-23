using System;
using System.Collections.Generic;
using System.Text;

namespace CreateList
{
    public class DynamicList
    {
        class Node
        {
            private object element;
            private Node next;

            public Node Next {
                get { return next; }
                set { next = value; }
            }

            public object Element {
                get { return element; }
                set { element = value; }
            }

            public Node(object element, Node prevNode) {
                Element = element;
                Next = null;
                prevNode.Next = this;
            }

            public Node(object element) {
                Element = element;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public int Count { get { return count; } }

        public DynamicList() {
            head = null;
            tail = null;
            count = 0;
        }

        public void Add(object item) {
            if (Count == 0) {
                Node node = new Node(item);
                head = node;
                tail = node;
            } else {
                Node node = new Node(item, tail);
                tail = node;
            }

            count++;
        }

        public object Remove(int index) {
            if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();

            if (index == 0) head = (Node)head.Next;

            int current_index = 0;
            Node current = head;
            Node prev = null;

            while (current_index < index) {
                current_index++;
                prev = current;
                current = (Node)current.Next;
            }

            object element = current.Element;

            if (index == 0) head = (Node)head.Next;
            else { prev.Next = current.Next; }

            count--;
            return element;
        }

        public int RemoveItem(object item) {
            Node current = head;
            int ind = 0;

            while (current != null && !current.Element.Equals(item)) {
                current = current.Next;
                ind++;
            }

            if (current == null) return -1;
            else {
                Remove(ind);
                return ind;
            }
        }

        public int IndexOf(object item)
        {
            Node current = head;
            int ind = 0;

            while (current != null && !current.Element.Equals(item)) {
                current = current.Next;
                ind++;
            }

            if (current == null) return -1;
            else { return ind; }
        }

        public bool Contains(object item) {
            if (IndexOf(item) != -1) return true;
            else { return false; }
        }

        public object this[int index] {
            get {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();

                int currentIndex = 0;
                Node current = head;

                while (currentIndex < index) {
                    currentIndex++;
                    current = current.Next;
                }

                return current.Element;
            }

            set {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();

                int currentIndex = 0;
                Node current = head;

                while (currentIndex < index) {
                    currentIndex++;
                    current = current.Next;
                }

                current.Element = value;
            }
        }
    }
}