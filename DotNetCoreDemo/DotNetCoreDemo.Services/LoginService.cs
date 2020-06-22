
using DotNetCoreDemo.Database.NewFolder;

namespace DotNetCoreDemo.Services
{
	public class LoginService
	{
		public static bool CheckUserCredentials(string username, string password)
		{
			return LoginDb.IsCredentialsCorrect(username, password);
		}
	}
}
