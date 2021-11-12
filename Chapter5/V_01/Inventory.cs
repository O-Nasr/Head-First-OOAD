using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5.V_01
{
    public class Inventory
    {
        private List<Instrument> inventory;

        public Inventory()
        {
            inventory = new List<Instrument>();
        }

        public void addInstrument(String serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = null;
            if(spec is GuitarSpec)
            {
                instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);
            }else if(spec is MandolinSpec)
            {
                instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
            }
            inventory.Add(instrument);
        }


        public Instrument get(String serialNumber)
        {
            foreach (var instrument in inventory)
            {
                if (instrument.getSerialNumber().Equals(serialNumber))
                {
                    return instrument;
                }
            }
            return null;
        }

        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (var item in inventory)
            {
                Guitar guitar = (Guitar)item;
                if (guitar.getSpec().matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
                
            }
            return matchingGuitars;
        }


        public List<Mandolin> search(MandolinSpec searchSpec)
        {
            List<Mandolin> matchingMandolins = new List<Mandolin>();
            foreach(var item in inventory)
            {
                Mandolin mandolin = (Mandolin)item;
                if (mandolin.getSpec().matches(searchSpec)){
                    matchingMandolins.Add(mandolin);
                }
            }

            return matchingMandolins;
        }
    }
}
