using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_KLAS.Models
{
	public class LectureNotice
	{
		public int NoticeId { get; set; }

		public string NoticeTitle { get; set; }

		public string NoticeContent { get; set; }

		public DateTime CreatedDate { get; set; }

		public int LectureId { get; set; }

		public string CreatedBy { get; set; }

		public int CourseId { get; set; }

		public int NoticeViewNumber { get; set; }

		public Course courses;

		public Lecturer lecturers;
	}
}
