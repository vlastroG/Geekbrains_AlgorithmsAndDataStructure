using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    /// <summary>
    /// Узел дерева
    /// </summary>
    public class TreeNode
    {
        /// <summary>
        /// Значение узла дерева
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Левого потомок узла дерева
        /// </summary>
        public TreeNode LeftChild { get; set; }
        /// <summary>
        /// Правый потомок узла дерева
        /// </summary>
        public TreeNode RightChild { get; set; }
        /// <summary>
        /// Родительский узел дерева
        /// </summary>
        public TreeNode ParentNode { get; set; }
        /// <summary>
        /// Равно ли значение выбранного узла дерева и подаваемого узла? 
        /// </summary>
        /// <param name="obj">Подаваемый узел</param>
        /// <returns>Равно/не равно</returns>       
        public override bool Equals(object obj)
        {
            var node = obj as TreeNode;

            if (node == null)
                return false;

            return node.Value == Value;
        }
    }

}
