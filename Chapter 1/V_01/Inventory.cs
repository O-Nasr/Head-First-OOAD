using System;
using System.Collections.Generic;

namespace Chapter_1.V_01
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price,
                        String builder, String model,
                        String type, String backWood, String topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder,
                                       model, type, backWood, topWood);
            guitars.Add(guitar);
        }


        public Guitar getGuitar(String serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.getSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public Guitar search(Guitar searchGuitar)
        {
            foreach (var guitar in guitars)
            {
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                String builder = searchGuitar.getBuilder();
                if (!string.IsNullOrEmpty(builder) && !builder.Equals(guitar.getBuilder()))
                    continue;
                String model = searchGuitar.getModel();
                if (!string.IsNullOrEmpty(model) && !model.Equals(guitar.getModel()))
                    continue;
                String type = searchGuitar.getType();
                if (string.IsNullOrEmpty(type) && !type.Equals(guitar.getType()))
                    continue;
                String backWood = searchGuitar.getBackWood();
                if (string.IsNullOrEmpty(backWood) && !backWood.Equals(guitar.getBackWood()))
                    continue;
                String topWood = searchGuitar.getTopWood();
                if (string.IsNullOrEmpty(topWood) && !topWood.Equals(guitar.getTopWood()))
                    continue;
                return guitar;
            }
            return null;
        }

    }
}
