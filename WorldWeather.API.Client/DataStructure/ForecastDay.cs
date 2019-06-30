using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.Interfaces;

namespace WorldWeather.API.Client.DataStructure
{
	public class ForecastDay : IForecastDay
	{
		DateTime forecastDate;
		string wxdesc;
		string weather;
		double minTemp;
		double maxTemp;
		double minTempF;
		double maxTempF;
		int weatherIcon;

		[JsonProperty("forecastDate")]
		public DateTime ForecastDate
		{
			get { return forecastDate; }
			internal set { forecastDate = value; }
		}

		[JsonProperty("wxdesc")]
		public string Wxdesc
		{
			get { return wxdesc; }
			internal set { wxdesc = value; }
		}

		[JsonProperty("weather")]
		public string Weather
		{
			get { return weather; }
			internal set { weather = value; }
		}

		[JsonProperty("minTemp")]
		public double MinTemp
		{
			get { return minTemp; }
			internal set { minTemp = value; }
		}

		[JsonProperty("maxTemp")]
		public double MaxTemp
		{
			get { return maxTemp; }
			internal set { maxTemp = value; }
		}

		[JsonProperty("minTempF")]
		public double MinTempF
		{
			get { return minTempF; }
			internal set { minTempF = value; }
		}

		[JsonProperty("maxTempF")]
		public double MaxTempF
		{
			get { return maxTempF; }
			internal set { maxTempF = value; }
		}

		[JsonProperty("weatherIcon")]
		public int WeatherIcon
		{
			get { return weatherIcon; }
			internal set { weatherIcon = value; }
		}
	}
}
