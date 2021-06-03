using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_KLAS.Models
{
	public class LoginInfo
	{
		public int StudentId { get; set; }

		public int LecturerId { get; set; }

		public string StudentPassword { get; set; }

		public string LecturerPassword { get; set; }

		public Lecturer Lecturer { get; set; }
		public Student Student { get; set; }
	}
}
