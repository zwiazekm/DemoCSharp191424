using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Szkolenie.Tasks;

namespace TasksRuntime
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilderDemo();  
            //EnumDemo();
            //InterfeaceDemo();

            Payment p1 = new Payment("Platnosc 1", DateTime.Now.AddDays(1), 200M);
            p1.charge += demoCharge;
            p1.charge += am => am * 0.2M;
            p1.onOverPayment += P1_onOverPayment;
            Payment p2 = new Payment("Platnosc 2", DateTime.Now.AddDays(1), 300M);
            p2.charge += demoCharge;

            p1.Interest2(a => a * 0.1M);
            p2.Interest2(demoCharge);
            p1.Interest3((a,d)=> { int days = DateTime.Now.Subtract(d).Days;
                return a * 0.1M * days;
            });
            p1.Interest();
            p1.Refund(300M);

            //ToDoWorker();
        }

        private static void P1_onOverPayment(object sender, EventArgs e)
        {
            Payment p = (Payment)sender;
            Console.WriteLine($"Nadplata w kwocie {p.Balance}");
        }

        private static decimal demoCharge(decimal am)
        {
            return am * 0.2M;
        }

        private static void InterfeaceDemo()
        {
            TaskMan tm = new TaskMan();

            ITaskManager itm = tm;
        }

        private static void EnumDemo()
        {
            TaskStatus ts = (TaskStatus)9;
            Console.WriteLine(ts);
            return;
        }

        private static void ToDoWorker()
        {
            try
            {
                ToDoItem td1 = new ToDoItem("Task 1")
                {
                    DueDate = DateTime.Now.AddDays(3)
                };

                ToDoItem td2 = td1;
                td2.Title += "; test";
                int nrZadania = td1.TaskID;
                ToDoItem td3 = new ToDoItem("Task 3", DateTime.Now);

                ProjectTask pt1 = new ProjectTask("Project task1", 1);
                pt1.Project = "Test project 1";
                pt1.Status = TaskStatus.Plan;

                //Console.WriteLine(td1.Info());
                //Console.WriteLine(td2.Info());
                //Console.WriteLine(td3.Info());
                //td1 = null;
                //td2 = null;

                Console.WriteLine(pt1.Info());
                ToDoItem td4 = pt1;
                
                Console.WriteLine(td4.Info());
                Console.WriteLine(td4);
                object obj1 = td4;
                Console.WriteLine(obj1.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Inny błąd");
            }
            GC.Collect();
            //System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Koniec");
        }

        static void StringBuilderDemo()
        {
            string tekst = "Test 1";
            tekst += "\n NOwy tekst";
            tekst = tekst.ToUpper();
            StringBuilder sb = new StringBuilder();
            sb.Append("Pierwsza linia");
            sb.AppendLine("Druga linia");

            sb.ToString();
        }
    }
}
