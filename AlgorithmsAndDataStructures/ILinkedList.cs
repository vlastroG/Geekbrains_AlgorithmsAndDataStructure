using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    /// <summary>
    /// Интерфейс для двусвязанного списка
    /// </summary>
    interface ILinkedList
    {
        /// <summary>
        /// Возвращает количество элементов в списке
        /// </summary>
        /// <returns>Количество элементов</returns>
        int GetCount();

        /// <summary>
        /// Добавляет новый элемент списка
        /// </summary>
        /// <param name="value"></param>
        void AddNode(int value);

        /// <summary>
        /// Добавляет новый элемент списка после определенного элемента
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        void AddNodeAfter(Node node, int value);

        /// <summary>
        /// Удаляет элемент по порядковому номеру
        /// </summary>
        /// <param name="index"></param>
        void RemoveNode(int index); // удаляет элемент по порядковому номеру

        /// <summary>
        /// Удаляет указанный элемент
        /// </summary>
        /// <param name="node"></param>
        void RemoveNode(Node node);

        /// <summary>
        /// Ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns>Порядковый номер узла</returns>
        Node FindNode(int searchValue);
    }
}
