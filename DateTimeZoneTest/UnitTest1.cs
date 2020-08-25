using DateTimeZone;

using System;

using Xunit;

namespace DateTimeZoneTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestConvertToSydneyTime()
        {
            TimeZoneService.SetZone("AUS Eastern Standard Time");
            DateTime expectedTime = DateTime.UtcNow.AddHours(10);
            DateTime ausEast = System.DateTimeZone.Now;  

            Assert.Equal(expectedTime.Year, ausEast.Year);
            Assert.Equal(expectedTime.Month, ausEast.Month);
            Assert.Equal(expectedTime.Day, ausEast.Day);
            Assert.Equal(expectedTime.Hour, ausEast.Hour);
            Assert.Equal(expectedTime.Minute, ausEast.Minute);
            Assert.Equal(expectedTime.Second, ausEast.Second);
        }
    }
}
