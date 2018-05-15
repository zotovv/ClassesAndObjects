using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Document
{
    class Content
    {
        string chapter;

        public string Chapter
        {
            private get
            {
                if (chapter != null)
                    return chapter;
                else
                    return "Содержимое книги отсутствует.";
            }

            set 
            {
                chapter = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Chapter);
            Console.ForegroundColor = ConsoleColor.Gray;
        }


    }

}
