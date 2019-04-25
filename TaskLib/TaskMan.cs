﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Tasks
{
    public class TaskMan : ITaskManager
    {
        //ArrayList tasksar = new ArrayList();

        private List<ToDoItem> tasks = new List<ToDoItem>();

        public IEnumerable<ToDoItem> TaskList => tasks;

        public string Test
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void AddTask(ToDoItem item)
        {
            //tasksar.Add()
            tasks.Add(item);
        }

        public void DeleteTask(int taskID)
        {
            throw new NotImplementedException();
        }

        public List<string> UncompletedTask()
        {
            var wyn = from t in tasks
                      where t.Done == false
                      select t.ToString();
            //select new { name = t.Title, enddate = t.DueDate };
            var wyn2 = tasks.Where(t => t.Done == false).Select(t => t.ToString());
            return wyn.ToList();
        }
    }
}
