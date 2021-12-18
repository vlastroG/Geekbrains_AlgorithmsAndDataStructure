using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.LF4
{
    public class Lesson4 : ILesson
    {
        public string Name => "lesson4";

        public string Description => "Деревья и хэш-таблицы";

        public void Demo()
        {
            // Реализуйте класс двоичного дерева поиска с операциями вставки, удаления, поиска.
            // Также напишите метод вывода в консоль дерева,
            // чтобы увидеть, насколько корректно работает ваша реализация.
            Console.WriteLine("lesson 4 homework");
            BinaryTree tree = new BinaryTree();
            tree.PrintTree();

            tree.RemoveItem(10);
            
            tree.AddItem(10);
            tree.AddItem(10);


            tree.AddItem(20);
            tree.AddItem(7);
            tree.AddItem(11);
            tree.AddItem(12);
            tree.AddItem(7);
            tree.AddItem(12);
            tree.AddItem(1);
            tree.AddItem(-5);
            tree.AddItem(8);
            tree.AddItem(21);
            tree.AddItem(19);

            tree.GetNodeByValue(19);
            tree.GetNodeByValue(100500);
            int n = 40;
            tree.PrintTree();
            tree.RemoveItem(10);
            Console.WriteLine(new string('=', n));
            tree.PrintTree();
            Console.WriteLine(new string('=', n));
            tree.RemoveItem(8);
            tree.PrintTree();
            Console.WriteLine(new string('=', n));
            tree.RemoveItem(12);
            tree.PrintTree();
            Console.WriteLine(new string('=', n));
            tree.RemoveItem(11);
            tree.PrintTree();
            Console.WriteLine(new string('=', n));
            tree.RemoveItem(1);
            tree.PrintTree();
        }
    }
}
