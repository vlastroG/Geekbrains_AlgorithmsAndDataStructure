using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    /// <summary>
    /// Реализация типа двусвуязанного списка
    /// </summary>
    class NodeList : ILinkedList
    {
        /// <summary>
        /// Голова двусвязанного списка
        /// </summary>
        private Node head;

        /// <summary>
        /// Хвост двусвязанного списка
        /// </summary>
        private Node tail;

        /// <summary>
        /// Добавляет новый узел в двусвязанный список
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Добавляет новый элемент списка после определённого элемента
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public Node FindNode(int searchValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Возвращает количество элементов в списке
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаляет элемент по порядковому номеру
        /// </summary>
        /// <param name="index"></param>
        public void RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаляет указанный элемент
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Вывод двусвязанного списка в консоль
        /// </summary>
        public void PrintList()
        {
            string list = "";
            Node current = head;
            while (current != null)
            {
                list += $"{current.Value}";
                current = current.NextNode;
            }

            Console.WriteLine(list);
        }
    }
}
