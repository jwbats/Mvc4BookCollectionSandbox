using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookCollection.Models
{
	public class Book
	{
		[Required]
		public string AuthorName { get; set; }
		
		[Required]
		public string Title { get; set; }
		
		public string Publisher { get; set; }

		[DataType(DataType.Date)] // datetime picker only works on chrome
		public DateTime PublishDate { get; set; }
	}
}