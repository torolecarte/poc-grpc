using System;

namespace ConsoleAppTimezoneTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan brazilBaseOffset = TimeSpan.Zero;
            try { 
                var tzWin = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                brazilBaseOffset = tzWin.BaseUtcOffset;
            }
            catch
            {
                var tzLinux = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
                tzLinux = TimeZoneInfo.FindSystemTimeZoneById("Brazil/East");
                brazilBaseOffset = tzLinux.BaseUtcOffset;
            }
            Console.WriteLine(System.TimeZoneInfo.Local.BaseUtcOffset != brazilBaseOffset);
            throw new InvalidTimeZoneException("A Timezone configurada no servidor não é Brasil.");

            Console.WriteLine("Hello World!");
            Console.WriteLine(System.TimeZoneInfo.Local.StandardName);
            Console.WriteLine(System.TimeZoneInfo.Local.BaseUtcOffset);
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
