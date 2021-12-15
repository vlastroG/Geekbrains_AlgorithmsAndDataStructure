using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    /// <summary>
    /// Общий интерфейс урока
    /// </summary>
    interface ILesson
    {
        /// <summary>
        /// Код урока
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Описание урока
        /// </summary>
        string Description { get; }
        
        /// <summary>
        /// Вывод тестовых данных
        /// </summary>
        void Demo();
    }
}
