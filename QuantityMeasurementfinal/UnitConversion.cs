using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementfinal
{
    public class UnitConversion
    {
        public enum Units
        { 
        FEET,
        INCH,
        YARD,
        CM,
        GALLON,
        LITRE,
        ML,
        KG,
        GM,
        TONNE,
        CELSIUS,
        FAHRNEEIT,
        }

        public static double GetQuanityValue(Units unit) {
            switch (unit)
            {
                case Units.FEET:
                    return 12;
                case Units.INCH:
                    return 1;
                case Units.YARD:
                    return 36;


            }
            return 0;
        
        }
    }
}
