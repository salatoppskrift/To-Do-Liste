using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppMAndreasOgMartin
{
    internal class Task
    {
        private string _taskName;
        private string _taskDescription;
        private bool _taskAskStatus;

        public Task(string Name, string Description)
        {
            _taskName = Name;
            _taskDescription = Description;
            _taskAskStatus = false;

        }




        /*
        public void deleteTask()
        {

        }*/
    }
}
