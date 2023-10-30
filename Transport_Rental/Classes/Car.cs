using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Rental.Classes
{
    internal class Car : Transport
    {
        public Car(string model, string color, int speed, string category) : base(model, color, speed, 4, category)
        {
            IsRented = true;
        }
        public override void Move()
        {
            IsRented = true;
        }
    }
}
