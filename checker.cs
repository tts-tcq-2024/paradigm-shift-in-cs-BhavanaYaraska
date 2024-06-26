using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
class Checker
{
       static bool IsTemperatureOutOfRange(float temperature) {
            return temperature < 0 || temperature > 45;
        }
        
        static bool IsSocOutOfRange(float soc) {
            return soc < 20 || soc > 80;
        }
        static bool IsChargeRateOutOfRange(float chargeRate) {
            return chargeRate > 0.8;
        }
        static bool BatteryIsOkWithTemperature(float temperature) {
            if (IsTemperatureOutOfRange(temperature)) {
                Console.WriteLine("Temperature is out of range!");
                return false;
            }
            return true;
        }
        static bool BatteryIsOkWithSoc(float soc) {
            if (IsSocOutOfRange(soc)) {
                Console.WriteLine("State of Charge is out of range!");
                return false;
            }
            return true;
        }
        static bool BatteryIsOkWithChargeRate(float chargeRate) {
           
            if (IsChargeRateOutOfRange(chargeRate)) {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            return true;
        }
    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(BatteryIsOkWithTemperature(25));
        ExpectTrue(BatteryIsOkWithSoc(70));
        ExpectTrue(BatteryIsOkWithChargeRate(0.7));
        ExpectFalse(BatteryIsOkWithTemperature(50));
        ExpectFalse(BatteryIsOkWithSoc(85));
        ExpectFalse(BatteryIsOkWithChargeRate(0.0));
        Console.WriteLine("All ok");
        return 0;
    }
    
}
}
