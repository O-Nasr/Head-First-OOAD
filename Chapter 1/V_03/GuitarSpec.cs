using System;

namespace Chapter_1.V_03
{
    public class GuitarSpec
    {
        private Enums.Builder builder;
        private String model;
        private Enums.Type type;
        private Enums.Wood backWood;
        private Enums.Wood topWood;

        public GuitarSpec(Enums.Builder builder, String model, Enums.Type type,
                    Enums.Wood backWood, Enums.Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
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

    }
}
