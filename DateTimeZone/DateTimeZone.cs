using DateTimeZone;

namespace System
{
    public readonly struct DateTimeZone
    {
        public static DateTime Now { get => TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneService.GetTimeZone()); }

    }
}
