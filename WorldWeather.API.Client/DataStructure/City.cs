using Newtonsoft.Json;
using WorldWeather.API.Client.Interfaces;

namespace WorldWeather.API.Client.DataStructure
{
	public class City : ICity
	{
		string lang;
		string cityName;
		double cityLatitude;
		double cityLongitude;
		int cityId;
		bool isCapital;
		string stationName;
		string tourismURL;
		string tourismBoardName;
		bool isDep;
		string timeZone;
		string isDST;
		Member member;
		Forecast forecast;
		Climate climate;

		[JsonProperty("lang")]
		public string Lang
		{
			get { return lang; }
			internal set { lang = value; }
		}

		[JsonProperty("cityName")]
		public string CityName
		{
			get { return cityName; }
			internal set { cityName = value; }
		}

		[JsonProperty("cityLatitude")]
		public double CityLatitude
		{
			get { return cityLatitude; }
			internal set { cityLatitude = value; }
		}

		[JsonProperty("cityLongitude")]
		public double CityLongitude
		{
			get { return cityLongitude; }
			internal set { cityLongitude = value; }
		}

		[JsonProperty("cityId")]
		public int CityLatitcityIdude
		{
			get { return cityId; }
			internal set { cityId = value; }
		}

		[JsonProperty("isCapital")]
		public bool IsCapital
		{
			get { return isCapital; }
			internal set { isCapital = value; }
		}

		[JsonProperty("stationName")]
		public string StationName
		{
			get { return stationName; }
			internal set { stationName = value; }
		}

		[JsonProperty("tourismURL")]
		public string TourismURL
		{
			get { return tourismURL; }
			internal set { tourismURL = value; }
		}

		[JsonProperty("tourismBoardName")]
		public string TourismBoardName
		{
			get { return tourismBoardName; }
			internal set { tourismBoardName = value; }
		}

		[JsonProperty("isDep")]
		public bool IsDep
		{
			get { return isDep; }
			internal set { isDep = value; }
		}

		[JsonProperty("timeZone")]
		public string TimeZone
		{
			get { return timeZone; }
			internal set { timeZone = value; }
		}

		[JsonProperty("isDST")]
		public string IsDST
		{
			get { return isDST; }
			internal set { isDST = value; }
		}

		[JsonProperty("member")]
		public Member Member
		{
			get { return member; }
			internal set { member = value; }
		}

		[JsonProperty("forecast")]
		public Forecast Forecast
		{
			get { return forecast; }
			internal set { forecast = value; }
		}

		[JsonProperty("climate")]
		public Climate Climate
		{
			get { return climate; }
			internal set { climate = value; }
		}
	}
}
