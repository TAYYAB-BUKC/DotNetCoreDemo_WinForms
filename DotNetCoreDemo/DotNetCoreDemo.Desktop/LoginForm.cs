using DotNetCoreDemo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetCoreDemo.Desktop
{
	public partial class LoginForm : Form
	{
		//Db db = new Db(AppSettings.ConnectionString());
		public LoginForm()
		{
			InitializeComponent();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			if (IsFormValid())
			{
				if (LoginService.CheckUserCredentials(UsernameTextBox.Text, PasswordTextBox.Text))
				{
					MessageBox.Show("Hurrah!!! Credentials are correct", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Credentials are not correct", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private bool IsFormValid()
		{
			if (UsernameTextBox.Text.Trim() == String.Empty)
			{
				MessageBox.Show("Username is required","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
				UsernameTextBox.Focus();
				return false;
			}
			if (PasswordTextBox.Text.Trim() == String.Empty)
			{
				MessageBox.Show("Password is required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				PasswordTextBox.Focus();
				return false;
			}
			return true;
		}
	}
}
