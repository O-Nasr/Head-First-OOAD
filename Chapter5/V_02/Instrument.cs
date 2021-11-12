using System;

namespace Chapter5.V_02
{
    public class Instrument
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
