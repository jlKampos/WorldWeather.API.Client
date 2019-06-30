using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.DataStructure;

namespace WorldWeather.API.Client.Interfaces
{
	interface ICityFromList
	{
		int ID { get; }
		string Name { get; }

	}
}
