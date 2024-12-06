using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pr13_2
{
    public class PremiumTrip : Trip, ICancellable
    {
        double price;
        public PremiumTrip(string startLocation, string endLocation, double distance) : base(startLocation, endLocation, distance)
        {
            CalculateFare();
        }


        public override void Show()
        {
            Console.WriteLine("Поездка из {0} в {1}, дистанцией {2} км, классом Премиум будет стоить {3}", StartLocation, EndLocation, Distance, price);

        }


        public override void CalculateFare()
        {
            int PriceForOneKilometr = 25;

            price = PriceForOneKilometr * Distance;
            
        }


        
    }
}
