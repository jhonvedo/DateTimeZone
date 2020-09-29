# DateTimeZone

Get DateTime For custom TimeZone

## Set TimeZone from StartUp

1. Set DateTimezone in your init class  (it takes the local time zone for default) 

   ```c#
    TimeZoneService.SetCustomTimeZone("AUS Eastern Standard Time");
   ```

   or

   ```c#
    TimeZoneService.SetCustomTimeZone(DateTimeZoneType.CANBERRA_MELBOURNE_SYDNEY);
   ```

   you can see the TimeZone list [Here](#timeone-availables)

2. Use DateTimeZone:

  ```c#
   	DateTime ausEast = DateTimeByZone.Now;  
  ```

## Get DateTime for specific zone

```c#
   	DateTime limaDate =  DateTimeByZone.GetDateTime("SA Pacific Standard Time");  
```
  or
  ```c#
   	DateTime limaDate = DateTimeByZone.GetDateTime(DateTimeZoneType.BOGOTA_LIMA_QUITO_RIO_BRANCO); 
  ```


you can see the TimeZone list [Here](#timeone-availables)

## TimeZone availables

| Type                                          | UTC Standard Offset | Display Name                                      | Standard Name                   |
| --------------------------------------------- | ------------------- | ------------------------------------------------- | ------------------------------- |
| INTERNATIONAL_DATE_LINE_WEST                  | (UTC-12:00)         | International Date Line West                      | Dateline Standard Time          |
| COORDINATED_UNIVERSAL_TIME11                  | (UTC-11:00)         | Coordinated Universal Time-11                     | UTC-11                          |
| ALEUTIAN_ISLANDS                              | (UTC-10:00)         | Aleutian Islands                                  | Aleutian Standard Time          |
| HAWAII                                        | (UTC-10:00)         | Hawaii                                            | Hawaiian Standard Time          |
| MARQUESAS_ISLANDS                             | (UTC-09:30)         | Marquesas Islands                                 | Marquesas Standard Time         |
| ALASKA                                        | (UTC-09:00)         | Alaska                                            | Alaskan Standard Time           |
| COORDINATED_UNIVERSAL_TIME09                  | (UTC-09:00)         | Coordinated Universal Time-09                     | UTC-09                          |
| BAJA_CALIFORNIA                               | (UTC-08:00)         | Baja California                                   | Pacific Standard Time (Mexico)  |
| COORDINATED_UNIVERSAL_TIME08                  | (UTC-08:00)         | Coordinated Universal Time-08                     | UTC-08                          |
| PACIFIC_TIME_US_AND_CANADA                    | (UTC-08:00)         | Pacific Time (US & Canada)                        | Pacific Standard Time           |
| ARIZONA                                       | (UTC-07:00)         | Arizona                                           | US Mountain Standard Time       |
| CHIHUAHUA_LA_PAZ_MAZATLAN                     | (UTC-07:00)         | Chihuahua, La Paz, Mazatlan                       | Mountain Standard Time (Mexico) |
| MOUNTAIN_TIME_US_AND_CANADA                   | (UTC-07:00)         | Mountain Time (US & Canada)                       | Mountain Standard Time          |
| CENTRAL_AMERICA                               | (UTC-06:00)         | Central America                                   | Central America Standard Time   |
| CENTRAL_TIME_US_AND_CANADA                    | (UTC-06:00)         | Central Time (US & Canada)                        | Central Standard Time           |
| EASTER_ISLAND                                 | (UTC-06:00)         | Easter Island                                     | Easter Island Standard Time     |
| GUADALAJARA_MEXICO_CITY_MONTERREY             | (UTC-06:00)         | Guadalajara, Mexico City, Monterrey               | Central Standard Time (Mexico)  |
| SASKATCHEWAN                                  | (UTC-06:00)         | Saskatchewan                                      | Canada Central Standard Time    |
| BOGOTA_LIMA_QUITO_RIO_BRANCO                  | (UTC-05:00)         | Bogota, Lima, Quito, Rio Branco                   | SA Pacific Standard Time        |
| CHETUMAL                                      | (UTC-05:00)         | Chetumal                                          | Eastern Standard Time (Mexico)  |
| EASTERN_TIME_US_AND_CANADA                    | (UTC-05:00)         | Eastern Time (US & Canada)                        | Eastern Standard Time           |
| HAITI                                         | (UTC-05:00)         | Haiti                                             | Haiti Standard Time             |
| HAVANA                                        | (UTC-05:00)         | Havana                                            | Cuba Standard Time              |
| INDIANA_EAST                                  | (UTC-05:00)         | Indiana (East)                                    | US Eastern Standard Time        |
| TURKS_AND_CAICOS                              | (UTC-05:00)         | Turks and Caicos                                  | Turks and Caicos Standard Time  |
| ASUNCION                                      | (UTC-04:00)         | Asuncion                                          | Paraguay Standard Time          |
| ATLANTIC_TIME_CANADA                          | (UTC-04:00)         | Atlantic Time (Canada)                            | Atlantic Standard Time          |
| CARACAS                                       | (UTC-04:00)         | Caracas                                           | Venezuela Standard Time         |
| CUIABA                                        | (UTC-04:00)         | Cuiaba                                            | Central Brazilian Standard Time |
| GEORGETOWN_LA_PAZ_MANAUS_SAN_JUAN             | (UTC-04:00)         | Georgetown, La Paz, Manaus, San Juan              | SA Western Standard Time        |
| SANTIAGO                                      | (UTC-04:00)         | Santiago                                          | Pacific SA Standard Time        |
| NEWFOUNDLAND                                  | (UTC-03:30)         | Newfoundland                                      | Newfoundland Standard Time      |
| ARAGUAINA                                     | (UTC-03:00)         | Araguaina                                         | Tocantins Standard Time         |
| BRASILIA                                      | (UTC-03:00)         | Brasilia                                          | E. South America Standard Time  |
| CAYENNE_FORTALEZA                             | (UTC-03:00)         | Cayenne, Fortaleza                                | SA Eastern Standard Time        |
| CITY_OF_BUENOS_AIRES                          | (UTC-03:00)         | City of Buenos Aires                              | Argentina Standard Time         |
| GREENLAND                                     | (UTC-03:00)         | Greenland                                         | Greenland Standard Time         |
| MONTEVIDEO                                    | (UTC-03:00)         | Montevideo                                        | Montevideo Standard Time        |
| PUNTA_ARENAS                                  | (UTC-03:00)         | Punta Arenas                                      | Magallanes Standard Time        |
| SAINT_PIERRE_AND_MIQUELON                     | (UTC-03:00)         | Saint Pierre and Miquelon                         | Saint Pierre Standard Time      |
| SALVADOR                                      | (UTC-03:00)         | Salvador                                          | Bahia Standard Time             |
| COORDINATED_UNIVERSAL_TIME02                  | (UTC-02:00)         | Coordinated Universal Time-02                     | UTC-02                          |
| MIDATLANTIC__OLD                              | (UTC-02:00)         | Mid-Atlantic - Old                                | Mid-Atlantic Standard Time      |
| AZORES                                        | (UTC-01:00)         | Azores                                            | Azores Standard Time            |
| DUBLIN_EDINBURGH_LISBON_LONDON                | (UTC+00:00)         | Dublin, Edinburgh, Lisbon, London                 | GMT Standard Time               |
| MONROVIA_REYKJAVIK                            | (UTC+00:00)         | Monrovia, Reykjavik                               | Greenwich Standard Time         |
| SAO_TOME                                      | (UTC+00:00)         | Sao Tome                                          | Sao Tome Standard Time          |
| CASABLANCA                                    | (UTC+01:00)         | Casablanca                                        | Morocco Standard Time           |
| AMSTERDAM_BERLIN_BERN_ROME_STOCKHOLM_VIENNA   | (UTC+01:00)         | Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna  | W. Europe Standard Time         |
| BELGRADE_BRATISLAVA_BUDAPEST_LJUBLJANA_PRAGUE | (UTC+01:00)         | Belgrade, Bratislava, Budapest, Ljubljana, Prague | Central Europe Standard Time    |
| BRUSSELS_COPENHAGEN_MADRID_PARIS              | (UTC+01:00)         | Brussels, Copenhagen, Madrid, Paris               | Romance Standard Time           |
| SARAJEVO_SKOPJE_WARSAW_ZAGREB                 | (UTC+01:00)         | Sarajevo, Skopje, Warsaw, Zagreb                  | Central European Standard Time  |
| WEST_CENTRAL_AFRICA                           | (UTC+01:00)         | West Central Africa                               | W. Central Africa Standard Time |
| AMMAN                                         | (UTC+02:00)         | Amman                                             | Jordan Standard Time            |
| ATHENS_BUCHAREST                              | (UTC+02:00)         | Athens, Bucharest                                 | GTB Standard Time               |
| BEIRUT                                        | (UTC+02:00)         | Beirut                                            | Middle East Standard Time       |
| CAIRO                                         | (UTC+02:00)         | Cairo                                             | Egypt Standard Time             |
| CHISINAU                                      | (UTC+02:00)         | Chisinau                                          | E. Europe Standard Time         |
| DAMASCUS                                      | (UTC+02:00)         | Damascus                                          | Syria Standard Time             |
| HARARE_PRETORIA                               | (UTC+02:00)         | Harare, Pretoria                                  | South Africa Standard Time      |
| HELSINKI_KYIV_RIGA_SOFIA_TALLINN_VILNIUS      | (UTC+02:00)         | Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius     | FLE Standard Time               |
| KHARTOUM                                      | (UTC+02:00)         | Khartoum                                          | Sudan Standard Time             |
| TRIPOLI                                       | (UTC+02:00)         | Tripoli                                           | Libya Standard Time             |
| WINDHOEK                                      | (UTC+02:00)         | Windhoek                                          | Namibia Standard Time           |
| BAGHDAD                                       | (UTC+03:00)         | Baghdad                                           | Arabic Standard Time            |
| ISTANBUL                                      | (UTC+03:00)         | Istanbul                                          | Turkey Standard Time            |
| KUWAIT_RIYADH                                 | (UTC+03:00)         | Kuwait, Riyadh                                    | Arab Standard Time              |
| MINSK                                         | (UTC+03:00)         | Minsk                                             | Belarus Standard Time           |
| NAIROBI                                       | (UTC+03:00)         | Nairobi                                           | E. Africa Standard Time         |
| TEHRAN                                        | (UTC+03:30)         | Tehran                                            | Iran Standard Time              |
| ABU_DHABI_MUSCAT                              | (UTC+04:00)         | Abu Dhabi, Muscat                                 | Arabian Standard Time           |
| ASTRAKHAN_ULYANOVSK                           | (UTC+04:00)         | Astrakhan, Ulyanovsk                              | Astrakhan Standard Time         |
| BAKU                                          | (UTC+04:00)         | Baku                                              | Azerbaijan Standard Time        |
| PORT_LOUIS                                    | (UTC+04:00)         | Port Louis                                        | Mauritius Standard Time         |
| SARATOV                                       | (UTC+04:00)         | Saratov                                           | Saratov Standard Time           |
| TBILISI                                       | (UTC+04:00)         | Tbilisi                                           | Georgian Standard Time          |
| VOLGOGRAD                                     | (UTC+04:00)         | Volgograd                                         | Volgograd Standard Time         |
| YEREVAN                                       | (UTC+04:00)         | Yerevan                                           | Caucasus Standard Time          |
| KABUL                                         | (UTC+04:30)         | Kabul                                             | Afghanistan Standard Time       |
| ASHGABAT_TASHKENT                             | (UTC+05:00)         | Ashgabat, Tashkent                                | West Asia Standard Time         |
| ISLAMABAD_KARACHI                             | (UTC+05:00)         | Islamabad, Karachi                                | Pakistan Standard Time          |
| QYZYLORDA                                     | (UTC+05:00)         | Qyzylorda                                         | Qyzylorda Standard Time         |
| CHENNAI_KOLKATA_MUMBAI_NEW_DELHI              | (UTC+05:30)         | Chennai, Kolkata, Mumbai, New Delhi               | India Standard Time             |
| SRI_JAYAWARDENEPURA                           | (UTC+05:30)         | Sri Jayawardenepura                               | Sri Lanka Standard Time         |
| KATHMANDU                                     | (UTC+05:45)         | Kathmandu                                         | Nepal Standard Time             |
| ASTANA                                        | (UTC+06:00)         | Astana                                            | Central Asia Standard Time      |
| DHAKA                                         | (UTC+06:00)         | Dhaka                                             | Bangladesh Standard Time        |
| OMSK                                          | (UTC+06:00)         | Omsk                                              | Omsk Standard Time              |
| YANGON_RANGOON                                | (UTC+06:30)         | Yangon (Rangoon)                                  | Myanmar Standard Time           |
| BANGKOK_HANOI_JAKARTA                         | (UTC+07:00)         | Bangkok, Hanoi, Jakarta                           | SE Asia Standard Time           |
| BARNAUL_GORNOALTAYSK                          | (UTC+07:00)         | Barnaul, Gorno-Altaysk                            | Altai Standard Time             |
| HOVD                                          | (UTC+07:00)         | Hovd                                              | W. Mongolia Standard Time       |
| TOMSK                                         | (UTC+07:00)         | Tomsk                                             | Tomsk Standard Time             |
| BEIJING_CHONGQING_HONG_KONG_URUMQI            | (UTC+08:00)         | Beijing, Chongqing, Hong Kong, Urumqi             | China Standard Time             |
| PERTH                                         | (UTC+08:00)         | Perth                                             | W. Australia Standard Time      |
| TAIPEI                                        | (UTC+08:00)         | Taipei                                            | Taipei Standard Time            |
| ULAANBAATAR                                   | (UTC+08:00)         | Ulaanbaatar                                       | Ulaanbaatar Standard Time       |
| EUCLA                                         | (UTC+08:45)         | Eucla                                             | Aus Central W. Standard Time    |
| CHITA                                         | (UTC+09:00)         | Chita                                             | Transbaikal Standard Time       |
| OSAKA_SAPPORO_TOKYO                           | (UTC+09:00)         | Osaka, Sapporo, Tokyo                             | Tokyo Standard Time             |
| PYONGYANG                                     | (UTC+09:00)         | Pyongyang                                         | North Korea Standard Time       |
| SEOUL                                         | (UTC+09:00)         | Seoul                                             | Korea Standard Time             |
| ADELAIDE                                      | (UTC+09:30)         | Adelaide                                          | Cen. Australia Standard Time    |
| DARWIN                                        | (UTC+09:30)         | Darwin                                            | AUS Central Standard Time       |
| BRISBANE                                      | (UTC+10:00)         | Brisbane                                          | E. Australia Standard Time      |
| CANBERRA_MELBOURNE_SYDNEY                     | (UTC+10:00)         | Canberra, Melbourne, Sydney                       | AUS Eastern Standard Time       |
| GUAM_PORT_MORESBY                             | (UTC+10:00)         | Guam, Port Moresby                                | West Pacific Standard Time      |
| HOBART                                        | (UTC+10:00)         | Hobart                                            | Tasmania Standard Time          |
| LORD_HOWE_ISLAND                              | (UTC+10:30)         | Lord Howe Island                                  | Lord Howe Standard Time         |
| BOUGAINVILLE_ISLAND                           | (UTC+11:00)         | Bougainville Island                               | Bougainville Standard Time      |
| MAGADAN                                       | (UTC+11:00)         | Magadan                                           | Magadan Standard Time           |
| NORFOLK_ISLAND                                | (UTC+11:00)         | Norfolk Island                                    | Norfolk Standard Time           |
| SAKHALIN                                      | (UTC+11:00)         | Sakhalin                                          | Sakhalin Standard Time          |
| SOLOMON_IS_NEW_CALEDONIA                      | (UTC+11:00)         | Solomon Is., New Caledonia                        | Central Pacific Standard Time   |
| AUCKLAND_WELLINGTON                           | (UTC+12:00)         | Auckland, Wellington                              | New Zealand Standard Time       |
| COORDINATED_UNIVERSAL_TIME12                  | (UTC+12:00)         | Coordinated Universal Time+12                     | UTC+12                          |
| FIJI                                          | (UTC+12:00)         | Fiji                                              | Fiji Standard Time              |
| PETROPAVLOVSKKAMCHATSKY__OLD                  | (UTC+12:00)         | Petropavlovsk-Kamchatsky - Old                    | Kamchatka Standard Time         |
| CHATHAM_ISLANDS                               | (UTC+12:45)         | Chatham Islands                                   | Chatham Islands Standard Time   |
| COORDINATED_UNIVERSAL_TIME13                  | (UTC+13:00)         | Coordinated Universal Time+13                     | UTC+13                          |
| NUKUALOFA                                     | (UTC+13:00)         | Nuku'alofa                                        | Tonga Standard Time             |
| SAMOA                                         | (UTC+13:00)         | Samoa                                             | Samoa Standard Time             |
| KIRITIMATI_ISLAND                             | (UTC+14:00)         | Kiritimati Island                                 | Line Islands Standard Time      |

In non-windows systems the TimeZone name is different.
If the system is non-windows, this library will translate the TimeZone name for you