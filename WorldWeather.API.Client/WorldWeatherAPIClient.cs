using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.DataStructure;
using WorldWeather.API.Client.Parsers;


namespace WorldWeather.API.Client
{
	public static class WorldWeatherAPIClient
	{

		readonly static string forecastURL = "http://worldweather.wmo.int/en/json/{0}_en.json";


		public static SortedDictionary<string, List<CityFromList>> GetLocations()
		{
			try
			{
				return WorldWeatherLocationsParser.GetLocations();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public static Task<SortedDictionary<string, List<CityFromList>>> GetLocationsAsync()
		{
			try
			{
				return WorldWeatherLocationsParser.GetLocationsAsync();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public static Weather GetCityForecast(int cityID)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
					string locations = webClient.DownloadString(string.Format(forecastURL, cityID));
					return JsonConvert.DeserializeObject<Weather>(locations);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static async Task<Weather> GetCityForecastAsync(int cityID)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
					string locations = await webClient.DownloadStringTaskAsync(string.Format(forecastURL, cityID)).ConfigureAwait(false);
					return JsonConvert.DeserializeObject<Weather>(locations);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
