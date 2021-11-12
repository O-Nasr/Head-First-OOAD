using System;

namespace Chapter_1.V_03
{
    public class Guitar
    {
        private String serialNumber;
        private double price;
        GuitarSpec spec;


        public Guitar(String serialNumber, double price,
                Enums.Builder builder, String model, Enums.Type type,
                Enums.Wood backWood, Enums.Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;

            this.spec = new GuitarSpec(builder, model, type, backWood, topWood);

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

        public GuitarSpec getSpec()
        {
            return spec;
        }
    }
}
