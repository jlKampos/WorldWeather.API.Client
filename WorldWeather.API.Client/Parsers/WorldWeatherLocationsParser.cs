using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WorldWeather.API.Client.DataStructure;

namespace WorldWeather.API.Client.Parsers
{
	public static class WorldWeatherLocationsParser
	{
		readonly static string urlLocations = "https://worldweather.wmo.int/en/json/full_city_list.txt";

		static async Task<SortedDictionary<string, List<CityFromList>>> ParseLocationsAsync(string locationsTXT)
		{
			try
			{
				return await Task.Run(() => Parser(locationsTXT)).ConfigureAwait(false);
			}
			catch (Exception)
			{

				throw;
			}
		}

		static SortedDictionary<string, List<CityFromList>> Parser(string locationsTXT)
		{
			try
			{
				SortedDictionary<string, List<CityFromList>> countriesHash = new SortedDictionary<string, List<CityFromList>>(StringComparer.OrdinalIgnoreCase);

				Regex rx = new Regex("\"(.*)\"\\;\"(.*)\"\\;\"(\\d+)\"");

				foreach (Match match in rx.Matches(locationsTXT))
				{
					string country = match.Groups[1].ToString();
					string city = match.Groups[2].ToString();
					int cityID = int.Parse(match.Groups[3].ToString());

					if (!countriesHash.ContainsKey(country))
					{
						List<CityFromList> cityList = new List<CityFromList>
						{
							new CityFromList(cityID, city)
						};
						countriesHash.Add(country, cityList);
					}
					else
					{
						List<CityFromList> cityList = new List<CityFromList>();
						countriesHash.TryGetValue(country, out cityList);
						cityList.Add(new CityFromList(cityID, city));

					}

				}

				return countriesHash;

			}
			catch (Exception)
			{

				throw;
			}
		}

		public static SortedDictionary<string, List<CityFromList>> GetLocations()
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
					string locations = webClient.DownloadString(urlLocations);
					return Parser(locations);
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		public static async Task<SortedDictionary<string, List<CityFromList>>> GetLocationsAsync()
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
					string locations = await webClient.DownloadStringTaskAsync(urlLocations);
					return await ParseLocationsAsync(locations).ConfigureAwait(false);
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

	}
}
