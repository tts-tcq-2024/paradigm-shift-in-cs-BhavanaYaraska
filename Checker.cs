namespace paradigm_shift_csharp
{
 public class Checker
    {
      static void Main(string[] args)
        {
            // Example inputs
            float temperature = 50.0f;
            float soc = 85.0f;
            float chargeRate = 3.0f;

            // Temperature Check
            var (tempIsOutOfRange, tempIsWarning) = CheckerTemperature.IsTemperatureOutOfRange(temperature);
            Console.WriteLine($"Temperature Check:");
            Console.WriteLine($"- Temperature: {temperature}");
            Console.WriteLine($"- Out of Range: {tempIsOutOfRange}");
            Console.WriteLine($"- Warning: {tempIsWarning}");
            Console.WriteLine($"- Battery Status OK: {CheckerTemperature.BatteryIsOkWithTemperature(temperature)}");

            Console.WriteLine();

            // SOC Check
            var (socIsOutOfRange, socIsWarning) = CheckerSoc.IsSocOutOfRange(soc);
            Console.WriteLine($"SOC Check:");
            Console.WriteLine($"- SOC: {soc}");
            Console.WriteLine($"- Out of Range: {socIsOutOfRange}");
            Console.WriteLine($"- Warning: {socIsWarning}");
            Console.WriteLine($"- Battery Status OK: {CheckerSoc.BatteryIsOkWithSoc(soc)}");

            Console.WriteLine();

            // Charge Rate Check
            var (chargeRateIsOutOfRange, chargeRateIsWarning) = CheckerChargeRate.IsChargeRateOutOfRange(chargeRate);
            Console.WriteLine($"Charge Rate Check:");
            Console.WriteLine($"- Charge Rate: {chargeRate}");
            Console.WriteLine($"- Out of Range: {chargeRateIsOutOfRange}");
            Console.WriteLine($"- Warning: {chargeRateIsWarning}");
            Console.WriteLine($"- Battery Status OK: {CheckerChargeRate.BatteryIsOkWithChargeRate(chargeRate)}");
        }  
      
    }
}
