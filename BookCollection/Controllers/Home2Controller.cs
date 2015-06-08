using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookCollection.Models;

namespace BookCollection.Controllers
{
	public class Home2Controller : Controller
	{

		#region ================================================== Private Methods ==================================================

		private void InitSession()
		{
			if (Session["DVDCollection"] == null)
			{
				Session["DVDCollection"] = new List<DVD>
				{
					new DVD()
					{
						Title = "Terminator 2",
						ProducerName = "James Cameron",
						PublishDate = new DateTime(1990, 3, 1)
					}
				};
			}
		}

		#endregion ================================================== Private Methods ==================================================




		#region ================================================== Public Methods ==================================================

		public ActionResult Index2()
		{
			InitSession();

			List<DVD> dvds = Session["DVDCollection"] as List<DVD>;

			return View(dvds);
		}




		[HttpGet]
		public ActionResult AddDVD()
		{
			return View();
		}




		[HttpPost]
		public ActionResult AddDVD(DVD dvd)
		{
			List<DVD> dvds = Session["DVDCollection"] as List<DVD>;

			dvds.Add(dvd);

			if (ModelState.IsValid)
			{
				return RedirectToAction("Index2");
			}
			else
			{
				return View();
			}
		}

		#endregion ================================================== Public Methods ==================================================

	}
}
