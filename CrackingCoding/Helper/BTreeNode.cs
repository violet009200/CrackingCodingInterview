using System;
using System.Diagnostics;

namespace Helper
{
    [DebuggerDisplay("Data = {Data}, Left = {Left?.Data}, Right = {Right?.Data}")]
    public class BTreeNode<T> where T : IEquatable<T>
    {
        public T Data { get; set; }
        public BTreeNode<T> Left { get; set; }
        public BTreeNode<T> Right { get; set; }

        public BTreeNode(T data)
        {
            Data = data;
        }

        public BTreeNode(T data, BTreeNode<T> left, BTreeNode<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

    }
}
