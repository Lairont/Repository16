using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// Создать необобщенную колекцию.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //1).Добавить в коллекцию элементы разных типов
            //(положительное целое, строковое, логическое, положительное вещественное, отрицательное целое, отрицательное вещественное).
            ArrayList list = new ArrayList();
            list.Add(11);
            list.Add("Privet");
            list.Add(true);
            list.Add(5.3);
            list.Add(-53);
            list.Add(-9.7);
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            //3).Определить количество элементов списка.
            Console.WriteLine("Кол-во элементов" + list.Count);
            Console.WriteLine();

            //4).Вставить второй элемент со значением строковой величины.
            list.Insert(2, "Mama");
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            //6).Удалить любое положительное число.
            list.Remove(11);
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            //8).Сделать реверс списка и просмотреть его.
            list.Reverse();
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            //9).Занести в список строковый массив из трех элементов.
            string[] twolist = { "Школа", "Яблоко", "Андорей" };
            list.AddRange(twolist);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
