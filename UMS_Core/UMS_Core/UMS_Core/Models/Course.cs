using System;
using System.ComponentModel.DataAnnotations;

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
