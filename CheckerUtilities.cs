namespace paradigm_shift_csharp
{
public static class CheckerUtilities
{
    public static (bool, bool) CheckRangeAndWarning(float value, float upperLimit, float warningTolerance)
    {
        bool isOutOfRange = value < 0 || value > upperLimit;
        bool isWarning = value >= upperLimit - warningTolerance && value <= upperLimit;
        return (isOutOfRange, isWarning);
    }
}
}
