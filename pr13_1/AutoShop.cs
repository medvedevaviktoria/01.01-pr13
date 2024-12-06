using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13_1
{
    internal class AutoShop
    {
        public string CarName { set; get; }
        public int MaxSpeed { get; set; }
        public double Cost { get; set; }
        public byte Discount { get; set; }
        public int ID { get; set; }

        public AutoShop() { }

        public AutoShop(string carName, int maxSpeed, double cost, byte discount, int iD)
        {
            this.CarName = carName;
            this.MaxSpeed = maxSpeed;
            this.Cost = cost;
            this.Discount = discount;
            this.ID = iD;
        }

        public override string ToString()
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;//для корректного отображения обозначения символа рубля
            return String.Format("{4}\tМарка: {0}\tМакс. скорость: {1}\tЦена: {2:C}\tСкидка: {3}%",
                this.CarName, this.MaxSpeed, this.Cost, this.Discount, this.ID);
        
        }
    }

    class CompInv<T>:IComparer<T>where T : AutoShop
    {
        public int Compare(T x, T y)
        {  
          if (x.Cost < y.Cost)
             return 1;
            if (x.Cost > y.Cost)
                return -1;
            else return 0;
        }
           
    }
}
