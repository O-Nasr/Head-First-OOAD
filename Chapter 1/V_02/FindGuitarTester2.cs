using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_1.V_02
{
    public class FindGuitarTester2
    {
        public static void MinV2()
        {
            // Set up Rick's guitar inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("", 0, Enums.Builder.FENDER, "Stratocastor",
                                              Enums.Type.ELECTRIC, Enums.Wood.ALDER, Enums.Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars.Count != 0)
            {
                Console.WriteLine("Erin, you might like these guitars:");
                foreach(var guitar in matchingGuitars)
                {
                    Console.WriteLine("  We have a " +
                      guitar.getBuilder() + " " + guitar.getModel() + " " +
                      guitar.getType() + " guitar:\n     " +
                      guitar.getBackWood() + " back and sides,\n     " +
                      guitar.getTopWood() + " top.\n  You can have it for only $" +
                      guitar.getPrice() + "!\n  ----");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }

        }

        private static void initializeInventory(V_02.Inventory inventory)
        {
            inventory.addGuitar("11277", 3999.95, Enums.Builder.COLLINGS,
                                "CJ", Enums.Type.ACOUSTIC,
                                Enums.Wood.INDIAN_ROSEWOOD, Enums.Wood.SITKA);
            inventory.addGuitar("V95693", 1499.95, Enums.Builder.FENDER,
                                "Stratocastor", Enums.Type.ELECTRIC,
                                Enums.Wood.ALDER, Enums.Wood.ALDER);
            inventory.addGuitar("V9512", 1549.95, Enums.Builder.FENDER,
                                "Stratocastor", Enums.Type.ELECTRIC,
                                Enums.Wood.ALDER, Enums.Wood.ALDER);
            inventory.addGuitar("122784", 5495.95, Enums.Builder.MARTIN,
                                "D-18", Enums.Type.ACOUSTIC,
                                Enums.Wood.MAHOGANY, Enums.Wood.ADIRONDACK);
            inventory.addGuitar("76531", 6295.95, Enums.Builder.MARTIN,
                                "OM-28", Enums.Type.ACOUSTIC,
                                Enums.Wood.BRAZILIAN_ROSEWOOD, Enums.Wood.ADIRONDACK);
            inventory.addGuitar("70108276", 2295.95, Enums.Builder.GIBSON,
                                "Les Paul", Enums.Type.ELECTRIC,
                                Enums.Wood.MAHOGANY, Enums.Wood.MAHOGANY);
            inventory.addGuitar("82765501", 1890.95, Enums.Builder.GIBSON,
                                "SG '61 Reissue", Enums.Type.ELECTRIC,
                                Enums.Wood.MAHOGANY, Enums.Wood.MAHOGANY);
            inventory.addGuitar("77023", 6275.95, Enums.Builder.MARTIN,
                                "D-28", Enums.Type.ACOUSTIC,
                                Enums.Wood.BRAZILIAN_ROSEWOOD, Enums.Wood.ADIRONDACK);
            inventory.addGuitar("1092", 12995.95, Enums.Builder.OLSON,
                                "SJ", Enums.Type.ACOUSTIC,
                                Enums.Wood.INDIAN_ROSEWOOD, Enums.Wood.CEDAR);
            inventory.addGuitar("566-62", 8999.95, Enums.Builder.RYAN,
                                "Cathedral", Enums.Type.ACOUSTIC,
                                Enums.Wood.COCOBOLO, Enums.Wood.CEDAR);
            inventory.addGuitar("6 29584", 2100.95, Enums.Builder.PRS,
                                "Dave Navarro Signature", Enums.Type.ELECTRIC,
                                Enums.Wood.MAHOGANY, Enums.Wood.MAPLE);
        }
    }
}
