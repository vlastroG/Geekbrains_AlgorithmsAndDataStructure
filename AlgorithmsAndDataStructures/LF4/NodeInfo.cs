using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.LF4
{
    /// <summary>
    /// Основная информация об узле дерева
    /// </summary>
    public class NodeInfo
    {
        /// <summary>
        /// Уровень узла в дереве
        /// </summary>
        public int Depth { get; set; }
        /// <summary>
        /// Получает и назначает узел дереву
        /// </summary>
        public TreeNode Node { get; set; }
    }
}
