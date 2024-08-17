using System.Diagnostics.Metrics;
using System.Reflection;

namespace ConsoleAppDZ12

{
    public class Program
    {
        static void Main(string[] args)
        {
            StoreInventorycs<StoreItem> store = new StoreInventorycs<StoreItem>();
            

        Random k = new Random();
            int number1 = 50;
            for (int i = 0; i < number1; i++)
            {
                store.AddTask(new StoreItem(k.NextInt64(1,10000), Math.Round(k.NextDouble() * 1.5 * k.Next(10000), 2)));
            }
            Console.WriteLine("Список товаров");
            store.Print();
            Console.WriteLine("Поиск товара по ID");
            store.Search_ID();
            Console.WriteLine("Изменение цены товара");
            store.Shange_Price();
            store.Print_OrderBy();
            Console.WriteLine("Добавление товара");
            store.Add();
            Console.WriteLine("Сортировка по ID");
            store.Print_OrderBy();
            Console.WriteLine("Сортировка по цене");
            store.Print_OrderBy_Price();
            Console.WriteLine("Удаление товара");
            store.Remove();
            
            
        } 
    }
}
