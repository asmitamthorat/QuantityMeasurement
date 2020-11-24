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

        [Test]
        public void WhenFeetRefference_comparetosameFeetRefference_ShouldReturnTrue() {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 0);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, firstUnit);
            Assert.IsTrue(result);
        }

        [Test]
        public void WhenGivenQuantittyCompareWithFeetType_shouldReturnTrue() {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 0);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsTrue(result);
        }

        [Test]
        public void WhenfiveFeetComparedWith_twoFeet_ShouldReturnTrue() {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET),5);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET),2);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenQuantity_WhenZeroInchesCompareWithZeroInches_ThenReturnTrue() {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 0);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 0);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroInchesCompareWithNull_ShouldReturnFalse() {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 0);
            QuantityUnits secondUnit = null;
            bool result = quantityMeasurement.EqualityCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);
        }

        [Test]
        public void WhenInchesRefference_comparetosameInchesRefference_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 0);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, firstUnit);
            Assert.IsTrue(result);

        }

        [Test]
        public void WhenTwoInches_comparedWithZero_ShouldReturnFalse() {

            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 0);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenThreeFeetand_OneYard_WhenCompare_ShouldReturnTrue() {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 3);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.YARD), 1);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsTrue(result);

        }


        [Test]
        public void GivenOneFeetand_OneYard_WhenCompare_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.YARD), 1);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.False(result);

        }

        [Test]
        public void GivenOneInchtand_OneYard_WhenCompare_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 1);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.YARD), 1);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.False(result);

        }

        [Test]
        public void GivenOneYardand_thirtySixInches_WhenCompare_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.YARD), 1);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 36);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsTrue(result);

        }


        [Test]
        public void GiventhirtySixInches_OneYardand_WhenCompare_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit  = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 36);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.YARD), 1);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsTrue(result);

        }

        [Test]
        public void GivenTwoInches_andFiveCM_WhenCompare_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.CM), 5);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsTrue(result);

        }

        [Test]
        public void GivenAdditionofTwoInchesAndTwoInches_ComparedWithFourInches_ShouldReturnTrue() {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH),2);
            QuantityUnits Addition = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 4);
            double AdditionOfUnit = quantityMeasurement.AddQuntities(firstUnit, SecondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), AdditionOfUnit);
            bool result = quantityMeasurement.EqualityCheck(Addition, newAdditionUnit);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenAdditionofOneFeetAndTwoInches_ComparedWithFourteenInches_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits Addition = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 14);
            double AdditionOfUnit = quantityMeasurement.AddQuntities(firstUnit, SecondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), AdditionOfUnit);
            bool result = quantityMeasurement.EqualityCheck(Addition, newAdditionUnit);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenAdditionofOneFeetAndOneFeet_ComparedWithTweentyFourInches_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits Addition = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 24);
            double AdditionOfUnit = quantityMeasurement.AddQuntities(firstUnit, SecondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), AdditionOfUnit);
            bool result = quantityMeasurement.EqualityCheck(Addition, newAdditionUnit);
            Assert.IsTrue(result);
        }


        [Test]
        public void GivenAdditionofTwoInchesAndtwocm_ComparedWithThreeInches_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.CM), 2.5);
            QuantityUnits Addition = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), 3);
            double AdditionOfUnit = quantityMeasurement.AddQuntities(firstUnit, SecondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.INCH), AdditionOfUnit);
            bool result = quantityMeasurement.EqualityCheck(Addition, newAdditionUnit);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenOneGallon_andthreeLitre_WhenCompare_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.GALLON), 1);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.LITRE), 3.78);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsTrue(result);

        }

        [Test]
        public void GivenOneLitre_andthousandML_WhenCompare_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.LITRE), 1);
            QuantityUnits SecondUnit = new QuantityUnits((double)UnitConversion.GetQuanityValue(UnitConversion.Units.ML), 1000);
            bool result = quantityMeasurement.EqualityCheck(firstUnit, SecondUnit);
            Assert.IsTrue(result);

        }





    }
}