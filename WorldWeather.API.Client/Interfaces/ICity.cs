using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.DataStructure;

namespace WorldWeather.API.Client.Interfaces
{
	interface ICity
	{

		string Lang { get; }

		string CityName { get; }

		double CityLatitude { get; }

		double CityLongitude { get; }

		int CityLatitcityIdude { get; }

		bool IsCapital { get; }

		string StationName { get; }

		string TourismURL { get; }

		string TourismBoardName { get; }

		bool IsDep { get; }

		string TimeZone { get; }

		string IsDST { get; }

		Member Member { get; }
		Forecast Forecast { get; }

		Climate Climate { get; }
	}
}

