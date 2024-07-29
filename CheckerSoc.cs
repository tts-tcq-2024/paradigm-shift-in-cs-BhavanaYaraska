namespace paradigm_shift_csharp
{
partial class Checker
{
    static (bool, bool) IsSocOutOfRange(float soc)
    {
        return CheckRangeAndWarning(soc, SocUpperLimit, SocWarningTolerance);
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
}
}
