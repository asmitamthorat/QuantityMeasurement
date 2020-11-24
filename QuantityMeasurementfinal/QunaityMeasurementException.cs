using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementfinal
{
    public class QunaityMeasurementException:Exception
    {
        public enum ExceptionType {

            INVALID_VALUE

        }
        public ExceptionType exceptionType;

        public QunaityMeasurementException(ExceptionType exceptionType, String message) :base(message)
        {
            this.exceptionType = exceptionType;


        }
    }
}
