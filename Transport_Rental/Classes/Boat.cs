using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Rental.Classes
{
    internal class Boat : Transport
    {
        public Boat(string model, string color, int speed, string category) : base(model, color, speed, 0, category)
        {
        }
        public override void Move()
        {
            IsRented = false;
        }
    }
}
