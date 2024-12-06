using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13
{
    public abstract class Avto
    {
        protected string dop;//Объявляем переменные
        protected string dop1;//Объявляем переменные
        protected string model;//Объявляем переменные
        protected int speed;//Объявляем переменные

        public abstract void Drive();//Объявляем абстрактный метод Drive

        public abstract void Show();//Объявляем обычный метод Show

       
    }

}
