using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13
{
    public class Vaz : Avto, IEco//Объявляем класс Ваз, который наследует класс  Avto и реализует интерфейс IEco
    {
        public override void Drive()//Переопределяем метод Drive
        {
            model = "vaz2107";
            speed = 70;
            Eco();
        }
        public override void Show()
        {
            Console.WriteLine("Модель {0}, скорость {1}, двигатель {2}", model, speed, dop);//Выводим информацию в консоль

        }
        public void Eco() 
        {
            dop = "экологичный"; //Реализуем интерфейс Eco
        }
    }
}
