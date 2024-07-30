namespace paradigm_shift_csharp
{
public static class CheckerTemperature
{
        private const float TemperatureUpperLimit = 45.0f;
        private const float TemperatureWarningTolerance = 5.0f;
    static (bool, bool) IsTemperatureOutOfRange(float temperature)
    {
        return CheckerUtilities.CheckRangeAndWarning(temperature, TemperatureUpperLimit, TemperatureWarningTolerance);
    }

    static bool BatteryIsOkWithTemperature(float temperature)
    {
        var (isOutOfRange, isWarning) = IsTemperatureOutOfRange(temperature);
        if (isOutOfRange)
        {
            Console.WriteLine("Temperature is out of range!");
            return false;
        }
        if (isWarning)
        {
            Console.WriteLine("Warning: Temperature is approaching upper limit!");
        }
        return true;
    }
}
}
