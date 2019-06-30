using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.Interfaces;

namespace WorldWeather.API.Client.DataStructure
{
	public class Climate : IClimate
	{
		string raintype;
		string raindef;
		string rainunit;
		string datab;
		string datae;
		string tempb;
		string tempe;
		string rdayb;
		string rdaye;
		string rainfallb;
		string rainfalle;
		string climatefromclino;
		List<ClimateMonth> climateMonth;

		[JsonProperty("raintype")]
		public string RainType
		{
			get { return raintype; }
			internal set { raintype = value; }
		}

		[JsonProperty("raindef")]
		public string RainDef
		{
			get { return raindef; }
			internal set { raindef = value; }
		}

		[JsonProperty("rainunit")]
		public string RainUnit
		{
			get { return rainunit; }
			internal set { rainunit = value; }
		}

		[JsonProperty("datab")]
		public string DataB
		{
			get { return datab; }
			internal set { datab = value; }
		}

		[JsonProperty("datae")]
		public string DataE
		{
			get { return datae; }
			internal set { datae = value; }
		}

		[JsonProperty("tempb")]
		public string TempB
		{
			get { return tempb; }
			internal set { tempb = value; }
		}

		[JsonProperty("tempe")]
		public string TempE
		{
			get { return tempe; }
			internal set { tempe = value; }
		}

		[JsonProperty("rdayb")]
		public string rdayB
		{
			get { return rdayb; }
			internal set { rdayb = value; }
		}

		[JsonProperty("rdaye")]
		public string RdayE
		{
			get { return rdaye; }
			internal set { rdaye = value; }
		}

		[JsonProperty("rainfallb")]
		public string RainfallB
		{
			get { return rainfallb; }
			internal set { rainfallb = value; }
		}

		[JsonProperty("rainfalle")]
		public string RainfallE
		{
			get { return rainfalle; }
			internal set { rainfalle = value; }
		}

		[JsonProperty("climatefromclino")]
		public string ClimateFromClino
		{
			get { return climatefromclino; }
			internal set { climatefromclino = value; }
		}

		[JsonProperty("climateMonth")]

		public List<ClimateMonth> ClimateMonth
		{
			get { return climateMonth; }
			internal set { climateMonth = value; }
		}
	}
}
