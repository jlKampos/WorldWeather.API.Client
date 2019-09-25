# WorldWeather.API.Client

##### **25-09-2019** 
Fixed regex pattern

**Functionalities Provided in this release**
```csharp

public static SortedDictionary<string, List<CityFromList>> GetLocations()
public static Task<SortedDictionary<string, List<CityFromList>>> GetLocationsAsync()
public static Weather GetCityForecast(int cityID)
public static async Task<Weather> GetCityForecastAsync(int cityID)

```

## Demo

```csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client;
using WorldWeather.API.Client.DataStructure;
using Newtonsoft.Json;


namespace TestWorldWeather
{
	class Program
	{
		static void Main(string[] args)
		{
			// demo
			var locs = Task.Run(() => GetCitiesFromCountryName("Russian Federation"));
			locs.Wait();
			List<CityFromList> cities = locs.Result;


			if (cities != null)
			{
				CityFromList city = cities.Where(x => x.Name.Equals("Moscow")).Single();
				var weather = Task.Run(() => WorldWeatherAPIClient.GetCityForecastAsync(city.ID));
				weather.Wait();
				DisplayWeather(weather.Result);
			}
			else
			{
				DisplayErrors("No cities found for the given country");
			}

			Console.WriteLine("End of demo");
			Console.Read();
		}


		static async Task<List<CityFromList>> GetCitiesFromCountryName(string input)
		{
			try
			{
				var locs = await WorldWeatherAPIClient.GetLocationsAsync();

				if (locs.ContainsKey(input.ToLower()))
				{
					// just a way to get the actual key
					string country = locs.Where(x => x.Key.ToLower().Equals(input.ToLower())).Select(x => x.Key).SingleOrDefault();
					locs.TryGetValue(country, out List<CityFromList> cities);
					return cities;

				}

				return null;

			}
			catch (Exception ex)
			{

				DisplayErrors(ex.Message);
				return null;
			}

		}

		static void DisplayWeather(Weather weather)
		{
			try
			{
				// using Newtonsoft.Json;
				// because this is a demo and i am lazy :-
				var weatherToJson = Newtonsoft.Json.JsonConvert.SerializeObject(weather, Formatting.Indented);
				Console.WriteLine(weatherToJson);

			}
			catch (Exception ex)
			{

				DisplayErrors(ex.Message);
			}
		}


		static void DisplayErrors(string message)
		{
			Console.WriteLine("Error Exception msg: {0}", message);
		}
	}
}

```


## Sample output

```json
{
  "city": {
    "lang": "en",
    "cityName": "Moscow",
    "cityLatitude": 55.833333,
    "cityLongitude": 37.616667,
    "cityId": 206,
    "isCapital": true,
    "stationName": "Moscow",
    "tourismURL": "www.russiatourism.ru/eng",
    "tourismBoardName": "Tourism Department",
    "isDep": false,
    "timeZone": "+0300",
    "isDST": "N",
    "member": {
      "memId": 107,
      "memName": "Russian Federation",
      "shortMemName": "",
      "url": "www.meteorf.ru",
      "orgName": "Russian Federal Service For Hydrometeorology and Environmental Monitoring (ROSHYDROMET)",
      "logo": "russian_logo.png",
      "ra": 2
    },
    "forecast": {
      "issueDate": "2019-09-25T10:05:00",
      "timeZone": "Local",
      "forecastDay": [
        {
          "forecastDate": "2019-09-26T00:00:00",
          "wxdesc": "",
          "weather": "Rain",
          "minTemp": 2.0,
          "maxTemp": 11.0,
          "minTempF": 36.0,
          "maxTempF": 52.0,
          "weatherIcon": 1401
        },
        {
          "forecastDate": "2019-09-27T00:00:00",
          "wxdesc": "",
          "weather": "Rain",
          "minTemp": 2.0,
          "maxTemp": 10.0,
          "minTempF": 36.0,
          "maxTempF": 50.0,
          "weatherIcon": 1401
        },
        {
          "forecastDate": "2019-09-28T00:00:00",
          "wxdesc": "",
          "weather": "Fine",
          "minTemp": 4.0,
          "maxTemp": 11.0,
          "minTempF": 39.0,
          "maxTempF": 52.0,
          "weatherIcon": 2501
        }
      ]
    },
    "climate": {
      "raintype": "PPT",
      "raindef": "",
      "rainunit": "mm",
      "datab": "",
      "datae": "",
      "tempb": "",
      "tempe": "",
      "rdayb": "",
      "rdaye": "",
      "rainfallb": "",
      "rainfalle": "",
      "climatefromclino": "",
      "climateMonth": [
        {
          "month": 1,
          "maxTemp": "-6.3",
          "minTemp": "-12.3",
          "meanTemp": "-9.3",
          "maxTempF": "20.7",
          "minTempF": "9.9",
          "meanTempF": "15.3",
          "raindays": "11",
          "rainfall": "42"
        },
        {
          "month": 2,
          "maxTemp": "-4.2",
          "minTemp": "-11.1",
          "meanTemp": "-7.7",
          "maxTempF": "24.4",
          "minTempF": "12.0",
          "meanTempF": "18.1",
          "raindays": "8",
          "rainfall": "36"
        },
        {
          "month": 3,
          "maxTemp": "1.5",
          "minTemp": "-5.6",
          "meanTemp": "-2.2",
          "maxTempF": "34.7",
          "minTempF": "21.9",
          "meanTempF": "28",
          "raindays": "8",
          "rainfall": "34"
        },
        {
          "month": 4,
          "maxTemp": "10.4",
          "minTemp": "1.7",
          "meanTemp": "5.8",
          "maxTempF": "50.7",
          "minTempF": "35.1",
          "meanTempF": "42.4",
          "raindays": "9",
          "rainfall": "44"
        },
        {
          "month": 5,
          "maxTemp": "18.4",
          "minTemp": "7.6",
          "meanTemp": "13.1",
          "maxTempF": "65.1",
          "minTempF": "45.7",
          "meanTempF": "55.6",
          "raindays": "8",
          "rainfall": "51"
        },
        {
          "month": 6,
          "maxTemp": "21.7",
          "minTemp": "11.5",
          "meanTemp": "16.6",
          "maxTempF": "71.1",
          "minTempF": "52.7",
          "meanTempF": "61.9",
          "raindays": "11",
          "rainfall": "75"
        },
        {
          "month": 7,
          "maxTemp": "23.1",
          "minTemp": "13.5",
          "meanTemp": "18.2",
          "maxTempF": "73.6",
          "minTempF": "56.3",
          "meanTempF": "64.8",
          "raindays": "12",
          "rainfall": "94"
        },
        {
          "month": 8,
          "maxTemp": "21.5",
          "minTemp": "12.0",
          "meanTemp": "16.4",
          "maxTempF": "70.7",
          "minTempF": "53.6",
          "meanTempF": "61.5",
          "raindays": "10",
          "rainfall": "77"
        },
        {
          "month": 9,
          "maxTemp": "15.4",
          "minTemp": "7.1",
          "meanTemp": "11.0",
          "maxTempF": "59.7",
          "minTempF": "44.8",
          "meanTempF": "51.8",
          "raindays": "11",
          "rainfall": "65"
        },
        {
          "month": 10,
          "maxTemp": "8.2",
          "minTemp": "2.1",
          "meanTemp": "5.1",
          "maxTempF": "46.8",
          "minTempF": "35.8",
          "meanTempF": "41.2",
          "raindays": "10",
          "rainfall": "59"
        },
        {
          "month": 11,
          "maxTemp": "1.1",
          "minTemp": "-3.3",
          "meanTemp": "-1.2",
          "maxTempF": "34.0",
          "minTempF": "26.1",
          "meanTempF": "29.8",
          "raindays": "12",
          "rainfall": "58"
        },
        {
          "month": 12,
          "maxTemp": "-3.5",
          "minTemp": "-8.6",
          "meanTemp": "-6.1",
          "maxTempF": "25.7",
          "minTempF": "16.5",
          "meanTempF": "21",
          "raindays": "12",
          "rainfall": "56"
        }
      ]
    }
  }
}
```
