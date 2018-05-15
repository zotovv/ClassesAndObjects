using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Document
{
    class Title
    {
        string appellation;

        public string Appellation
        {
            private get 
            {
                if (appellation != null)
                    return appellation;
                else
                    return "Название книги отсутствует.";
            }

            set
            {
                appellation = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Appellation);
            Console.ForegroundColor = ConsoleColor.Gray;
        }


    }
}
