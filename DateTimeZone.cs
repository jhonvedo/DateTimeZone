using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimeZone
{
    public readonly struct DateTimeZone
    {
        public static DateTime Now { get => TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneService.GetTimeZone()); }

    }
}
