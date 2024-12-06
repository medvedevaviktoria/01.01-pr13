using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13
{
     class Program
    {
        static void Main()
        {
            Avto myAvto = GetAvto();//Создание объекта myAvto
            myAvto.Drive();//Вызов методов
            myAvto.Show();
            Console.ReadKey();//Реализуем задержку
        }

        static Avto GetAvto() //Реализуем метод выбора автомобиля
        {
            Console.Write("Введите марку автомобиля (Vaz, Maz,BMW): ");
            string mod = Console.ReadLine(); //ввод пользователя
            switch (mod)
            {
                case "Vaz": case "vaz": return new Vaz();
                case "Maz": case "maz": return new Maz();
                case "BMW": case "bmw": return new BMW();
                default: return new Maz();

            }

        }
    }
}
