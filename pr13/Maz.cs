using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13
{
    public class Maz : Avto, ITurbo//Объявляем класс Маз, который наследует класс  Avto и реализует интерфейс Турбо
    {
        public override void Drive() //Переопределяем метод Drive
        {
            model = "Maz200";
            speed = 90;
            Turbo();
        }
        public override void Show()
        {
            Console.WriteLine("Модель {0}, скорость {1}, двигатель {2}", model, speed, dop);//Выводим информацию в консоль

        }

        public void Turbo() 
        {
            dop = "турбо"; //Реализуем интерфейс Turbo
        }
    }
}
