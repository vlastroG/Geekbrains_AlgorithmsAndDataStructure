namespace AlgorithmsAndDataStructures
{
    /// <summary>
    /// Класс элемента узла для связанного списка
    /// Инициализирует значение (int), ссылку на предыдущий и последующий узел
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Получает и назначает значение узла
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Получает и назначает ссылку на последующий узел
        /// </summary>
        public Node NextNode { get; set; }

        /// <summary>
        /// Получает и назначает ссылку на предыдущий узел
        /// </summary>
        public Node PrevNode { get; set; }
    }

}
