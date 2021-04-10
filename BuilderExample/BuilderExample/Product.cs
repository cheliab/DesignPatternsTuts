using System.Collections.Generic;

namespace BuilderExample
{
    /// <summary>
    /// Продукт который мы хотим создать
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Части продукта
        /// </summary>
        private List<object> _parts = new List<object>();

        /// <summary>
        /// Добавляем какие-то элементы в продукт 
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            _parts.Add(part);
        }

        /// <summary>
        /// Выводим результат готового продукта
        /// </summary>
        /// <returns></returns>
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < _parts.Count; i++)
            {
                str += _parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // Удаляем последнюю точку с запятой

            return "Product parts: " + str + "\n";
        }
    }
}