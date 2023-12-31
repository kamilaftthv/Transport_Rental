﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Rental.Classes
{
    internal interface IRentable
    {
        bool IsRented { get; }
        event RentStateChangedHandler RentStateChanged;
        void Rent();
        void Return();
    }

    public delegate void RentStateChangedHandler(object sender, EventArgs e);
}