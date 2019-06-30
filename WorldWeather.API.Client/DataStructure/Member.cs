using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWeather.API.Client.Interfaces;

namespace WorldWeather.API.Client.DataStructure
{
	public class Member : IMember
	{
		int memId;
		string memName;
		string shortMemName;
		string url;
		string orgName;
		string logo;
		int ra;

		[JsonProperty("memId")]
		public int MemId
		{
			get { return memId; }
			internal set { memId = value; }
		}

		[JsonProperty("memName")]
		public string MemName
		{
			get { return memName; }
			internal set { memName = value; }
		}

		[JsonProperty("shortMemName")]
		public string ShortMemName
		{
			get { return shortMemName; }
			internal set { shortMemName = value; }
		}

		[JsonProperty("url")]
		public string URL
		{
			get { return url; }
			internal set { url = value; }
		}

		[JsonProperty("orgName")]
		public string OrgName
		{
			get { return orgName; }
			internal set { orgName = value; }
		}

		[JsonProperty("logo")]
		public string Logo
		{
			get { return logo; }
			internal set { logo = value; }
		}

		[JsonProperty("ra")]
		public int RA
		{
			get { return ra; }
			internal set { ra = value; }
		}

	}
}
