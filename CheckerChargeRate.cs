namespace paradigm_shift_csharp
{
public class Checker
{
    static (bool, bool) IsChargeRateOutOfRange(float chargeRate)
    {
        return CheckRangeAndWarning(chargeRate, ChargeRateUpperLimit, ChargeRateWarningTolerance);
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
}
}
