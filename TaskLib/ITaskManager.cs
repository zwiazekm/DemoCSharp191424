using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Tasks
{
    public interface ITaskManager
    {
        void AddTask(ToDoItem item);

        void DeleteTask(int taskID);

        List<string> UncompletedTask();

        IEnumerable<ToDoItem> TaskList { get; }

        string Test { get; set; }
    }


}
