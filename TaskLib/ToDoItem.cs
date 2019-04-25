using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Tasks
{
    public class ToDoItem
    {
        public static int LastID=0;
        public int TaskID;
        public string Title;
        public bool Done;
        public DateTime DueDate;

        static ToDoItem()
        {
            LastID = 100;
            Console.WriteLine("Static Constructor");
        }


        public ToDoItem()
        {
            Title = "Brak";
            DueDate = DateTime.Now.AddDays(1);
            TaskID = NewID();
        }

        public ToDoItem(string title):this()
        {
            Title = title;
            DueDate = DateTime.Now.AddDays(1);
            //TaskID = 1;
        }

        public ToDoItem(string title, DateTime date):this(title)
        {
            //Title = title;
            DueDate = date;
            //TaskID = 1;
        }

        public string Info()
        {
            return $"Task:{TaskID}, Title: {Title}, Date: {DueDate}, Done:{Done}";
        }

        public static int NewID()
        {
            return ++LastID;
        }

    }
}

