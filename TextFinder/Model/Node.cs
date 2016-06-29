using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextFinder.Model
{
    public class Node<T, V>
    {
        public T number;
        public V linkName;
        public T level;
        public List<Node<T, V>> children;
        public Node(T _number, V _linkName, T _level)
        {
            number = _number;
            linkName = _linkName;
            level = _level;
        }
    }
}
