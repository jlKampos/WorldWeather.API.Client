using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.DataStructure;

namespace WorldWeather.API.Client.Interfaces
{
	interface IMember
	{
		int MemId { get; }

		string MemName { get; }

		string ShortMemName { get; }

		string URL { get; }

		string OrgName { get; }

		string Logo { get; }

		int RA { get; }
	}
}
