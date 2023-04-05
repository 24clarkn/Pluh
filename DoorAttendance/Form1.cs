using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DoorAttendance
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			// Set screen res
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            // Set Database
            string JsonFile = File.ReadAllText(UserFunctions.GetUsersDirectory());
            JObject UserDataJObject = JsonConvert.DeserializeObject<JArray>(JsonFile).ToObject<List<JObject>>().FirstOrDefault();
            UserData JUserData = UserDataJObject.ToObject<UserData>();
            UserData.CurrectDatabase = JUserData;
        }

		private void ButtonRemove_Click(object sender, EventArgs e)
		{
			bool flag = CodeInputBox.Text.Length == 0;
			if (!flag)
			{
				CodeInputBox.Text = CodeInputBox.Text.Remove(CodeInputBox.Text.Length - 1);
			}
		}

		private void ButtonOne_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length == 6)
                return;

            CodeInputBox.Text = CodeInputBox.Text + "1";
		}

		private void ButtonTwo_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length == 6)
                return;

            CodeInputBox.Text = CodeInputBox.Text + "2";
		}

		private void ButtonThree_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length == 6)
                return;

            CodeInputBox.Text = CodeInputBox.Text + "3";
		}

		private void ButtonFour_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length == 6)
                return;

            CodeInputBox.Text = CodeInputBox.Text + "4";
		}

		private void ButtonFive_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length == 6)
                return;

            CodeInputBox.Text = CodeInputBox.Text + "5";
		}

		private void ButtonSix_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length == 6)
                return;

            CodeInputBox.Text = CodeInputBox.Text + "6";
		}

		private void ButtonSeven_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length == 6)
                return;

            CodeInputBox.Text = CodeInputBox.Text + "7";
		}

		private void ButtonEight_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length == 6)
                return;

            CodeInputBox.Text = CodeInputBox.Text + "8";
		}

		private void ButtonNine_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length == 6)
                return;

            CodeInputBox.Text = CodeInputBox.Text + "9";
		}

		private void ButtonZero_Click(object sender, EventArgs e)
		{
			if (CodeInputBox.Text.Length == 6)
				return;

			CodeInputBox.Text = CodeInputBox.Text + "0";
		}

		private void ButtonSubmit_Click(object sender, EventArgs e)
		{
            if (CodeInputBox.Text.Length > 6)
            {
                MessageBox.Show($"UserId must be at exactly 6 numbers!");
            }
			else
			{
				UserFunctions UserFunctions = new UserFunctions();
                CodeInputBox.Text = string.Empty;
                UserFunctions.CheckUserId(CodeInputBox.Text);
            }
        }
	}
}
