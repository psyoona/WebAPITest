using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using Newtonsoft.Json;

namespace WebAPITest.Controllers
{
	public class TestController : ApiController
	{
		[HttpGet]
		[Route("test")]
		public string SaveData()
		{
			return JsonConvert.SerializeObject(new { Test = "test" });
		}
	}
}