using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearchThree
{
    public class BeenarySerchThree<T> : IEnumerable<T>, IEnumerable
    {
        private readonly Comparison<T> _comparison;
        private Node<T> _root;

        #region Constructors
        public BeenarySerchThree() : this((Comparison<T>)null) { }

        public BeenarySerchThree(IComparer<T> comparer) : this(comparer.Compare) { }

        public BeenarySerchThree(Comparison<T> comparison)
        {
            _root = null;
            _comparison = comparison ?? Comparer<T>.Default.Compare;
        }
        #endregion

        /// <summary>
        /// Finds the element in the tree
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Contains(T element) => Contains(_root, element);
        /// <summary>
        /// Clears the tree
        /// </summary>
        public void Clear()
        {
            _root = null;
        }

        /// <summary>
        /// Adds an element in the tree
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            _root = AddElement(_root, element);
        }

        /// <summary>
        /// Adds a collection in the tree
        /// </summary>
        /// <param name="coll"></param>
        public void Add(IEnumerable<T> coll)
        {
            if (coll == null)
                throw new ArgumentNullException(nameof(coll));
            foreach (var i in coll)
                Add(i);
        }
        /// <summary>
        /// Preorder traversal
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> PreOrder() => PreOrder(_root);
        /// <summary>
        /// Postorder traversal
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> PostOrder() => PostOrder(_root);
        /// <summary>
        /// Inorder traversal
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> InOrder() => InOrder(_root);

        /// <summary>
        /// Iterator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return InOrder().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #region Private methods
        private Node<T> AddElement(Node<T> node, T x)
        {
            if (node == null)
                return new Node<T>(x);
            var temp = _comparison(x, node.Value);

            if (temp < 0)
                node.Left = AddElement(node.Left, x);
            else if (temp > 0)
                node.Left = AddElement(node.Right, x);

            return node;
        }
        private bool Contains(Node<T> node, T element)
        {
            if (node == null)
                return false;
            var temp = _comparison(node.Value, element);

            if (temp == 0)
                return true;
            else if (temp < 0)
                return Contains(node.Right, element);
            else
                return Contains(node.Left, element);
                    
        }

        private IEnumerable<T> PreOrder(Node<T> node)
        {
            yield return node.Value;

            if (node.Left != null)
                foreach (var e in PreOrder(node.Left))
                    yield return e;

            if (node.Right != null)
                foreach (var e in PreOrder(node.Right))
                    yield return e;
        }

        private IEnumerable<T> InOrder(Node<T> node)
        {
            if (node.Left != null)
                foreach (var e in InOrder(node.Left))
                    yield return e;

            yield return node.Value;

            if (node.Right != null)
                foreach (var e in InOrder(node.Right))
                    yield return e;
        }

        private IEnumerable<T> PostOrder(Node<T> node)
        {
            if (node.Left != null)
                foreach (var e in PostOrder(node.Left))
                    yield return e;

            yield return node.Value;

            if (node.Right != null)
                foreach (var e in PostOrder(node.Right))
                    yield return e;

            yield return node.Value;
        }
        #endregion

    }
}
