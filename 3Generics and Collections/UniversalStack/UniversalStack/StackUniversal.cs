using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversalStack
{
    public class StackUniversal<T>
    {
        private readonly List<T> list;
        private int count;

        public int Count => count;

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public StackUniversal()
        {
            list = new List<T>();
            count = 0;
        }
        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        /// <summary>
        /// Method for adding element to the stack
        /// </summary>
        /// <param name="item">Element to add</param>
        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var item = list.LastOrDefault();
                list.Remove(item);
                return item;
            }
            else
                throw new NullReferenceException("Stack is empty.");
        }
        /// <summary>
        /// Method for returning the object at the beginning of the stack
        /// </summary>
        /// <returns>The object at the beginning of the stack</returns>
        public T Peek()
        {
            if (Count > 0)
            {
                return list.LastOrDefault(); 
            }
            else
                throw new NullReferenceException("Stack is empty.");
        }
        /// <summary>
        /// Returns an enumerator that iterates through the stack
        /// </summary>
        /// <returns>Instance of structure for iterating</returns>
        public CustomIterator GetEnumerator()
        {
            return new CustomIterator(this);
        }
        /// <summary>
        /// Struct that contains methods for supporting <see langword="foreach"/> operator
        /// </summary>
        public struct CustomIterator
        {
            private readonly StackUniversal<T> stack;
            private int currentIndex;

            public CustomIterator(StackUniversal<T> collection)
            {
                currentIndex = -1;
                stack = collection;
            }
            /// <summary>
            /// Gets the element in the stack at the current position of the enumerator
            /// </summary>
            public T Current
            {
                get
                {
                    if (currentIndex == -1 || currentIndex == stack.Count)
                    {
                        throw new InvalidOperationException();
                    }

                    return stack[currentIndex];
                }

            }
            /// <summary>
            /// Sets the enumerator to its initial position, which is before the first element in the collection
            /// </summary>
            public void Reset() => currentIndex = -1;

            /// <summary>
            /// Advances the enumerator to the next element of the stack
            /// </summary>
            /// <returns>True if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the stack</returns>
            public bool MoveNext()
            {
                return ++currentIndex < stack.Count;
            }

        }
    }
}
