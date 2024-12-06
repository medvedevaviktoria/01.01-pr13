using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13_2
{
    public abstract class Trip
    {
        //Объявляем переменные
        private string startLocation;
        private string endLocation;
        private double distance;

        protected string StartLocation { get => startLocation; set => startLocation = value; }
        protected string EndLocation { get => endLocation; set => endLocation = value; }
        protected double Distance { get => distance; set => distance = value; }

        public  Trip(string startLocation, string endLocation, double distance)
        {
            this.StartLocation = startLocation;
            this.EndLocation = endLocation;
            this.Distance = distance;
            
        }

        public abstract void CalculateFare();//Объявляем абстрактный метод CalculateFare

        public abstract void Show();

    }
}
