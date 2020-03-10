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
			public ActionResult Package() { return View(); }
    
			[HttpPost("/receipt")]
			public ActionResult Form(int height, int width, int length, int weight)
			{
				Parcel newParcel = new Parcel(height, width, length, weight);
				int volume = newParcel.GetVolume();
				double cost = newParcel.GetCost();
				Parcel.ClearParcel();
				newParcel = new Parcel(height, width, length, weight, volume, cost);
				return RedirectToAction("Receipt");
			}

			[HttpGet("/receipt")]
			public ActionResult Receipt()
			{ 
				List<Parcel> newParcelList = Parcel.ShowParcel();
				return View(newParcelList); 
			}
		
		}
}
