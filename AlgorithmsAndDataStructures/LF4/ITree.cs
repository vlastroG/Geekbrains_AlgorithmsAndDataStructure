using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    public interface ITree
    {
        /// <summary>
        /// Возвращает корень дерева
        /// </summary>
        /// <returns>Корень дерева</returns>
        TreeNode GetRoot();
        /// <summary>
        /// Добавляет узел в дерево
        /// </summary>
        /// <param name="value">Значение узла</param>
        void AddItem(int value);
        /// <summary>
        /// Удаляет узел дерева по значению
        /// </summary>
        /// <param name="value">Значение узла</param>
        void RemoveItem(int value);
        /// <summary>
        /// Получить узел дерева по значению
        /// </summary>
        /// <param name="value">Значение узла дерева</param>
        /// <returns>Узел дерева</returns>
        TreeNode GetNodeByValue(int value);
        /// <summary>
        /// Вывести дерево в консоль
        /// </summary>
        void PrintTree();
    }
}
