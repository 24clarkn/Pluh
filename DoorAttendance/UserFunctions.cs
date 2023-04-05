using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DoorAttendance
{
	public class UserFunctions : Form1
	{
		public static string GetUsersDirectory()
		{
            return Directory.GetCurrentDirectory() + "\\UserData\\UserDatabase.json";
		}

        public void CheckUserId(string UserId)
        {
            bool FoundUser = false;
            foreach (string User in UserData.CurrectDatabase.UsersList)
            {
                if (User.Contains(UserId))
                {
                    FoundUser = true;
                    string Name = User.Split('-')[1];

                    List<string> UsersToAdd = new List<string>();
                    string item = $"{Name} @ {DateTime.Now.ToString("hh:mm tt")}";
                    UsersToAdd.Add(item);

                    UserAttendanceList.Items.Add(UsersToAdd);

                    MessageBox.Show($"Good morning {Name}!");
                    break;
                }
            }

            if (!FoundUser)
            {
                MessageBox.Show($"No user with the UserId ({UserId}) found!");
            }
        }
	}

    public class UserData
    {
        public static UserData CurrectDatabase { get; set; }

        public string AdminCode { get; set; }
        public JArray UsersList { get; set; }
    }
}
