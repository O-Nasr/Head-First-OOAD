using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5.V_01
{
    public abstract class InstrumentSpec
    {
        private Enums.Builder builder;
        private String model;
        private Enums.Type type;
        private Enums.Wood backWood;
        private Enums.Wood topWood;

        public InstrumentSpec(Enums.Builder builder, String model, Enums.Type type,
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


        public virtual bool matches(InstrumentSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;
            if (!string.IsNullOrEmpty(model) && (!model.ToLower().Equals(otherSpec.model.ToLower())))
                return false;
            if (type != otherSpec.type)
                return false;
            if (backWood != otherSpec.backWood)
                return false;
            if (topWood != otherSpec.topWood)
                return false;
            return true;
        }

    }
}
