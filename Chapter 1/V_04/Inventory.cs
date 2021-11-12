using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_1.V_04
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
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

        public List<Guitar> search(GuitarSpec searchGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                GuitarSpec guitarSpec = guitar.getSpec();
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                if (guitar.getSpec().matches(searchGuitar)){
                    matchingGuitars.Add(guitar);
                }
                
            }
            return matchingGuitars;
        }
    }
}
