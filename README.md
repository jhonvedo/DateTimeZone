# DateTimeZone

Get the DateTime of a specific zone.

1. Set DateTimezone in your init class  (it take the local time zone for default) you can see the TimeZone list [here](https://dotnetfiddle.net/Ak4pht)

   ```c#
    TimeZoneService.SetZone("AUS Eastern Standard Time");
   ```

2. Use DateTimeZone:
	```c#
    	DateTime ausEast = System.DateTimeZone.Now;  
   ```
   

