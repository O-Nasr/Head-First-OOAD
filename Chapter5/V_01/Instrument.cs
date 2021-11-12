using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5.V_01
{
    public abstract class Instrument
    {
        private String serialNumber;
        private double price;
        InstrumentSpec spec;

        public Instrument(String serialNumber, double price, InstrumentSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }


        public String getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }
        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }

        public InstrumentSpec getSpec()
        {
            return spec;
        }
    }
}
