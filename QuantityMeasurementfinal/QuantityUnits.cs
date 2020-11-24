using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementfinal
{
    public class QuantityUnits
    {
        private double quanity;

        public QuantityUnits(double conversionType, double quanity)
        {
            this.quanity = quanity * conversionType;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null) {
                return false;
            }
            QuantityUnits units = (QuantityUnits)obj;
            if (units.quanity < 0) {
                throw new QunaityMeasurementException(QunaityMeasurementException.ExceptionType.INVALID_VALUE,"provided value is invalid");
            }
            return this.quanity == units.quanity;
        }
    }
}
