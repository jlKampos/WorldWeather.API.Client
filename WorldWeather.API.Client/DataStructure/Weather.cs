using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWeather.API.Client.DataStructure
{
	public class Weather
	{
		City weatherForecast;

		[JsonProperty("city")]
		public City WeatherForecast
		{
			get { return weatherForecast; }
			internal set { weatherForecast = value; }
		}
	}
}
