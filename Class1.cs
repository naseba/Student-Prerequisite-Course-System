using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class UsersFile
    {
        public struct usier
        {

            public string Name;
            public string ID;
            public string Password;
            public string Finished_Courses;
            public string Courses_in_progress;
            public string Academic_Year;
        }

        public void WriteUser(usier s)
        {
            FileStream FW = new FileStream("User.Txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FW);

            SW.WriteLine(s.ID + "@" + s.Name + "@" + s.Password + "@" + s.Academic_Year + "#");

            SW.Close();
        }

        public bool CheckUser(usier s)
        {
            FileStream FR = new FileStream("User.Txt", FileMode.Open);
            StreamReader SR = new StreamReader(FR);
            string[] field, Recored;

            while (SR.Peek() != -1)
            {
                Recored = Console.ReadLine().Split('#');
                for (int i = 0; i < Recored.Length; i++)
                {
                    field = Recored[i].Split('@');
                    if ((s.Name.CompareTo(field[1]) == 0) && (s.Password.CompareTo(field[2]) == 0))
                        return true;
                }
            }
            return false;
            SR.Close();
        }

      
    }
        class AdminFile
        {
            public struct Admin
            {
                public string Name;
                public string Password;
            }
            public void WriteAdmin(Admin s)
            {
                FileStream FW = new FileStream("Admin.Txt", FileMode.Append);
                StreamWriter SW = new StreamWriter(FW);

                SW.WriteLine(s.Name + "@" + s.Password + "#");

                SW.Close();
            }


            public bool CheckAdmin(Admin s)
            {
                FileStream FR = new FileStream("Admin.Txt", FileMode.Open);
                StreamReader SR = new StreamReader(FR);
                string[] field, Recored;

                while (SR.Peek() != -1)
                {
                    Recored = Console.ReadLine().Split('#');
                    for (int i = 0; i < Recored.Length; i++)
                    {
                        field = Recored[i].Split('@');
                        if ((s.Name.CompareTo(field[0]) == 0) && (s.Password.CompareTo(field[1]) == 0))
                            return true;
                    }
                }
                return false;
                SR.Close();
            }
    }

}