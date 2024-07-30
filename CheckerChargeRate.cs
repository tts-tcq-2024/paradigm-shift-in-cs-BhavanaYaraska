namespace paradigm_shift_csharp
{
public static class CheckerChargeRate
{
     private const float ChargeRateUpperLimit = 2.0f;
     private const float ChargeRateWarningTolerance = 0.5f;
   public static (bool, bool) IsChargeRateOutOfRange(float chargeRate)
    {
        return CheckerUtilities.CheckRangeAndWarning(chargeRate, ChargeRateUpperLimit, ChargeRateWarningTolerance);
    }
    public static bool BatteryIsOkWithChargeRate(float chargeRate)
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
