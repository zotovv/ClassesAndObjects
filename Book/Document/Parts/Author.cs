using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Document
{
    class Author
    {
        string name;

        public string Name
        {
           private get 
            {
                if (name != null)
                    return name;
                else
                    return "Имя автора отсутствует.";
            }

            set 
            {
                name = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

}
