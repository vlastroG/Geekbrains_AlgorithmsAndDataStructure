using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsAndDataStructures.LF4;

namespace AlgorithmsAndDataStructures.LF5
{
    /// <summary>
    /// Дз к уроку 5. Стек, очередь.
    /// </summary>
    public class Lesson5 : ILesson
    {
        /// <summary>
        /// Название, которое нужно ввести для старта выполнения дз.
        /// </summary>
        public string Name => "lesson5";
        /// <summary>
        /// Краткое описание урока
        /// </summary>
        public string Description => "5. Вертикальный и горизонтальный поиск по дереву. Стек, очередь.";
        /// <summary>
        /// Функция демонстрации выполнения задания
        /// </summary>
        public void Demo()
        {

            BinaryTree treeToSearch = new BinaryTree();
            treeToSearch.GetNodeByValueBreadth(3);
            treeToSearch.GetNodeByValueDeep(-2);
            int[] arrOfInt = { 8, 4, 12, 2, 5, 9, 14, 3, 7, 10, 11, 1, -2, 13, 15, 0, -1, 16 };
            foreach (var item in arrOfInt)
            {
                treeToSearch.AddItem(item);
            }
            treeToSearch.PrintTree();
            treeToSearch.GetNodeByValueBreadth(3);
            treeToSearch.GetNodeByValueBreadth(300);
            treeToSearch.GetNodeByValueDeep(-2);
            treeToSearch.GetNodeByValueDeep(-200);
        }

    }
}
