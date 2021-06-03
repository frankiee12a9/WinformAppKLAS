using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormsApp_KLAS.DataProvider
{
	public class Helper
	{
		public static string ConnectionHelper(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}
	}
}
