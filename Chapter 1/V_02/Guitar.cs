using System;

namespace Chapter_1.V_02
{
    public class Guitar
    {

        private String serialNumber, model;
        private double price;
        private Enums.Builder builder;
        private Enums.Type type;
        private Enums.Wood backWood, topWood;


        public Guitar(String serialNumber, double price,
                Enums.Builder builder, String model, Enums.Type type,
                Enums.Wood backWood, Enums.Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
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

        public String getModel()
        {
            return model;
        }

        public Enums.Builder getBuilder()
        {
            return builder;
        }
        public Enums.Type getType()
        {
            return type;
        }
        public Enums.Wood getBackWood()
        {
            return backWood;
        }
        public Enums.Wood getTopWood()
        {
            return topWood;
        }

    }
}
