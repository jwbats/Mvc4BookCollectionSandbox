using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookCollection.Models;

namespace BookCollection.Controllers
{
	public class HomeController : Controller
	{
		private void InitSession()
		{
			if (Session["BookCollection"] == null)
			{
				Session["BookCollection"] = new List<Book>();
			}
		}


		private void _AddBook(Book book)
		{
			InitSession();

			(Session["BookCollection"] as List<Book>).Add(book);
		}


		public ActionResult Index()
		{
			List<Book> books = (Session["BookCollection"] != null)
				? Session["BookCollection"] as List<Book>
				: new List<Book>();

			return View(books);
		}

		
		[HttpGet]
		public ActionResult AddBook()
		{
			return View();
		}

		
		[HttpPost]
		public ActionResult AddBook(Book book)
		{
			_AddBook(book);

			if (ModelState.IsValid)
				return RedirectToAction("Index");
			else
				return View();
		}
	}
}
