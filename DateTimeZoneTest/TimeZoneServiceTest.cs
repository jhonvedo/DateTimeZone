using DTZone;

using System;
using System.Linq;

using Xunit;

namespace DateTimeZoneTest
{
    public class TimeZoneServiceTest
    {
        [Fact]
        public void TestConvertToSydneyTime()
        {
            //TimeZoneService.SetCustomTimeZone("AUS Eastern Standard Time");
                                              //"AUS Eastern Standard Time"
            TimeZoneService.SetCustomTimeZone(DateTimeZoneType.CANBERRA_MELBOURNE_SYDNEY);
            DateTime expectedTime = DateTime.UtcNow.AddHours(10);
            DateTime ausEast = DateTimeZone.Now;  

            Assert.Equal(expectedTime.Year, ausEast.Year);
            Assert.Equal(expectedTime.Month, ausEast.Month);
            Assert.Equal(expectedTime.Day, ausEast.Day);
            Assert.Equal(expectedTime.Hour, ausEast.Hour);
            Assert.Equal(expectedTime.Minute, ausEast.Minute);
            Assert.Equal(expectedTime.Second, ausEast.Second);
        }

        [Fact]
        public void TestConvertForAllZones()
        {
            var values = Enum.GetValues(typeof(DateTimeZoneType)).Cast<DateTimeZoneType>();
            int failGetTime = 0;          
            foreach (var timeZone in values)
            {
                try
                {
                    _ = DateTimeZone.GetDateTime(timeZone);
                }
                catch (Exception)
                {
                    failGetTime++;
                }
            }

            Assert.Equal(0, failGetTime);         

        }



    }
}
