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
