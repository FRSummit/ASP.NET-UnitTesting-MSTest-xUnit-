using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UMS.Models
{
    public class Course
	{
		[Key]
		public int Id { get; set; }
		public String Title { get; set; }
		public float Credits { get; set; }
		public String Code { get; set; }

	}
}
