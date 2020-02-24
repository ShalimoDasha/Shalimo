using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Меню:\n1) N1 задание \n2) Выйти \n\nЧто выберем: ");
            int i2 = int.Parse(Console.ReadLine());
            switch (i2)
            {
                case 1:
                    {
                        Console.Clear();
                        product();
                        break;
                    }
                case 2:
                    Console.WriteLine("До новых встреч...");
                    break;
                default:
                    Console.WriteLine("Нито...");
                    break;
            }


        }
        static void product()
        {
            int i;
            produkt prod = null;
            do
            {
                Console.Write("Меню:\n1) Создать новый продукт \n2) Установить атрибуты текущего продукта \n3) Вывести информацию о продуктах \n4) Вернуться \n\nЧто выберем: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    
                }
               
        }
    }

}
