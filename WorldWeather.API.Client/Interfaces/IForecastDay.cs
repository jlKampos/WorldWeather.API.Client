using System;

namespace WorldWeather.API.Client.Interfaces
{
	interface IForecastDay
	{
		DateTime ForecastDate { get; }
		string Wxdesc { get; }
		string Weather { get; }
		double MinTemp { get; }
		double MaxTemp { get; }
		double MinTempF { get; }
		double MaxTempF { get; }
		int WeatherIcon { get; }
	}
}
