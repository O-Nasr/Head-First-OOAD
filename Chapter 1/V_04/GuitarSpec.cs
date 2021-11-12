using System;

namespace Chapter_1.V_04
{
    public class GuitarSpec
    {
        private Enums.Builder builder;
        private String model;
        private Enums.Type type;
        private Enums.Wood backWood;
        private Enums.Wood topWood;
        private int numStrings;

        public GuitarSpec(Enums.Builder builder, String model, Enums.Type type, int numStrings,
                    Enums.Wood backWood, Enums.Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
            this.numStrings = numStrings;
        }


        public int getNumStrings()
        {
            return numStrings;
        }

        public Enums.Builder getBuilder()
        {
            return builder;
        }

        public String getModel()
        {
            return model;
        }

        public Enums.Type getType()
        {
            return type;
        }

        public Enums.Wood getBackWood()
        {
            return backWood;
        }

        public Enums.Wood getTopWood()
        {
            return topWood;
        }


        public bool matches(GuitarSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;
            if (!string.IsNullOrEmpty(model) &&(!model.ToLower().Equals(otherSpec.model.ToLower())))
                return false;
            if (type != otherSpec.type)
                return false;
            if (numStrings != otherSpec.numStrings)
                return false;
            if (backWood != otherSpec.backWood)
                return false;
            if (topWood != otherSpec.topWood)
                return false;
            return true;
        }


    }
}
