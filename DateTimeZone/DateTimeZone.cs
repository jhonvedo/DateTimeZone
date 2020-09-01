﻿using DTZone;

namespace System
{
    public readonly struct DateTimeZone
    {
        public static DateTime Now { get => TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneService.GetCustomTimeZone()); }

        public static DateTime GetDateTime(DateTimeZoneType timeZoneType)
        {
            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneService.GetTimeZoneInfo(timeZoneType));
        }

        public static DateTime GetDateTime(string timeZoneType)
        {
            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneService.GetTimeZoneInfo(timeZoneType));
        }

    }
}
