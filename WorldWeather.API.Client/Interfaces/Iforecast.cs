using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.DataStructure;

namespace WorldWeather.API.Client.Interfaces
{
	interface IForecast
	{
		DateTime IssueDate { get; }
		string TimeZone { get; }
		List<ForecastDay> ForecastDay { get; }
	}
}
