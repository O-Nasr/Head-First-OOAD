using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_1.V_02
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price,
                        Enums.Builder builder, String model,
                        Enums.Type type, Enums.Wood backWood, Enums.Wood topWood)
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

        public List<Guitar> search(Guitar searchGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                if (searchGuitar.getBuilder() != guitar.getBuilder())
                    continue;
                String model = searchGuitar.getModel().ToLower();
                if (!string.IsNullOrEmpty(model) && !model.Equals(guitar.getModel().ToLower()))
                    continue;
                if (searchGuitar.getType() != guitar.getType())
                    continue;
                if (searchGuitar.getBackWood() != guitar.getBackWood())
                    continue;
                if (searchGuitar.getTopWood() != guitar.getTopWood())
                    continue;
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }

    }
}
