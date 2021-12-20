using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.LF4
{
    /// <summary>
    /// Бинарное дерево
    /// </summary>
    public class BinaryTree : ITree
    {
        /// <summary>
        /// Корень дерева
        /// </summary>
        private TreeNode _root;
        /// <summary>
        /// Добавить узел в дерево
        /// </summary>
        /// <param name="value">Подаваемое значение узла</param>
        public void AddItem(int value)
        {
            TreeNode nodeToAdd = new TreeNode();
            nodeToAdd.Value = value;
            nodeToAdd.LeftChild = null;
            nodeToAdd.RightChild = null;
            TreeNode rootCompare = _root; // узел для сравнения 
            if (_root == null) // если дерево пустое
            {
                _root = nodeToAdd;
                _root.RightChild = null;
                _root.LeftChild = null;
                _root.ParentNode = _root;
                Console.WriteLine($"Узел со значением {nodeToAdd.Value} добавлен");
            }
            else // если дерево содержит 1+ элементов
            {

                while (rootCompare != null)
                {
                    if (rootCompare.Equals(nodeToAdd)) // если подаваемое значение равно значению узла
                    {
                        nodeToAdd.LeftChild = null;
                        nodeToAdd.RightChild = null;
                        Console.WriteLine($"Значение {value} уже существует в дереве.");
                        break;
                    }
                    else if (nodeToAdd.Value < rootCompare.Value) // если подаваемое значение меньше значения узла
                    {

                        if (rootCompare.LeftChild == null)
                        {
                            nodeToAdd.ParentNode = rootCompare;
                            rootCompare.LeftChild = nodeToAdd;
                            Console.WriteLine($"Узел со значением {value} добавлен.");
                            break;
                        }
                        else
                        {
                            rootCompare = rootCompare.LeftChild;
                        }
                    }
                    else // если подаваемое значение больше значения узла
                    {
                        if (rootCompare.RightChild == null)
                        {
                            nodeToAdd.ParentNode = rootCompare;
                            rootCompare.RightChild = nodeToAdd;
                            Console.WriteLine($"Узел со значением {value} добавлен.");
                            break;
                        }
                        else
                        {
                            rootCompare = rootCompare.RightChild;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает узел дерева по его значению.
        /// Если узел с заданным значением отсутствует, будет возвращен корень дерева.
        /// </summary>
        /// <param name="value">Заданное значение узла</param>
        /// <returns>Узел с заданным значением</returns>
        public TreeNode GetNodeByValue(int value)
        {
            TreeNode rootCompare = _root;
            if (_root == null) // если дерево пустое
            {

                Console.WriteLine("Дерево пустое.");
                return GetRoot();
            }
            else // если дерево содержит 1+ элементов
            {

                while (rootCompare != null)
                {
                    if (rootCompare.Value == value) // если подаваемое значение равно значению узла
                    {
                        Console.WriteLine($"Узел со значением {value} возвращен.");
                        return rootCompare;
                    }
                    else if (value < rootCompare.Value) // если подаваемое значение меньше значения узла
                    {

                        rootCompare = rootCompare.LeftChild;
                        if (rootCompare == null)
                        {
                            Console.WriteLine($"В дереве отсутствует значение {value}");

                            return GetRoot();
                        }
                    }
                    else // если подаваемое значение больше значения узла
                    {
                        rootCompare = rootCompare.RightChild;
                        if (rootCompare == null)
                        {
                            Console.WriteLine($"В дереве отсутствует значение {value}");

                            return GetRoot();
                        }
                    }
                }
                return GetRoot();
            }
        }
        /// <summary>
        /// Возвращает корень дерева
        /// </summary>
        /// <returns>Корень дерева</returns>
        public TreeNode GetRoot()
        {
            return _root;
        }
        /// <summary>
        /// Вывод дерева в консоль
        /// </summary>
        public void PrintTree()
        {
            if (_root == null)
            {
                Console.WriteLine("Дерево пустое.");
            }
            else
            {
                PrintTree(_root);
            }
        }
        /// <summary>
        /// Вывод дерева в консоль с заданного узла
        /// </summary>
        /// <param name="startNode">Стартовый узел</param>
        private void PrintTree(TreeNode startNode)
        {
            // Ссылки на потомков узлов правильные, но оформление вывода корявое

            TreeNode currentNode = startNode;

            if (currentNode != null)
            {

                Console.Write("\t");

                Console.Write($"[{currentNode.Value}]");
                if (currentNode.LeftChild != null)
                {
                    Console.Write($"[L={currentNode.LeftChild.Value}]"); //значение левого узла
                }
                if (currentNode.RightChild != null)
                {
                    Console.Write($"[R={ currentNode.RightChild.Value}]"); //значение правого узла
                }

                PrintTree(currentNode.RightChild);

                PrintTree(currentNode.LeftChild);
            }
            else
            {
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Удаляет узел из дерева по заданному значению
        /// </summary>
        /// <param name="value">Значение удаляемого узла</param>
        public void RemoveItem(int value)
        {
            TreeNode nodeToDelete = GetNodeByValue(value);
            if (_root == null)
            {
                Console.WriteLine("Невозможно удалить элемент из пустого дерева.");
            }
            else if (nodeToDelete == _root) // если удаляется корень
            {
                if ((_root.RightChild == null) && (_root.LeftChild == null)) // если в дереве только 1 элемент
                {
                    _root = null;
                }
                else if (_root.LeftChild == null) // если нет левого узла
                {
                    _root = _root.RightChild;
                }
                else if (_root.RightChild == null) // если нет правого узла
                {
                    _root = _root.LeftChild;
                }
                else if ((_root.LeftChild != null) && (_root.RightChild != null)) // если есть оба предковых узла
                {
                    TreeNode node = _root.RightChild;
                    while (node.LeftChild != null)
                    {
                        node = node.LeftChild;
                    }
                    node.LeftChild = _root.LeftChild;
                    _root = _root.RightChild;
                }
                Console.WriteLine($"Корень со значением {value} удален.");
            }
            else // если удаляется не корень
            {
                TreeNode parentNode = nodeToDelete.ParentNode;
                if ((nodeToDelete.LeftChild == null) && (nodeToDelete.RightChild == null)) // если удаляется лист дерева
                {
                    // Console.WriteLine($"Значение родительского узла = {nodeToDelete.ParentNode.Value}" ); 
                    if (nodeToDelete.Value > parentNode.Value) // усли удаляемый узел - правый
                    {
                        nodeToDelete.ParentNode.RightChild = null;
                    }
                    else // если удаляемый узел - левый
                    {
                        nodeToDelete.ParentNode.LeftChild = null;
                    }

                    Console.WriteLine($"Лист дерева со значением {value} удален.");
                }
                else if (nodeToDelete.LeftChild == null) // если нет левого узла
                {
                    if (nodeToDelete.Value > parentNode.Value) // усли удаляемый узел - правый
                    {
                        parentNode.RightChild = nodeToDelete.RightChild;
                    }
                    else // если удаляемый узел - левый
                    {
                        parentNode.LeftChild = nodeToDelete.RightChild;
                    }
                    Console.WriteLine($"Узел дерева со значением {value} без левого листа удален.");
                }
                else if (nodeToDelete.RightChild == null) // если нет правого узла
                {
                    if (nodeToDelete.Value > parentNode.Value) // если удаляемый узел - правый
                    {
                        parentNode.RightChild = nodeToDelete.LeftChild;
                    }
                    else // если удаляемый узел - левый
                    {
                        parentNode.LeftChild = nodeToDelete.LeftChild;
                    }
                    Console.WriteLine($"Узел дерева со значением {value} без правого листа удален.");
                }
                else if ((nodeToDelete.LeftChild != null) && (nodeToDelete.RightChild != null)) // если есть оба предковых узла
                {
                    TreeNode node;
                    node = nodeToDelete.RightChild;
                    while (node.LeftChild != null)
                    {
                        node = node.LeftChild;
                    }
                    node.LeftChild = nodeToDelete.LeftChild;

                    if (nodeToDelete.Value < parentNode.Value) // если удаляемый узел - левый
                    {
                        parentNode.LeftChild = nodeToDelete.RightChild;
                    }
                    else // если удаляемый узел - правый
                    {
                        parentNode.RightChild = nodeToDelete.RightChild;
                    }
                    Console.WriteLine($"Узел дерева со значением {value} с обоими листами удален.");
                }
            }
        }
    }
}
