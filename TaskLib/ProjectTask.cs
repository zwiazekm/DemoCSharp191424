using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Tasks
{
    public sealed class ProjectTask: ToDoItem
    {
        public string Project { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TaskNumber Number { get; private set; }
        public TaskStatus Status { get; set; }

        public ProjectTask(string title, int taskNumber):base(title)
        {
            TaskNumber nr = new TaskNumber();
            nr.Number = taskNumber;
            nr.Prefix = "Test";
            Number = nr;

        }

        public override string Info()
        {
                return $"Project TaskID:{TaskID}, TaskNR: {Number}" +
                $"Title: {Title}, Done:{Done}";
        }

        public string TaskNumbers()
        {
            return $"TaskID: {taskID}, TaskNumber{Number}";
        }

        public override string ToString()
        {
            return Info();
        }

        public  void EndTask()
        {
            Done = true;
        }
    }


}
