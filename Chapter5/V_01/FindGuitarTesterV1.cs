using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5.V_01
{
    public class FindGuitarTesterV1
    {
        public static void MinV1()
        {
            // Set up Rick's guitar inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            GuitarSpec whatErinLikes =
              new GuitarSpec(Enums.Builder.FENDER, "Stratocastor",
                             Enums.Type.ELECTRIC, 6, Enums.Wood.ALDER, Enums.Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars.Count != 0)
            {
                Console.WriteLine("Erin, you might like these guitars:");
                foreach(var guitar in matchingGuitars)
                {
                    InstrumentSpec spec = guitar.getSpec();
                    Console.WriteLine("  We have a " +
                      spec.getBuilder() + " " + spec.getModel() + " " +
                      spec.getType() + " guitar:\n     " +
                      spec.getBackWood() + " back and sides,\n     " +
                      spec.getTopWood() + " top.\n  You can have it for only $" +
                      guitar.getPrice() + "!\n  ----");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }

        }
        private static void initializeInventory(Inventory inventory)
        {
            inventory.addInstrument("11277", 3999.95,
              new GuitarSpec(Enums.Builder.COLLINGS, "CJ", Enums.Type.ACOUSTIC, 6,
                             Enums.Wood.INDIAN_ROSEWOOD, Enums.Wood.SITKA));
            inventory.addInstrument("V95693", 1499.95,
              new GuitarSpec(Enums.Builder.FENDER, "Stratocastor", Enums.Type.ELECTRIC, 6,
                             Enums.Wood.ALDER, Enums.Wood.ALDER));
            inventory.addInstrument("V9512", 1549.95,
              new GuitarSpec(Enums.Builder.FENDER, "Stratocastor", Enums.Type.ELECTRIC, 6,
                             Enums.Wood.ALDER, Enums.Wood.ALDER));
            inventory.addInstrument("122784", 5495.95,
              new GuitarSpec(Enums.Builder.MARTIN, "D-18", Enums.Type.ACOUSTIC, 6,
                             Enums.Wood.MAHOGANY, Enums.Wood.ADIRONDACK));
            inventory.addInstrument("76531", 6295.95,
              new GuitarSpec(Enums.Builder.MARTIN, "OM-28", Enums.Type.ACOUSTIC, 6,
                             Enums.Wood.BRAZILIAN_ROSEWOOD, Enums.Wood.ADIRONDACK));
            inventory.addInstrument("70108276", 2295.95,
              new GuitarSpec(Enums.Builder.GIBSON, "Les Paul", Enums.Type.ELECTRIC, 6,
                             Enums.Wood.MAHOGANY, Enums.Wood.MAHOGANY));
            inventory.addInstrument("82765501", 1890.95,
              new GuitarSpec(Enums.Builder.GIBSON, "SG '61 Reissue", Enums.Type.ELECTRIC, 6,
                             Enums.Wood.MAHOGANY, Enums.Wood.MAHOGANY));
            inventory.addInstrument("77023", 6275.95,
              new GuitarSpec(Enums.Builder.MARTIN, "D-28", Enums.Type.ACOUSTIC, 6,
                             Enums.Wood.BRAZILIAN_ROSEWOOD, Enums.Wood.ADIRONDACK));
            inventory.addInstrument("1092", 12995.95,
              new GuitarSpec(Enums.Builder.OLSON, "SJ", Enums.Type.ACOUSTIC, 12,
                             Enums.Wood.INDIAN_ROSEWOOD, Enums.Wood.CEDAR));
            inventory.addInstrument("566-62", 8999.95,
              new GuitarSpec(Enums.Builder.RYAN, "Cathedral", Enums.Type.ACOUSTIC, 12,
                             Enums.Wood.COCOBOLO, Enums.Wood.CEDAR));
            inventory.addInstrument("6 29584", 2100.95,
              new GuitarSpec(Enums.Builder.PRS, "Dave Navarro Signature", Enums.Type.ELECTRIC,
                             6, Enums.Wood.MAHOGANY, Enums.Wood.MAPLE));
        }


    }


}
