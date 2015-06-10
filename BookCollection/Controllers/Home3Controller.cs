using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookCollection.Models;

namespace BookCollection.Controllers
{
	public class Home3Controller : Controller
	{
		public ActionResult ShowGrid()
		{
			ObservableCollection<Product> inventoryList = new ObservableCollection<Product>();

			inventoryList.Add(new Product { Id = "P101", Name = "Computer", Description = "All type of computers", Quantity = 800 });
			inventoryList.Add(new Product { Id = "P102", Name = "Laptop", Description = "All models of Laptops", Quantity = 500 });
			inventoryList.Add(new Product { Id = "P103", Name = "Camera", Description = "Hd  cameras", Quantity = 300 });
			inventoryList.Add(new Product { Id = "P104", Name = "Mobile", Description = "All Smartphones", Quantity = 450 });
			inventoryList.Add(new Product { Id = "P105", Name = "Notepad", Description = "All branded of notepads", Quantity = 670 });
			inventoryList.Add(new Product { Id = "P106", Name = "Harddisk", Description = "All type of Harddisk", Quantity = 1200 });
			inventoryList.Add(new Product { Id = "P107", Name = "PenDrive", Description = "All type of Pendrive", Quantity = 370 });

			return View("~/Views/Home3/ProductGrid.cshtml", inventoryList);
		}
	}
}
