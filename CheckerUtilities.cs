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
}
}
