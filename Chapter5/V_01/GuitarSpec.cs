using System;

namespace Chapter5.V_01
{
    public class GuitarSpec : InstrumentSpec
    {
        private int numStrings;

        public GuitarSpec(Enums.Builder builder, String model, Enums.Type type, int numStrings,
                    Enums.Wood backWood, Enums.Wood topWood) : base(builder, model, type, backWood, topWood)
        {
            this.numStrings = numStrings;
        }


        public int getNumStrings()
        {
            return numStrings;
        }

        public override bool matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
                return false;

            if (!(otherSpec is GuitarSpec))
                return false;

            GuitarSpec spec = (GuitarSpec)otherSpec;
            if (numStrings != spec.numStrings)
                return false;

            return true;
        }

    }
}
