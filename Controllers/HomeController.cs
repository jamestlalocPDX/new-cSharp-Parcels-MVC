using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parcels.Solutions.Models;

namespace Parcels.Solutions.Controllers
{
    public class HomeController : Controller
    {
			[HttpGet("/")] 
			public ActionResult Home() { return View(); }

			[HttpGet("/parcel")]
			public ActionResult Parcel() { return View(); }
    
			[HttpPost("/reciept")]
			public ActionResult Form(int height, int width, int length, int weight)
			{
				Parcel newParcel = new Parcel(height, width, length, weight);
				int volume = newParcel.GetVolume();
				double cost = newParcel.GetCost();
				newParcel = new Parcel(height, width, length, weight, volume, cost);
				return RedirectToAction("Reciept", newParcel);
			}

			[HttpGet("/reciept")]
			public ActionResult Reciept() { return View(); }
		
		}
}
