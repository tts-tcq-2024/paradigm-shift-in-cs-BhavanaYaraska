namespace paradigm_shift_csharp
{
    // Define the partial class Checker in the namespace paradigm_shift_csharp
    partial class Checker
    {
        // Static fields for limits and tolerances
        static readonly float TemperatureUpperLimit = 45;
        static readonly float SocUpperLimit = 80;
        static readonly float ChargeRateUpperLimit = 0.8f;

        static readonly float TemperatureWarningTolerance = TemperatureUpperLimit * 0.05f;
        static readonly float SocWarningTolerance = SocUpperLimit * 0.05f;
        static readonly float ChargeRateWarningTolerance = ChargeRateUpperLimit * 0.05f;

        // Main method entry point
        static int Main()
        {
            // Test cases
            ExpectTrue(BatteryIsOkWithTemperature(25));
            ExpectTrue(BatteryIsOkWithSoc(70));
            ExpectTrue(BatteryIsOkWithChargeRate(0.7f));
            ExpectFalse(BatteryIsOkWithTemperature(50));
            ExpectFalse(BatteryIsOkWithSoc(85));
            ExpectFalse(BatteryIsOkWithChargeRate(0.0f));
            Console.WriteLine("All ok");
            return 0;
        }

        // Example method for BatteryIsOkWithTemperature
        static bool BatteryIsOkWithTemperature(float temperature)
        {
            // Logic to check if temperature is within acceptable range
            return true; // Replace with your actual logic
        }

        // Example method for ExpectTrue
        static void ExpectTrue(bool condition)
        {
            if (!condition)
                Console.WriteLine("ExpectTrue failed");
        }

        // Example method for ExpectFalse
        static void ExpectFalse(bool condition)
        {
            if (condition)
                Console.WriteLine("ExpectFalse failed");
        }
    }

    // Define other partial classes for CheckerTemperature, CheckerSoc, CheckerChargeRate
    partial class CheckerTemperature
    {
        // Methods specific to temperature checks
    }

    partial class CheckerSoc
    {
        // Methods specific to State of Charge (SoC) checks
    }

    partial class CheckerChargeRate
    {
        // Methods specific to Charge Rate checks
    }
}
