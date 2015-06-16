using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BookCollection
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-1.11.3.js"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

			bundles.Add(new ScriptBundle("~/bundles/datatables").Include("~/Scripts/jquery.dataTables.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/home4index").Include("~/Scripts/home4index.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/bootstrap.css",
				"~/Content/style.css",
				"~/Content/dataTables/demo_table.css"
			));

		}
	}
}