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

        public bool GetCompleted() => _taskAskStatus;
				public string GetName() => _taskName;
				public string GetDescription() => _taskDescription;

				public void ToggleComplete()
				{
						_taskAskStatus = !_taskAskStatus;
				}
    }
}
