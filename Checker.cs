namespace paradigm_shift_csharp
{
 public class Checker
    {
        // Constants
        private const float TemperatureUpperLimit = 45.0f;
        private const float TemperatureWarningTolerance = 5.0f;
        private const float SocUpperLimit = 80.0f;
        private const float SocWarningTolerance = 10.0f;
        private const float ChargeRateUpperLimit = 2.0f;
        private const float ChargeRateWarningTolerance = 0.5f;

        // Utility method
        public static (bool isOutOfRange, bool isWarning) CheckRangeAndWarning(float value, float upperLimit, float warningTolerance)
        {
            bool isOutOfRange = value < 0 || value > upperLimit;
            bool isWarning = value >= upperLimit - warningTolerance && value <= upperLimit;
            return (isOutOfRange, isWarning);
        }

        // Temperature methods
        public static (bool isOutOfRange, bool isWarning) IsTemperatureOutOfRange(float temperature)
        {
            return CheckRangeAndWarning(temperature, TemperatureUpperLimit, TemperatureWarningTolerance);
        }

        public static bool BatteryIsOkWithTemperature(float temperature)
        {
            var (isOutOfRange, isWarning) = IsTemperatureOutOfRange(temperature);
            if (isOutOfRange)
            {
                Console.WriteLine("Temperature is out of range!");
                return false;
            }
            if (isWarning)
            {
                Console.WriteLine("Warning: Temperature is approaching upper limit!");
            }
            return true;
        }

        // SOC methods
        public static (bool isOutOfRange, bool isWarning) IsSocOutOfRange(float soc)
        {
            return CheckRangeAndWarning(soc, SocUpperLimit, SocWarningTolerance);
        }

        public static bool BatteryIsOkWithSoc(float soc)
        {
            var (isOutOfRange, isWarning) = IsSocOutOfRange(soc);
            if (isOutOfRange)
            {
                Console.WriteLine("SOC is out of range!");
                return false;
            }
            if (isWarning)
            {
                Console.WriteLine("Warning: SOC is approaching upper limit!");
            }
            return true;
        }

        // Charge Rate methods
        public static (bool isOutOfRange, bool isWarning) IsChargeRateOutOfRange(float chargeRate)
        {
            return CheckRangeAndWarning(chargeRate, ChargeRateUpperLimit, ChargeRateWarningTolerance);
        }

        public static bool BatteryIsOkWithChargeRate(float chargeRate)
        {
            var (isOutOfRange, isWarning) = IsChargeRateOutOfRange(chargeRate);
            if (isOutOfRange)
            {
                Console.WriteLine("Charge rate is out of range!");
                return false;
            }
            if (isWarning)
            {
                Console.WriteLine("Warning: Charge rate is approaching upper limit!");
            }
            return true;
        }
    }
}
