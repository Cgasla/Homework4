using System;

namespace WorkerProject
{
    public class Manager : Worker
    {
        private Random _random = new Random();

        public Manager(string name) : base(name)
        {
            Position = "Manager";
        }

        public override void FillWorkDay()
        {
            int callsBefore = _random.Next(1, 11); 
            for (int i = 0; i < callsBefore; i++)
                Call();

            Relax();

            int callsAfter = _random.Next(1, 6);
            for (int i = 0; i < callsAfter; i++)
                Call();
        }
    }
}