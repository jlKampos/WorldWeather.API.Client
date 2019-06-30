using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.DataStructure;

namespace WorldWeather.API.Client.Interfaces
{
	interface IClimate
	{
		string RainType { get; }

		string RainDef { get; }

		string RainUnit { get; }

		string DataB { get; }

		string DataE { get; }

		string TempB { get; }

		string TempE { get; }

		string rdayB { get; }

		string RdayE { get; }

		string RainfallB { get; }

		string RainfallE { get; }

		string ClimateFromClino { get; }

		List<ClimateMonth> ClimateMonth { get; }
	}
}
