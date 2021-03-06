﻿namespace DotNetCoreDemo.Desktop
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.ExitButton = new System.Windows.Forms.Button();
			this.LoginButton = new System.Windows.Forms.Button();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(36, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username: ";
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameTextBox.Location = new System.Drawing.Point(133, 38);
			this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(279, 26);
			this.UsernameTextBox.TabIndex = 0;
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.GhostWhite;
			this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ExitButton.Location = new System.Drawing.Point(285, 148);
			this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(88, 35);
			this.ExitButton.TabIndex = 3;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LoginButton
			// 
			this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LoginButton.Location = new System.Drawing.Point(168, 148);
			this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(88, 35);
			this.LoginButton.TabIndex = 2;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordTextBox.Location = new System.Drawing.Point(133, 92);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(279, 26);
			this.PasswordTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(36, 99);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password: ";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 198);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label label2;
	}
}