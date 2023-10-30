using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Rental.Classes
{
    internal class Scooter : Transport
    {
        public Scooter(string model, string color, int speed, string category) : base(model, color, speed, 2, category)
        {
        }
        public override void Move()
        {
            IsRented = false;
        }
    }
}
