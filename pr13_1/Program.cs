using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13_1
{
     class Program
    {
        static void Main()
        {
            CompInv<AutoShop> cp = new CompInv<AutoShop>();
            List<AutoShop> dic = new List<AutoShop>();

            dic.Add(new AutoShop("Toyota Corolla", 180, 300000, 5, 1));
            dic.Add(new AutoShop("VAZ 2114i", 160, 220000, 0, 2));
            dic.Add(new AutoShop("Daewoo Nexia", 140, 260000, 5, 3));
            dic.Add(new AutoShop("Honda Torneo", 220, 400000, 7, 4));
            dic.Add(new AutoShop("Audi R8 Best", 360, 42000000, 3, 5));



            Console.WriteLine("Исходный каталог автомобилей: \n");
            Console.WindowWidth = 100;
            foreach (AutoShop a in dic) 
                Console.WriteLine(a);

            Console.WriteLine("\nТеперь автомобили отсортированны по стоимости: \n");
            dic.Sort(cp);
            foreach (AutoShop a in dic)
                Console.WriteLine(a);

            Console.ReadLine();

        }
    }
}
