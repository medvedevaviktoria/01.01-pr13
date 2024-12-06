using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13
{
    public class BMW : Avto, IEco,ITurbo//Объявляем класс BMW, который наследует класс  Avto и реализует интерфейс IEco
    {
        public override void Drive()//Переопределяем метод Drive
        {
            model = "BMW16x";
            speed = 120;
            Turbo();
            Eco();
        }
        public override void Show()
        {
            Console.WriteLine("Модель {0}, скорость {1}, первый двигатель {2}, второй двигатель {3}", model, speed, dop,dop1);//Выводим информацию в консоль

        }
        public void Turbo()
        {
            dop = "турбо"; //Реализуем интерфейс Turbo
        }
        public void Eco()
        {
            dop1 = "экологичный"; //Реализуем интерфейс Turbo
        }
    }
}
