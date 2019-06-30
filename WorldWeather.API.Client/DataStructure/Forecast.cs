using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.Interfaces;

namespace WorldWeather.API.Client.DataStructure
{
	public class Forecast : IForecast
	{
		DateTime issueDate;
		string timeZone;
		List<ForecastDay> forecastDay;

		[JsonProperty("issueDate")]
		public DateTime IssueDate
		{
			get { return issueDate; }
			internal set { issueDate = value; }
		}

		[JsonProperty("timeZone")]
		public string TimeZone
		{
			get { return timeZone; }
			internal set { timeZone = value; }
		}

		[JsonProperty("forecastDay")]
		public List<ForecastDay> ForecastDay
		{
			get { return forecastDay; }
			internal set { forecastDay = value; }
		}
	}
}
