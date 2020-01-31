using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();
            bst.Insert(100);
            bst.Insert(75);
            bst.Insert(55);
            bst.Insert(125);
            bst.Insert(110);
            bst.Insert(105);
            bst.Insert(90);
            bst.Insert(45);
            bst.Search(105);
        }
    }
}
