using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine(user.date.ToString());
            Console.WriteLine(user.Famalyname);

            user.Famalyname = "Ivanov";
            Console.WriteLine(user.Famalyname);

            Console.WriteLine(new string('-', 30));

            User user2 = new User("zott", "Vladimir", "Zotov", 41);
            Console.WriteLine(user2.date.ToString());
            Console.WriteLine(user2.Login);
            Console.WriteLine(user2.Name);
            Console.WriteLine(user2.Famalyname);
            Console.WriteLine(user2.Age);

            Console.ReadKey();
        }
    }
}
