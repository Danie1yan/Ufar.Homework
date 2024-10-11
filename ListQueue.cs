using System;
using System.Collections.Generic;

namespace Ufar.Homework
{
    public class ListQueue<T>
    {
        private List<T> _elements = new List<T>();
        public void Enqueue(T item)
        {
            _elements.Add(item);
        }
        public T Dequeue()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            T item = _elements[0];
            _elements.RemoveAt(0);
            return item;
        }
        public T Peek()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            return _elements[0];
        }
        public int Count => _elements.Count;
        public bool IsEmpty => _elements.Count == 0;
    }
}