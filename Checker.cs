using System;
namespace paradigm_shift_csharp
{
public class Checker
{
    static readonly float TemperatureUpperLimit = 45;
    static readonly float SocUpperLimit = 80;
    static readonly float ChargeRateUpperLimit = 0.8f;

    // Define warning tolerance as 5% of the upper limit
    static readonly float TemperatureWarningTolerance = TemperatureUpperLimit * 0.05f;
    static readonly float SocWarningTolerance = SocUpperLimit * 0.05f;
    static readonly float ChargeRateWarningTolerance = ChargeRateUpperLimit * 0.05f;

    
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
