﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementfinal
{
    public class QuantityMeasurement
    {
        public bool EqualityCheck(QuantityUnits firstQuantity, QuantityUnits secondQuantity) {

            return firstQuantity.Equals(secondQuantity);
        }
    }
}
