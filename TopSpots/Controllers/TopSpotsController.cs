using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using TopSpots.Models;
using Newtonsoft.Json;

namespace TopSpots.Controllers
{
    public class TopSpotsController : ApiController
    {
		[HttpGet, Route("api/topspots")]

		public IHttpActionResult GetAllTopSpots()
		{
			string TopSpots = File.ReadAllText("C:\\dev\\TopSpots\\TopSpots.json");

			//convert string above into an array of c# objects 
			TopSpot[] topSpotsArray = JsonConvert.DeserializeObject<TopSpot[]>(TopSpots);

			return Ok(topSpotsArray);
		}
	}
}
