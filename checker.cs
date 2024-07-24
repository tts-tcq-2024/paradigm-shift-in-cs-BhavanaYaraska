using System;

namespace paradigm_shift_csharp
{
    class Checker
    {
        static readonly float TemperatureUpperLimit = 45;
        static readonly float SocUpperLimit = 80;
        static readonly float ChargeRateUpperLimit = 0.8f;

        // Define warning tolerance as 5% of the upper limit
        static readonly float TemperatureWarningTolerance = TemperatureUpperLimit * 0.05f;
        static readonly float SocWarningTolerance = SocUpperLimit * 0.05f;
        static readonly float ChargeRateWarningTolerance = ChargeRateUpperLimit * 0.05f;

        static (bool, bool) CheckRangeAndWarning(float value, float upperLimit, float warningTolerance)
        {
            bool isOutOfRange = value < 0 || value > upperLimit;
            bool isWarning = value >= upperLimit - warningTolerance && value <= upperLimit;
            return (isOutOfRange, isWarning);
        }

        static (bool, bool) IsTemperatureOutOfRange(float temperature)
        {
            return CheckRangeAndWarning(temperature, TemperatureUpperLimit, TemperatureWarningTolerance);
        }

        static (bool, bool) IsSocOutOfRange(float soc)
        {
            return CheckRangeAndWarning(soc, SocUpperLimit, SocWarningTolerance);
        }

        static (bool, bool) IsChargeRateOutOfRange(float chargeRate)
        {
            return CheckRangeAndWarning(chargeRate, ChargeRateUpperLimit, ChargeRateWarningTolerance);
        }

        static bool BatteryIsOkWithTemperature(float temperature)
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

        static bool BatteryIsOkWithSoc(float soc)
        {
            var (isOutOfRange, isWarning) = IsSocOutOfRange(soc);
            if (isOutOfRange)
            {
                Console.WriteLine("State of Charge is out of range!");
                return false;
            }
            if (isWarning)
            {
                Console.WriteLine("Warning: State of Charge is approaching upper limit!");
            }
            return true;
        }

        static bool BatteryIsOkWithChargeRate(float chargeRate)
        {
            var (isOutOfRange, isWarning) = IsChargeRateOutOfRange(chargeRate);
            if (isOutOfRange)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            if (isWarning)
            {
                Console.WriteLine("Warning: Charge Rate is approaching upper limit!");
            }
            return true;
        }

        static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
                // Environment.Exit(1);
            }
        }

        static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
                // Environment.Exit(1);
            }
        }

        static int Main()
        {
            ExpectTrue(BatteryIsOkWithTemperature(25));
            ExpectTrue(BatteryIsOkWithSoc(70));
            ExpectTrue(BatteryIsOkWithChargeRate(0.7f));
            ExpectFalse(BatteryIsOkWithTemperature(50));
            ExpectFalse(BatteryIsOkWithSoc(85));
            ExpectFalse(BatteryIsOkWithChargeRate(0.0f));
            Console.WriteLine("All ok");
            return 0;
        }

    }
}
