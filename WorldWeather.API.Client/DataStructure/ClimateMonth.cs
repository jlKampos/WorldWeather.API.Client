using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.Interfaces;

namespace WorldWeather.API.Client.DataStructure
{
	public class ClimateMonth : IClimateMonth
	{
		int month;
		string maxTemp;
		string minTemp;
		string meanTemp;
		string maxTempF;
		string minTempF;
		string meanTempF;
		string raindays;
		string rainfall;

		[JsonProperty("month")]
		public int Month
		{
			get { return month; }
			internal set { month = value; }
		}

		[JsonProperty("maxTemp")]
		public string MaxTemp
		{
			get { return maxTemp; }
			internal set { maxTemp = value; }
		}

		[JsonProperty("minTemp")]
		public string MinTemp
		{
			get { return minTemp; }
			internal set { minTemp = value; }
		}

		[JsonProperty("meanTemp")]
		public string MeanTemp
		{
			get { return meanTemp; }
			internal set { meanTemp = value; }
		}

		[JsonProperty("maxTempF")]
		public string MaxTempF
		{
			get { return maxTempF; }
			internal set { maxTempF = value; }
		}

		[JsonProperty("minTempF")]
		public string MinTempF
		{
			get { return minTempF; }
			internal set { minTempF = value; }
		}

		[JsonProperty("meanTempF")]
		public string MeanTempF
		{
			get { return meanTempF; }
			internal set { meanTempF = value; }
		}

		[JsonProperty("raindays")]
		public string RainDays
		{
			get { return raindays; }
			internal set { raindays = value; }
		}

		[JsonProperty("rainfall")]
		public string RainFall
		{
			get { return rainfall; }
			internal set { rainfall = value; }
		}
	}
}
