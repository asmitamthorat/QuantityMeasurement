using NUnit.Framework;
using QuantityMeasurementfinal;

namespace QuantityMeasurementTest
{
    public class Tests
    {
       
        [Test]
        public void GivenQuantity_WhenZerofeetCompareWithZeroFeet_ThenReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 0);
            bool result = quantityMeasurement.EqualityCheck(firstUnit,secondUnit);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenQuanity_ZeroCompareWithZero_ShouldReturnFalse() {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits secondUnit = null;
            bool result = quantityMeasurement.EqualityCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);


        }
    }
}