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
        /// Длина двусвязанного списка
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Добавляет новый узел в двусвязанный список
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (tail == null)
            {
                head = newNode;
            }
            else
            {
                newNode.PrevNode = tail;
                tail.NextNode = newNode;
            }
            tail = newNode;
            Length++;

        }

        /// <summary>
        /// Добавляет новый элемент списка после определённого элемента
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddNodeAfter(Node node, int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            newNode.PrevNode = node;

            // Если заданный нод - хвост
            if (tail == node)
            {
                node.NextNode = newNode;
                tail = newNode;
            }
            // Если заданный нод в середине списка
            else
            {
                node.NextNode.PrevNode = newNode;
                newNode.NextNode = node.NextNode;
                node.NextNode = newNode;
            }

            Length++;
        }

        /// <summary>
        /// Ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public Node FindNode(int searchValue)
        {
            Node currentNode = head;
            while (currentNode.Value != searchValue)
            {
                currentNode = currentNode.NextNode;
                if (currentNode.NextNode == null)
                {
                    Console.WriteLine($"В списке отсутствует элемент со значением {searchValue}");
                    break;
                }
            }
            return currentNode;
        }

        /// <summary>
        /// Возвращает количество элементов в списке
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return Length;
        }

        /// <summary>
        /// Удаляет элемент по порядковому номеру
        /// </summary>
        /// <param name="index"></param>
        public void RemoveNode(int index)
        {
            if (index > Length) // обработка, если index вне диапазона номеров элементов списка
            {
                Console.WriteLine($"В списке отсутствует элемент с номером {index}");
            }

            else if ((index == 0) && (Length == 1)) // Обработка удаления единственного элемента
            {
                Console.WriteLine("Последний элемент списка удален.");
                head = null;
                tail = null;
                Length--;
            }

            else if ((index + 1 <= Length) && (Length > 1)) // Обработка, если удаляемый элемент в списке из 2+ элементов
            {
                int number = 0;
                Node nodeToDelete = head;
                while (number != index)
                {
                    nodeToDelete = nodeToDelete.NextNode;
                    number++;
                }
                if (nodeToDelete == head)
                {
                    nodeToDelete.NextNode.PrevNode = null;
                    head = nodeToDelete.NextNode;
                }
                else if (nodeToDelete == tail)
                {
                    nodeToDelete.PrevNode.NextNode = null;
                    tail = nodeToDelete.PrevNode;
                }
                else 
                {
                    nodeToDelete.PrevNode.NextNode = nodeToDelete.NextNode;
                    nodeToDelete.NextNode.PrevNode = nodeToDelete.PrevNode;
                }

                Length--;
            }

        }

        /// <summary>
        /// Удаляет указанный элемент
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNode(Node node)
        {
            Node nodeToDelete = node;
            if (nodeToDelete == head) // здесь обработка, если удаляется голова
            {
                head = nodeToDelete.NextNode;
                if (head == null) // здесь обработка, если в поданном списке 1 элемент
                {
                    tail = null;
                    Console.WriteLine("Последний элемент списка удален.");
                }

                if (Length == 1) // здесь обработка, если остался 1 элемент в списке
                {
                    tail = nodeToDelete.NextNode;
                }
            }
            else if (nodeToDelete == tail) // здесь идет обработка, если удаляется хвост и элементов в поданном списке >= 2
            {
                nodeToDelete.PrevNode.NextNode = null;
                tail = nodeToDelete.PrevNode;
            }
            else // здесь идет обработка, если удаляется средний элемент списка и элементов в поданном списке >= 3
            {
                nodeToDelete.PrevNode.NextNode = nodeToDelete.NextNode;
                nodeToDelete.NextNode.PrevNode = nodeToDelete.PrevNode;
            }

            Length--;
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
                list += $"{current.Value}_";
                current = current.NextNode;
            }

            Console.WriteLine(list);
        }
    }
}
