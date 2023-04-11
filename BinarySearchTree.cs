using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinaryTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T Data { get; set; }

        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T Data)
        {
            this.Data = Data;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0;
        int rightCount = 0;
        bool result = false;


        public void Add(T item)
        {
            T currentValue = this.Data;
            if (currentValue.CompareTo(item) > 0)
            {
                if (LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else { this.LeftTree.Add(item); }
            }

            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                    this.RightTree.Add(item);
            }
        }


        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.Data.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        //SIZE
        public void Size()
        {
            Console.WriteLine("Size" + " " + (7 * (this.leftCount + this.rightCount) - 1));
        }

        //CHECK EXIST OR NOT (SEARCH)
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.Data.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.Data);
                return true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.Data);
            }
            if (element.CompareTo(node.Data) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.Data) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;

        }
    }
}
