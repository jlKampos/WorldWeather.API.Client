
namespace WorldWeather.API.Client.Interfaces
{
	interface IClimateMonth
	{
		int Month { get; }

		string MaxTemp { get; }

		string MinTemp { get; }

		string MeanTemp { get; }

		string MaxTempF { get; }

		string MinTempF { get; }

		string MeanTempF { get; }

		string RainDays { get; }

		string RainFall { get; }
	}
}
