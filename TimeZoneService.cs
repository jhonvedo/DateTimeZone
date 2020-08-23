using System;
using System.Collections.Generic;
using System.Text;

using TimeZoneConverter;

namespace DateTimeZone
{
    public static class TimeZoneService
    {
        private static string _zoneId = TimeZoneInfo.Local.Id;

        public static void SetZone(string zoneName)
        {
            try
            {
                _ = TimeZoneInfo.FindSystemTimeZoneById(zoneName);
            }
            catch (Exception)
            {
                zoneName = TZConvert.WindowsToIana(zoneName);
            }
            _zoneId = zoneName;
        }
        public static TimeZoneInfo GetTimeZone()
        {
            return TimeZoneInfo.FindSystemTimeZoneById(_zoneId);
        }

    }
}