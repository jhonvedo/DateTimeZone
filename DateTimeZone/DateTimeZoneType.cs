﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DTZone
{
    public enum DateTimeZoneType
    {
        [Description("Dateline Standard Time")] INTERNATIONAL_DATE_LINE_WEST,
        [Description("UTC-11")] COORDINATED_UNIVERSAL_TIME11,
        [Description("Aleutian Standard Time")] ALEUTIAN_ISLANDS,
        [Description("Hawaiian Standard Time")] HAWAII,
        [Description("Marquesas Standard Time")] MARQUESAS_ISLANDS,
        [Description("Alaskan Standard Time")] ALASKA,
        [Description("UTC-09")] COORDINATED_UNIVERSAL_TIME09,
        [Description("Pacific Standard Time (Mexico)")] BAJA_CALIFORNIA,
        [Description("UTC-08")] COORDINATED_UNIVERSAL_TIME08,
        [Description("Pacific Standard Time")] PACIFIC_TIME_US_AND_CANADA,
        [Description("US Mountain Standard Time")] ARIZONA,
        [Description("Mountain Standard Time (Mexico)")] CHIHUAHUA_LA_PAZ_MAZATLAN,
        [Description("Mountain Standard Time")] MOUNTAIN_TIME_US_AND_CANADA,
        [Description("Central America Standard Time")] CENTRAL_AMERICA,
        [Description("Central Standard Time")] CENTRAL_TIME_US_AND_CANADA,
        [Description("Easter Island Standard Time")] EASTER_ISLAND,
        [Description("Central Standard Time (Mexico)")] GUADALAJARA_MEXICO_CITY_MONTERREY,
        [Description("Canada Central Standard Time")] SASKATCHEWAN,
        [Description("SA Pacific Standard Time")] BOGOTA_LIMA_QUITO_RIO_BRANCO,
        [Description("Eastern Standard Time (Mexico)")] CHETUMAL,
        [Description("Eastern Standard Time")] EASTERN_TIME_US_AND_CANADA,
        [Description("Haiti Standard Time")] HAITI,
        [Description("Cuba Standard Time")] HAVANA,
        [Description("US Eastern Standard Time")] INDIANA_EAST,
        [Description("Turks and Caicos Standard Time")] TURKS_AND_CAICOS,
        [Description("Paraguay Standard Time")] ASUNCION,
        [Description("Atlantic Standard Time")] ATLANTIC_TIME_CANADA,
        [Description("Venezuela Standard Time")] CARACAS,
        [Description("Central Brazilian Standard Time")] CUIABA,
        [Description("SA Western Standard Time")] GEORGETOWN_LA_PAZ_MANAUS_SAN_JUAN,
        [Description("Pacific SA Standard Time")] SANTIAGO,
        [Description("Newfoundland Standard Time")] NEWFOUNDLAND,
        [Description("Tocantins Standard Time")] ARAGUAINA,
        [Description("E. South America Standard Time")] BRASILIA,
        [Description("SA Eastern Standard Time")] CAYENNE_FORTALEZA,
        [Description("Argentina Standard Time")] CITY_OF_BUENOS_AIRES,
        [Description("Greenland Standard Time")] GREENLAND,
        [Description("Montevideo Standard Time")] MONTEVIDEO,
        [Description("Magallanes Standard Time")] PUNTA_ARENAS,
        [Description("Saint Pierre Standard Time")] SAINT_PIERRE_AND_MIQUELON,
        [Description("Bahia Standard Time")] SALVADOR,
        [Description("UTC-02")] COORDINATED_UNIVERSAL_TIME02,
        [Description("Mid-Atlantic Standard Time")] MIDATLANTIC_OLD,
        [Description("Azores Standard Time")] AZORES,         
        [Description("GMT Standard Time")] DUBLIN_EDINBURGH_LISBON_LONDON,
        [Description("Greenwich Standard Time")] MONROVIA_REYKJAVIK,
        [Description("Sao Tome Standard Time")] SAO_TOME,
        [Description("Morocco Standard Time")] CASABLANCA,
        [Description("W. Europe Standard Time")] AMSTERDAM_BERLIN_BERN_ROME_STOCKHOLM_VIENNA,
        [Description("Central Europe Standard Time")] BELGRADE_BRATISLAVA_BUDAPEST_LJUBLJANA_PRAGUE,
        [Description("Romance Standard Time")] BRUSSELS_COPENHAGEN_MADRID_PARIS,
        [Description("Central European Standard Time")] SARAJEVO_SKOPJE_WARSAW_ZAGREB,
        [Description("W. Central Africa Standard Time")] WEST_CENTRAL_AFRICA,
        [Description("Jordan Standard Time")] AMMAN,
        [Description("GTB Standard Time")] ATHENS_BUCHAREST,
        [Description("Middle East Standard Time")] BEIRUT,
        [Description("Egypt Standard Time")] CAIRO,
        [Description("E. Europe Standard Time")] CHISINAU,
        [Description("Syria Standard Time")] DAMASCUS,   
        [Description("South Africa Standard Time")] HARARE_PRETORIA,
        [Description("FLE Standard Time")] HELSINKI_KYIV_RIGA_SOFIA_TALLINN_VILNIUS,      
        [Description("Sudan Standard Time")] KHARTOUM,
        [Description("Libya Standard Time")] TRIPOLI,
        [Description("Namibia Standard Time")] WINDHOEK,
        [Description("Arabic Standard Time")] BAGHDAD,
        [Description("Turkey Standard Time")] ISTANBUL,
        [Description("Arab Standard Time")] KUWAIT_RIYADH,
        [Description("Belarus Standard Time")] MINSK,    
        [Description("E. Africa Standard Time")] NAIROBI,
        [Description("Iran Standard Time")] TEHRAN,
        [Description("Arabian Standard Time")] ABU_DHABI_MUSCAT,
        [Description("Astrakhan Standard Time")] ASTRAKHAN_ULYANOVSK,
        [Description("Azerbaijan Standard Time")] BAKU,   
        [Description("Mauritius Standard Time")] PORT_LOUIS,
        [Description("Saratov Standard Time")] SARATOV,
        [Description("Georgian Standard Time")] TBILISI,
        [Description("Volgograd Standard Time")] VOLGOGRAD,
        [Description("Caucasus Standard Time")] YEREVAN,
        [Description("Afghanistan Standard Time")] KABUL,
        [Description("West Asia Standard Time")] ASHGABAT_TASHKENT,     
        [Description("Pakistan Standard Time")] ISLAMABAD_KARACHI,
        [Description("Qyzylorda Standard Time")] QYZYLORDA,
        [Description("India Standard Time")] CHENNAI_KOLKATA_MUMBAI_NEW_DELHI,
        [Description("Sri Lanka Standard Time")] SRI_JAYAWARDENEPURA,
        [Description("Nepal Standard Time")] KATHMANDU,
        [Description("Central Asia Standard Time")] ASTANA,
        [Description("Bangladesh Standard Time")] DHAKA,
        [Description("Omsk Standard Time")] OMSK,
        [Description("Myanmar Standard Time")] YANGON_RANGOON,
        [Description("SE Asia Standard Time")] BANGKOK_HANOI_JAKARTA,
        [Description("Altai Standard Time")] BARNAUL_GORNOALTAYSK,
        [Description("W. Mongolia Standard Time")] HOVD,   
        [Description("Tomsk Standard Time")] TOMSK,
        [Description("China Standard Time")] BEIJING_CHONGQING_HONG_KONG_URUMQI,       
        [Description("W. Australia Standard Time")] PERTH,
        [Description("Taipei Standard Time")] TAIPEI,
        [Description("Ulaanbaatar Standard Time")] ULAANBAATAR,
        [Description("Aus Central W. Standard Time")] EUCLA,
        [Description("Transbaikal Standard Time")] CHITA,
        [Description("Tokyo Standard Time")] OSAKA_SAPPORO_TOKYO,
        [Description("North Korea Standard Time")] PYONGYANG,
        [Description("Korea Standard Time")] SEOUL,   
        [Description("Cen. Australia Standard Time")] ADELAIDE,
        [Description("AUS Central Standard Time")] DARWIN,
        [Description("E. Australia Standard Time")] BRISBANE,
        [Description("AUS Eastern Standard Time")] CANBERRA_MELBOURNE_SYDNEY,
        [Description("West Pacific Standard Time")] GUAM_PORT_MORESBY,
        [Description("Tasmania Standard Time")] HOBART,     
        [Description("Lord Howe Standard Time")] LORD_HOWE_ISLAND,
        [Description("Bougainville Standard Time")] BOUGAINVILLE_ISLAND,       
        [Description("Magadan Standard Time")] MAGADAN,
        [Description("Norfolk Standard Time")] NORFOLK_ISLAND,
        [Description("Sakhalin Standard Time")] SAKHALIN,
        [Description("Central Pacific Standard Time")] SOLOMON_IS_NEW_CALEDONIA, 
        [Description("New Zealand Standard Time")] AUCKLAND_WELLINGTON,
        [Description("UTC+12")] COORDINATED_UNIVERSAL_TIME12,
        [Description("Fiji Standard Time")] FIJI,
        [Description("Kamchatka Standard Time")] PETROPAVLOVSKKAMCHATSKY_OLD,
        [Description("Chatham Islands Standard Time")] CHATHAM_ISLANDS,
        [Description("UTC+13")] COORDINATED_UNIVERSAL_TIME13,
        [Description("Tonga Standard Time")] NUKUALOFA,
        [Description("Samoa Standard Time")] SAMOA,
        [Description("Line Islands Standard Time")] KIRITIMATI_ISLAND
    }
}
