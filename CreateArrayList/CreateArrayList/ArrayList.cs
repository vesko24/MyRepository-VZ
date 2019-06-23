using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateArrayList
{
    class ArrayList<T>
    {
        private int initialCapacity = 2;
        public int Count { get; private set; }
        private T[] items;

        public ArrayList() {
            items = new T[initialCapacity];
        }

        public T this[int index] {
            get {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();
                return items[index];
            }

            set {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();
                items[index] = value;
            }
        }

        public void Add(T item) {
            if (Count == items.Length) Resize();

            items[Count++] = item;
        }

        private void Resize() {
            T[] copy = new T[items.Length * 2];

            for (int i = 0; i < items.Length; i++) copy[i] = items[i];

            items = copy;
        }

        public T RemoveAt(int index) {
            if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();

            T item = items[index];
            Count--;
            Shift(index);

            if (Count <= items.Length / 4) Shrink();

            return item;
        }

        private void Shift(int index) {
            for (int i = index; i < Count; i++) {
                items[i] = items[i + 1];
            }
        }

        private void Shrink() {
            T[] copy = new T[items.Length / 2];

            for (int i = 0; i < items.Length; i++) {
                copy[i] = items[i];
            }

            items = copy;
        }
    }
}
