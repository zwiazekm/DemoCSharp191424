using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Tasks
{
    public abstract class Item
    {

    }

    public class ToDoItem:Item
    {
        private static int lastID=0;
        protected int taskID;
        public string Title { get; set; }
        public bool Done;
        private DateTime dueDate;

        static ToDoItem()
        {
            lastID = 100;
            Console.WriteLine("Static Constructor");
        }

        public ToDoItem()
        {
            Title = "Brak";
            DueDate = DateTime.Now.AddDays(1);
            taskID = NewID();
        }

        public ToDoItem(string title):this()
        {
            Title = title;
            //DueDate = DateTime.Now.AddDays(1);
            //TaskID = 1;
        }

        public ToDoItem(string title, DateTime date):this(title)
        {
            //Title = title;
            DueDate = date;
            //TaskID = 1;
        }

        public virtual string Info()
        {
            return $"Task:{TaskID}, Title: {Title}, Date: {DueDate.ToString("yyyy-MM-dd")}, Done:{Done}";
        }

        private static int NewID()
        {
            return ++lastID;
        }

        public static int LastID()
        {
            return lastID;
        }

        //Property
        public DateTime DueDate
        {
            get { return dueDate; }
            set {
                if (value < DateTime.Now)
                {
                    throw new FormatException("Bad Date.");
                }
                dueDate =value;
            }
        }

        public int TaskID
        {
            get { return taskID; }
        }

        public int DaysToEnd
        {
            get
            {
                return DateTime.Now.Subtract(dueDate).Days;
            }
        }

        //Destruktor
        ~ToDoItem()
        {
            Console.WriteLine($"Destrukcja {TaskID}");
        }

    }
}

