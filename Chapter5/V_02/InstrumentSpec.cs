using System;
using System.Collections;

namespace Chapter5.V_02
{
    public class InstrumentSpec
    {
        private Hashtable properties;

        public InstrumentSpec(Hashtable properties)
        {
            if (properties == null)
            {
                this.properties = new Hashtable();
            }
            else
            {
                this.properties = new Hashtable(properties);
            }

        }

        public Object getProperty(String propertyName)
        {
            return properties[propertyName];
        }


        public Hashtable getProperties()
        {
            return properties;
        }


        public virtual bool matches(InstrumentSpec otherSpec)
        {
           /* foreach(DictionaryEntry de in properties)
            {
                var x = properties[de.Key];
                var y = otherSpec.getProperty(de.Key.ToString());
                if (properties[de.Key].Equals(otherSpec.getProperty(de.Key.ToString())))
                {
                    return true;
                }
            }
            return false;*/

            foreach(DictionaryEntry de in otherSpec.getProperties())
            {
                if (properties.Contains(de.Key))
                {
                    if (!properties[de.Key].Equals(de.Value))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
