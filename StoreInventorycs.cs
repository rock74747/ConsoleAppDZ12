using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ12
{
    public class StoreInventorycs<T> where T : IStoreItem
    {
        public List<StoreItem> list = new List<StoreItem> { };


        public void AddTask(StoreItem task) {
            try
            {
                var number = list.Any(x => x.ItemId == task.ItemId);
                    if (number)
                    {
                        throw new InvalidContactException($"Товар с данным индексом уже существует");
                    }
                else
                      list.Add(task);
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
           }
        public void Add()                                        // Добавление товара в коллекцию
        {
            Console.WriteLine("Введите ID товара ->");
            long IDnumber = (long)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите цену товара ->");
            double cost = Convert.ToDouble(Console.ReadLine());
            var costID = Math.Round(cost, 2);
            var number = list.Any(x => x.ItemId == IDnumber);
            try
            {
                if (number)
                {
                    throw new InvalidContactException($"Товар с данным индексом уже существует");
                }
                else
                    list.Add(new StoreItem(IDnumber, costID));
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        
        public void Print()                 // Вывод
        {
            foreach (var item in list)
            {
                Console.WriteLine($" Id товара = {item.ItemId}, цена = {item.Price} руб.");
            }
        }

        public void Remove()                                        // Удаление товара из коллекции
        {
            Console.WriteLine("Введите ID товара ->");
            long IDnumber = (long)Convert.ToInt64(Console.ReadLine());
            var number = list.Any(x => x.ItemId == IDnumber);
            try
            {
                if (!number)
                {
                    throw new InvalidContactException($"Товар с данным индексом не существует");
                }
                else
                    list.RemoveAll(x => x.ItemId == IDnumber);
                Console.WriteLine("Товар удален из коллекции");
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        public void Print_OrderBy()    //Сортировка по ItemId
        {
            var new_list = list.OrderBy(p => p.ItemId);
            foreach (var item in new_list)
            {
                Console.WriteLine($" Id товара = {item.ItemId}, цена = {item.Price} руб.");
            }
        }
        public void Print_OrderBy_Price() //Сортировка по цене
        {
            var new_list = list.OrderBy(p => p.Price);
            foreach (var item in new_list)
            {
                Console.WriteLine($" Id товара = {item.ItemId}, цена = {item.Price} руб.");
            }
        }
        public void Search_ID()                                        // Поиск по ID
        {
            Console.WriteLine("Введите ID товара ->");
            long IDnumber = (long)Convert.ToInt64(Console.ReadLine());
            bool number = list.Any(x => x.ItemId == IDnumber);
            try
            {
                if (!number)
                {
                    throw new InvalidContactException($"Товар с данным индексом не существует");
                }
                else
                {
                    var new_list = list.Where(x => x.ItemId == IDnumber);
                    foreach (var item in new_list)
                    {
                        Console.WriteLine($" Id товара = {item.ItemId}, цена = {item.Price} руб.");
                    }
                }
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void Shange_Price()                                        // Изменение цены товара
        {
            Console.WriteLine("Введите ID товара ->");
            long IDnumber = (long)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите новую цену товара ->");
            double cost = Convert.ToDouble(Console.ReadLine());
            var costID = Math.Round(cost, 2);
            var number = list.Any(x => x.ItemId == IDnumber);
            try
            {
                if (!number)
                {
                    throw new InvalidContactException($"Товар с данным индексом не существует");
                }
                else
                {
                    list.RemoveAll(x => x.ItemId == IDnumber);
                    list.Add(new StoreItem(IDnumber, costID));
                    Console.WriteLine("Цена товара изменена!");
                }
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

    }
}
