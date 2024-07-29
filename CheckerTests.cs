using Xunit;
using paradigm_shift_csharp; // Ensure this matches the namespace of your Checker class

namespace ParadigmShiftTests
{
    public class CheckerTests
    {
        [Theory]
        [InlineData(25, true, false)]  // Temperature within the normal range
        [InlineData(50, false, false)] // Temperature out of range
        [InlineData(40, true, true)]   // Temperature approaching upper limit
        public void TestBatteryIsOkWithTemperature(float temperature, bool expectedIsOk, bool expectedWarning)
        {
            var (isOutOfRange, isWarning) = Checker.IsTemperatureOutOfRange(temperature);
            var result = Checker.BatteryIsOkWithTemperature(temperature);
            
            Assert.Equal(expectedIsOk, result);
            Assert.Equal(expectedWarning, isWarning);
        }

        [Theory]
        [InlineData(70, true, false)]  // SOC within the normal range
        [InlineData(85, false, false)] // SOC out of range
        [InlineData(76, true, true)]   // SOC approaching upper limit
        public void TestBatteryIsOkWithSoc(float soc, bool expectedIsOk, bool expectedWarning)
        {
            var (isOutOfRange, isWarning) = Checker.IsSocOutOfRange(soc);
            var result = Checker.BatteryIsOkWithSoc(soc);

            Assert.Equal(expectedIsOk, result);
            Assert.Equal(expectedWarning, isWarning);
        }

        [Theory]
        [InlineData(0.7f, true, false)]  // Charge Rate within the normal range
        [InlineData(0.9f, false, false)] // Charge Rate out of range
        [InlineData(0.76f, true, true)]   // Charge Rate approaching upper limit
        public void TestBatteryIsOkWithChargeRate(float chargeRate, bool expectedIsOk, bool expectedWarning)
        {
            var (isOutOfRange, isWarning) = Checker.IsChargeRateOutOfRange(chargeRate);
            var result = Checker.BatteryIsOkWithChargeRate(chargeRate);

            Assert.Equal(expectedIsOk, result);
            Assert.Equal(expectedWarning, isWarning);
        }
    }
}
