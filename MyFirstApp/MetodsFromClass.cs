using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    enum Browser
    {
        Chrome,
        Firefox,
        IE
    } 

    class MetodsFromClass
    {
        public static void GenericCollectionCustomeClass()
        {
            List<User> Users = new List<User>();
            Users.Add(new User { Id = 1, Name = "Steve", Email = "lavr@stev.com", Phone = 333333 });
            Users.Add(new User { Id = 2, Name = "Stan", Email = "petro@cat.com", Phone = 44444 });
            Users.Add(new User { Id = 3, Name = "Dania", Email = "dania@lo.com", Phone = 55555 });

            var UsersList = from User in Users
                            where User.Id == 3
                            select User;
            foreach (var User in UsersList)
            {
                Console.WriteLine(User.Phone);
            }
            //foreach (var User in Users)
            //{
            //    Console.WriteLine(String.Format("The user {0} with Email {1} has Phone{2}", User.Name, User.Email, User.Phone));
            //}
        }
        public static void GenericCollection()
        {
            string[] user1 = new string[] { "Steve", "30", "slavryn@doc.com", "Chicago" };
            string[] user2 = new string[] { "Pavel", "20", "yn@doc.com", "Wisconsin" };
            string[] user3 = new string[] { "Carlos", "38", "sln@doc.com", "Orlando" };
            Dictionary<int, string[]> dictio = new Dictionary<int, string[]>();
            dictio.Add(1, user1);
            dictio.Add(2, user2);
            dictio.Add(3, user3);

            foreach (var value in dictio)
            {
                string[] usersInfo = value.Value;


                foreach (var user in usersInfo)
                {
                    Console.WriteLine("User on the List: " + user);
                }
            }
        }
        public static void NonGenericCollection()
        {
            Hashtable table = new Hashtable();
            table.Add("Username", "slavrynovych@springcm.com");
            table.Add("Password", "Gnhg765c");
            table.Add("Button", "Login");
            foreach (var key in table.Keys)
            {
                Console.WriteLine("Value for " + key + " is " + table[key]);
            }
            //Console.WriteLine("Username: " + table["Username"]);
            //Console.WriteLine("Password: " + table["Password"]);
            // Console.WriteLine("Button: " + table["Button"]);
            Console.ReadLine();
        }
        public static void ArrayExample()
        {
            int[] numbs = new int[] { 1, 3, 4 };
            foreach (var numb in numbs)
            {
                Console.WriteLine("What is the Fuck" + numb);
                Console.ReadLine();
            }
            string[] Tests = new string[] { "Docu", "Echo", "OneSpan" };
            for (int i = 0; i < Tests.Length; i++)
            {
                Console.WriteLine(Tests[i]);
                Console.ReadLine();
            }
        }
        public static String GetBrowsers(Browser browser)
        {
            if (browser == Browser.Chrome)
            {
                return "Chrome Browser opened";
            }
            else if (browser == Browser.Firefox)
            {
                return "Firefox is opened";
            }
            else
            {
                return "IE browser is opened";
            }
        }
    }
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Int64 Phone { get; set; }
    }
}
