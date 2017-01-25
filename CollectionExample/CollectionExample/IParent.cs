using System;
using System.Collections.Generic;

namespace CollectionExample
{
    public interface IParent
    {
         
    }

    public class Parent : IParent
    {
        public override string ToString()
        {
            return "parent " + this.GetHashCode();
        }
    }

    public class SomeClass : IParent
    {
        
    }

    public interface IGeneric<T> where T : IParent
    {
        void Add(T item);
    }

    public class Generic<T> : IGeneric<T> where T : IParent
    {
        private List<T> _items = new List<T>(); 
        public void Add(T item)
        {
            _items.Add(item);
        }

        public override string ToString()
        {
            string result = String.Empty;
            foreach (var item in _items)
            {
                result += item.ToString() + Environment.NewLine;
            }
            return result;
        }
    }
}