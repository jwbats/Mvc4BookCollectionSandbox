using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookCollection.Models
{
	public class DVD
	{
		[Required]
		public string ProducerName { get; set; }
		
		[Required]
		public string Title { get; set; }
		
		[DataType(DataType.Date)] // datetime picker only works on chrome
		public DateTime PublishDate { get; set; }
	}
}