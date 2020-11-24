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
                case Units.CM:
                    return 0.4;
                case Units.GALLON:
                    return 3.78;
                case Units.LITRE:
                    return 1;
                case Units.ML:
                    return 0.001;
                case Units.KG:
                    return 1;
                case Units.GM:
                    return 0.001;
                case Units.TONNE:
                    return 1000;
                case Units.FAHRNEEIT:
                    return 1;
                case Units.CELSIUS:
                    return 2.12;


            }
            return 0.0;
        
        }
    }
}
