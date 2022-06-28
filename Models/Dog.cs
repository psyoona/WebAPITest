using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace WebAPITest.Models
{
	public class Dog
	{
		public string Name { get; set; }

		public string Age { get; set; }

		public string Weight { get; set; }
	}
}