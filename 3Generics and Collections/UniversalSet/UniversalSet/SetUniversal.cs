using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UniversalSet
{
    public class SetUniversal<T> : IEnumerable<T>
    {
        private readonly List<T> container;
        private IEnumerable<T> enumerable;

        public int Count => container.Count;
        #region Constructors
        /// <summary>
        /// Constructor without param
        /// </summary>
        public SetUniversal() { }
        /// <summary>
        /// Constructor for Set
        /// </summary>
        public SetUniversal(T item)
        {
            container.Add(item);
        }
        public SetUniversal(List<T> list)
        {
            if (list.Count == 0)
                throw new ArgumentNullException(nameof(list));

            container = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                container[i] = list[i];
            }
        }
        public SetUniversal(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Add operstion
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (container.Contains(item))
                return;
            else
                container.Add(item);
        }
        /// <summary>
        /// Remove operation
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            container.Remove(item);
        }
        /// <summary>
        /// Union operation
        /// </summary>
        /// <param name="otherSet"></param>
        /// <returns></returns>
        public SetUniversal<T> Union(SetUniversal<T> otherSet)
        {
            //return new SetUniversal<T>(container.Union(otherSet));

            var result = new SetUniversal<T>();

            foreach (var item in container)
                result.Add(item);

            foreach (var item in otherSet.container)
                result.Add(item);

            return result;
        }
        /// <summary>
        /// Intersection operation
        /// </summary>
        /// <param name="otherSet"></param>
        /// <returns></returns>
        public SetUniversal<T> Intersection(SetUniversal<T> otherSet)
        {
            //return new SetUniversal<T>(container.Intersect(otherSet));

            var result = new SetUniversal<T>();
            SetUniversal<T> big;
            SetUniversal<T> small;

            if(Count > otherSet.Count)
            {
                big = this;
                small = otherSet;
            }
            else
            {
                big = otherSet;
                small = this;
            }

            foreach(var item1 in small.container)
            {
                foreach(var item2 in big.container)
                {
                    if (item1.Equals(item2))
                        result.Add(item1);
                    break;
                }
            }

            return result;
        }
        /// <summary>
        /// Difference operation
        /// </summary>
        /// <param name="otherSet"></param>
        /// <returns></returns>
        public SetUniversal<T> Difference(SetUniversal<T> otherSet)
        {
            //return new SetUniversal<T>(container.Except(otherSet.container));

            var result = new SetUniversal<T>(container);

            foreach (var item in otherSet.container)
                result.Remove(item);

            return result;
        }
        /// <summary>
        /// Subset operation
        /// </summary>
        /// <param name="otherSet"></param>
        /// <returns></returns>
        public bool Subset(SetUniversal<T> otherSet)
        {
            //return otherSet.container.All(i => container.Contains(i));

            foreach (var item1 in otherSet.container)
            {
                var equals = false;

                foreach(var item2 in container)
                {
                    if (item1.Equals(item2))
                    {
                        equals = true;
                        break;
                    }
                }
                if (!equals)
                    return false;
            }

            return true;
        }
#endregion
        /// <summary>
        /// Indexator
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get { return container[index]; }
            set { container[index] = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < container.Count; i++)
                yield return container[i];
        }

        public IEnumerable<T> ReverseMethod()
        {
            for (var i = container.Count - 1; i >= 0; i--)
                yield return container[i];
        }

        
        public IEnumerable<T> ReverseProperty
        {
            get
            {
                for (var i = container.Count - 1; i >= 0; i--)
                    yield return container[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)container).GetEnumerator();
        }
    }
}
