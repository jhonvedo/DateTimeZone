using System;
using TimeZoneConverter;

namespace DTZone
{
    public static class TimeZoneService
    {        
        private static TimeZoneInfo _currentTimeZone = TimeZoneInfo.Local;

        public static void SetCustomTimeZone(DateTimeZoneType zoneName)
        {
            _currentTimeZone = GetTimeZoneInfo(zoneName);
        }
        public static void SetCustomTimeZone(string zoneName)
        {
            _currentTimeZone = GetTimeZoneInfo(zoneName);
        }
        public static TimeZoneInfo GetCustomTimeZone()
        {
            return _currentTimeZone;
        }

        public static TimeZoneInfo GetTimeZoneInfo(DateTimeZoneType zoneName)
        {            
            return GetTimeZoneInfo(zoneName.GetDescription());
        }

        public static TimeZoneInfo GetTimeZoneInfo(string zoneName)
        {
            TimeZoneInfo timeZoneInfo;
            try
            {
                timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(zoneName);
            }
            catch (Exception)
            {
                timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(TZConvert.WindowsToIana(zoneName));
            }
            return timeZoneInfo;
        }

    }
}