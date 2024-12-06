using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pr13_2
{
    internal class StandardTrip : Trip, ICancellable
    {
        public override void Tripping()
        {
        }

        public override void Show()
        {
            Console.WriteLine("Поездка из {0} в {1}, дистанцией {2} км, классом Стандарт будет стоить {3}", startLocation, endLocation, distance);
        }

        public override void CalculateFare()
        {
            int PriceForOneKilometr = 10;

            Cancel();
        }

        public void Cancel()
        { 
            
        }
    }
}
