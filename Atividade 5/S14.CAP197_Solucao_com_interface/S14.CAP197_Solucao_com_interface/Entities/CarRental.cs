﻿using System;
using System.Collections.Generic;
using System.Text;

namespace S14.CAP197_Solucao_com_interface.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
