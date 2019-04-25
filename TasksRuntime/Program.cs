using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szkolenie.Tasks;

namespace TasksRuntime
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoItem td1 = new ToDoItem("Task 1")
            {
                DueDate = DateTime.Now.AddDays(3)
            };

            ToDoItem td2 = td1;
            td2.Title = "Nowy tytul";

            ToDoItem td3 = new ToDoItem("Task 3", DateTime.Now);

            Console.WriteLine(td1.Info());
            Console.WriteLine(td2.Info());
            Console.WriteLine(td3.Info());


        }
    }
}
