using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    class User
    {
        string login, name, famalyname;
        int age;
        public readonly DateTime date;

        public string Login
        {
            set => login = value;
            get
            {
                if (login == null)
                    return "Поле не заполнено.";
                return login;
            }
        }

        public string Name
        {
            set => name = value;
            get
            {
                if (name == null)
                    return "Поле не заполнено.";
                return name;
            }
        }

        public string Famalyname
        {
            set => famalyname = value;
            get
            {
                if (famalyname == null)
                    return "Поле не заполнено.";
                return famalyname;
            }
        }

        public int Age
        {
            set => age = value;
            get
            {
                if (age <= 0)
                    return 25;
                return age;
            }
        }

        public User()
        {
            date = DateTime.Now;
        }

        public User(string login, string firstName, string lastName, int old)
        {
            this.login = login;
            this.name = firstName;
            this.famalyname = lastName;
            this.age = old;
            date = DateTime.Now;
        }
        
    }
}
