using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_KLAS.Models
{
	public class LectureNote
	{
		public int LectureId { get; set; }

		public string LectureTitle { get; set; }

		public string LectureContent { get; set; }

		public DateTime LectureCreatedDate { get; set; }

		public int LectureViews { get; set; }

		public int CourseId { get; set; }

		public int LecturerId { get; set; }

		public string CreateBy { get; set; } // professor's name

		public List<Course> courses = new List<Course>();

		public List<Lecturer> lecturers = new List<Lecturer>();

	}
}
