namespace WorkerProject
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string WorkDay { get; set; }

        public Worker(string name)
        {
            Name = name;
            Position = "";
            WorkDay = "";
        }

        private void AddAction(string action)
        {
            WorkDay += (WorkDay == "" ? "" : ", ") + action;
        }

        public void Call() => AddAction("Call()");
        public void WriteCode() => AddAction("WriteCode()");
        public void Relax() => AddAction("Relax()");

        public abstract void FillWorkDay();
    }
}