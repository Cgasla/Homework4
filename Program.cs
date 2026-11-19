using System;
using System.Collections.Generic;
using WorkerProject;

class Program
{
    static List<Team> teams = new List<Team>();

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\n1 - Create a team");
            Console.WriteLine("2 - Add an employee to a team");
            Console.WriteLine("3 - Show team info");
            Console.WriteLine("4 - Show detailed team info");
            Console.WriteLine("0 - Exit");
            Console.Write("Your choice: ");

            switch (Console.ReadLine())
            {
                case "1": CreateTeam(); break;
                case "2": AddWorkerToTeam(); break;
                case "3": SelectTeam()?.PrintInfo(); break;
                case "4": SelectTeam()?.PrintDetailedInfo(); break;
                case "0": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void CreateTeam()
    {
        Console.Write("Team name: ");
        string name = Console.ReadLine();
        teams.Add(new Team(name));
        Console.WriteLine("Team created.");
    }

    static Team SelectTeam()
    {
        if (teams.Count == 0)
        {
            Console.WriteLine("Create a team first.");
            return null;
        }

        for (int i = 0; i < teams.Count; i++)
            Console.WriteLine($"{i + 1} - {teams[i].Name}");

        Console.Write("Team number: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1 && n <= teams.Count)
            return teams[n - 1];

        Console.WriteLine("Invalid number.");
        return null;
    }

    static void AddWorkerToTeam()
    {
        Team team = SelectTeam();
        if (team == null) return;

        Console.Write("Employee full name: ");
        string name = Console.ReadLine();

        Console.Write("Position (1 - Developer, 2 - Manager): ");
        string type = Console.ReadLine();

        Worker worker;
        if (type == "1") worker = new Developer(name);
        else if (type == "2") worker = new Manager(name);
        else
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        worker.FillWorkDay();
        team.AddWorker(worker);
        Console.WriteLine("Employee added.");
    }
}