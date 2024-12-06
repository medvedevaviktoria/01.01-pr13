using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Pr13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trip myTrip = GetTrip();
            
        }

        static Trip GetTrip()
        {
            string[] StartLocation = { "Санкт-Петербург", "Санкт-Петербург", "Санкт-Петербург", "Москва", "Москва", "Санкт-Петербург" };
            string[] EndLocation = { "Москва", "Рязань", "Самара", "Екатеринбург", "Омск", "Анапа" };
            int[] Distance = { 800, 1500, 1120, 400, 930, 340 };
            Console.WriteLine("Система учета поездок\nЗдравствуйте! Выберите каким классом вы хотите ехать:\n1.Премиальный\n2.Стандартный");
            string Tarif = Console.ReadLine(); //ввод пользователя
            switch (Tarif)
            {
                case "1": case "Премиальный":
                    {
                        Console.WriteLine("Выберите направление:");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine(i + 1 + ". " + StartLocation[i] + " - " + EndLocation[i] + ". Дистанция: " + Distance[i]);
                        }
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1": return new PremiumTrip(StartLocation[0], EndLocation[0], Distance[0]);
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                            default: 
                        }
                        
                    }
                case "2": case "Стандартный": return new StandardTrip() ;
                default: return new StandardTrip();
            }
        }
    }
}


//string[] StartLocation = { "Санкт-Петербург", "2.Санкт-Петербург - Рязань. Дистанция: 1500 км.",
//             "3.Санкт-Петербург - Самара. Дистанция: 1120 км.","4.Москва - Екатеринбург.    Дистанция: 400 км.","5.Москва - Омск.            Дистанция: 930 км.",
//             "6.Санкт-Петербург - Анапа.  Дистанция: 340 км.",
//            };