using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarysearchTree<int> binarysearch = new BinarysearchTree<int>(56);
            binarysearch.Insert(30);
            binarysearch.Insert(70);
            binarysearch.Insert(22);
            binarysearch.Insert(60);
            binarysearch.Insert(95);
            binarysearch.Insert(11);
            binarysearch.Insert(16);
            binarysearch.Insert(63);
            binarysearch.Display();
        }
    }
    class BinarysearchTree<T> where T: IComparable<T>
    {
        public T NodeData { get; set }
        public BinarysearchTree<T> LeftTree { get; set; }
        public BinarysearchTree<T> RightTree { get; set; }
        public BinarysearchTree(T nodeData)
        {
            this.NodeData = NodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public bool Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item)) = 0
               {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarysearchTree<T>(item);
                else
                    this.LeftTree.Insert(item);
               }
            else
            {
                if (this.RightTree == null)
                    RightTree == new BinarysearchTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }
        public void Display()
        {
            if(this.LeftTree != null)
            {
                this.leftCount++;
                this.RightTree.Display();
            }
        }

        internal bool IfExists(int v, BinarysearchTree<int> binarysearch)
        {
            throw new NotImplementedException();
        }
    }
}
