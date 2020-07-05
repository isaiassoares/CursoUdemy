using System;
using System.Collections.Generic;
using System.Text;

namespace S14.CAP201_Heranca_multipla.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
