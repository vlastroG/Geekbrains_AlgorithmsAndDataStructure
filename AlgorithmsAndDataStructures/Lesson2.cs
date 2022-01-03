using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmsAndDataStructures.NodeList;

namespace AlgorithmsAndDataStructures
{
    public class Lesson2 : ILesson
    {
        /// <summary>
        /// Название, которое нужно ввести для старта выполнения дз.
        /// </summary>
        public string Name => "lesson2";
        /// <summary>
        /// Краткое описание урока
        /// </summary>
        public string Description => "2. Реализация типа двусвязного списка.";
        /// <summary>
        /// Тест работы типа двусвязного списка.
        /// </summary>
        public static void testNodeList()
        {
            NodeList myList = new NodeList();

            myList.AddNode(1);
            myList.AddNode(2);

            myList.PrintList();

            myList.RemoveNode(0);

            myList.PrintList();

            myList.RemoveNode(0);

            myList.PrintList();

            myList.RemoveNode(0);

            myList.AddNode(10);

            myList.AddNodeAfter(myList.FindNodeByNumber(0), 100500);
            myList.PrintList();
            myList.AddNodeAfter(myList.FindNodeByNumber(0), 200500);
            myList.PrintList();

            myList.GetCount();

            myList.RemoveNode(1);
            myList.RemoveNode(1);

            myList.PrintList();

            myList.FindNode(10);

            myList.AddNode(90);

            myList.RemoveNode(myList.FindNode(900));

            myList.RemoveNode(90);

            myList.PrintList();

            myList.GetCount();

            myList.FindNode(90);

            myList.PrintList();
        }
        /// <summary>
        /// Функция демонстрации выполнения задания
        /// </summary>
        public void Demo()
        {
            testNodeList();
        }
    }
}
