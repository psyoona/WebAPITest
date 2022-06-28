using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Newtonsoft.Json;

namespace WebAPITest.Controllers
{
	public class TestController : ApiController
	{
		/*
		 * How to test
		 * Program: postman
		 * Request url: https://localhost:44336/data
		 */

		[HttpGet]
		[Route("data")]
		public string GetData()
		{
			string key = HttpContext.Current.Request.Params["key"];

			return JsonConvert.SerializeObject(new { Method = $"Get method: {key}" });
		}

		[HttpPost]
		[Route("data")]
		public string SaveData()
		{
			string key = HttpContext.Current.Request.Params["key"];

			return JsonConvert.SerializeObject(new { Method = $"Post method: {key}" });
		}
	}
}