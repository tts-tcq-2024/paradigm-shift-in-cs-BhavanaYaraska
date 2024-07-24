namespace paradigm_shift_csharp
{
partial class Checker
{
    static (bool, bool) IsTemperatureOutOfRange(float temperature)
    {
        return CheckRangeAndWarning(temperature, TemperatureUpperLimit, TemperatureWarningTolerance);
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
