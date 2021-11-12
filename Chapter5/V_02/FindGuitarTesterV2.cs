using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chapter5.V_02
{
    public class FindGuitarTesterV2
    {
        public static void MinV2()
        {
            // Set up Rick's inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Hashtable properties = new Hashtable();
            properties.Add("builder", Enums.Builder.GIBSON);
            properties.Add("backWood", Enums.Wood.MAPLE);
            InstrumentSpec whatBryanLikes = new InstrumentSpec(properties);

            List<Instrument> matchingInstruments = inventory.search(whatBryanLikes);
            if (matchingInstruments.Count != 0)
            {
                Console.WriteLine("Bryan, you might like these instruments:");
                foreach (var instrument in matchingInstruments)
                {
                    InstrumentSpec spec = instrument.getSpec();
                    Console.WriteLine("We have a " + spec.getProperty("instrumentType") +
                      " with the following properties:");
                    foreach(DictionaryEntry de in spec.getProperties())
                    {
                        String propertyName = de.Key.ToString();
                        if (propertyName.Equals("instrumentType"))
                            continue;
                        Console.WriteLine("    " + propertyName + ": " +
                          spec.getProperty(propertyName));
                    }
                    Console.WriteLine("  You can have this " +
                      spec.getProperty("instrumentType") + " for $" +
                      instrument.getPrice() + "\n---");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Bryan, we have nothing for you.");
            }


        }
        private static void initializeInventory(Inventory inventory)
        {
            Hashtable properties = new Hashtable();
            properties.Add("instrumentType", Enums.InstrumentType.GUITAR);
            properties.Add("builder", Enums.Builder.COLLINGS);
            properties.Add("model", "CJ");
            properties.Add("type", Enums.Type.ACOUSTIC);
            properties.Add("numStrings", 6);
            properties.Add("topWood", Enums.Wood.INDIAN_ROSEWOOD);
            properties.Add("backWood", Enums.Wood.SITKA);
            inventory.addInstrument("11277", 3999.95, new InstrumentSpec(properties));

            properties["builder"] = Enums.Builder.MARTIN;
            properties["model"] = "D-18";
            properties["topWood"] = Enums.Wood.MAHOGANY;
            properties["backWood"] = Enums.Wood.ADIRONDACK;
            inventory.addInstrument("122784", 5495.95, new InstrumentSpec(properties));

            properties["builder"] = Enums.Builder.FENDER;
            properties["model"] = "Stratocastor";
            properties["type"] = Enums.Type.ELECTRIC;
            properties["topWood"] = Enums.Wood.ALDER;
            properties["backWood"] = Enums.Wood.ALDER;
            inventory.addInstrument("V95693", 1499.95, new InstrumentSpec(properties));
            inventory.addInstrument("V9512", 1549.95, new InstrumentSpec(properties));

            properties["builder"] = Enums.Builder.GIBSON;
            properties["model"] = "Les Paul";
            properties["topWood"] = Enums.Wood.MAPLE;
            properties["backWood"] = Enums.Wood.MAPLE;
            inventory.addInstrument("70108276", 2295.95, new InstrumentSpec(properties));

            properties["model"] = "SG '61 Reissue";
            properties["topWood"] = Enums.Wood.MAHOGANY;
            properties["backWood"] = Enums.Wood.MAHOGANY;
            inventory.addInstrument("82765501", 1890.95, new InstrumentSpec(properties));

            properties["instrumentType"] = Enums.InstrumentType.MANDOLIN;
            properties["type"] = Enums.Type.ACOUSTIC;
            properties["model"] = "F-5G";
            properties["backWood"] = Enums.Wood.MAPLE;
            properties["topWood"] = Enums.Wood.MAPLE;
            properties.Remove("numStrings");
            inventory.addInstrument("9019920", 5495.99, new InstrumentSpec(properties));

            properties["instrumentType"] = Enums.InstrumentType.BANJO;
            properties["model"] = "RB-3 Wreath";
            properties.Add("numStrings", 5);
            properties.Remove("topWood");
            inventory.addInstrument("8900231", 2945.95, new InstrumentSpec(properties));

        }
    }
}
