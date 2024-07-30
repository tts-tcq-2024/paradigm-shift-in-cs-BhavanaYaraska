namespace paradigm_shift_csharp
{
partial class CheckerChargeRate
{
     private const float ChargeRateUpperLimit = 2.0f;
     private const float ChargeRateWarningTolerance = 0.5f;
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
