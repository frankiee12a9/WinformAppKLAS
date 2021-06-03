using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_KLAS.Models
{
	public class Course
	{
		public int CourseId { get; set; }

		public string CourseName { get; set; }

		public int CourseCredit { get; set; }

		public string CourseType { get; set; }


		public int CourseEnroll { get; set; }

		public int ProfId { get; set; }

		public string ProfName { get; set; }
	}
}
