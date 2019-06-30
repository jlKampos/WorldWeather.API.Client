using WorldWeather.API.Client.Interfaces;

namespace WorldWeather.API.Client.DataStructure
{
	public class CityFromList : ICityFromList
	{
		int cityID;
		string city;

		public CityFromList()
		{
			cityID = 0;
			city = string.Empty;
		}


		public CityFromList(int id, string name)
		{
			cityID = id;
			city = name;
		}


		public int ID
		{
			get { return cityID; }
			internal set { cityID = value; }
		}

		public string Name
		{
			get { return city; }
			internal set { city = value; }
		}
	}
}

