using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreDemo.Database.NewFolder
{
	public class LoginDb
	{
		private static readonly DatabaseContext context = new DatabaseContext();
		public static bool IsCredentialsCorrect(string username, string password)
		{
			var user = context.User.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
			if (user == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
