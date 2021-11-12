using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5.V_02
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
            Instrument instrument = new Instrument(serialNumber, price, spec);
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

        public List<Instrument> search(InstrumentSpec searchSpec)
        {
            List<Instrument> matchingInstrumets = new List<Instrument>();
            foreach (var item in inventory)
            {
                if (item.getSpec().matches(searchSpec))
                {
                    matchingInstrumets.Add(item);
                }

            }
            return matchingInstrumets;
        }
    }
}
