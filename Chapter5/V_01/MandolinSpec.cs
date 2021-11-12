using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5.V_01
{
    public class MandolinSpec : InstrumentSpec
    {
        private Enums.Style style;
        public MandolinSpec(Enums.Builder builder, String model, Enums.Type type, Enums.Style style,
                    Enums.Wood backWood, Enums.Wood topWood) : base(builder, model, type, backWood, topWood)
        {
            this.style = style;
        }


        public Enums.Style getStyle()
        {
            return style;
        }

        public override bool matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
                return false;

            if (!(otherSpec is MandolinSpec))
                return false;

            MandolinSpec spec = (MandolinSpec)otherSpec;
            if (style != spec.style)
                return false;

            return true;
        }
    }
}
