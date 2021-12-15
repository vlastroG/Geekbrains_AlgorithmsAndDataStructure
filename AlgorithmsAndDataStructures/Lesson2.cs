using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmsAndDataStructures.NodeList;

namespace AlgorithmsAndDataStructures
{
    public class Lesson2
    {
        public static void testNodeList()
        {
            NodeList myList = new NodeList();

            myList.AddNode(1);
            myList.AddNode(2);

            myList.PrintList();

            myList.RemoveNode(0);

            myList.PrintList();
        }
    }
}
