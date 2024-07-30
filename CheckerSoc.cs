namespace paradigm_shift_csharp
{
public class CheckerSoc
{
        private const float SocUpperLimit = 80.0f;
        private const float SocWarningTolerance = 10.0f;
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
