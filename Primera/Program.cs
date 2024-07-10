using Primera.Context;





while (true)
{
    Console.WriteLine("Enter command: Edit | Show \n x - for exit");
    string command = Console.ReadLine();
    
    if (command.ToLower() == "show")
    {
        ShowTeams();
        continue;
    }
    if (command.ToLower() == "edit")
    {
        EditStats();
        continue;
    }
    if (command.ToLower() == "x")
    {
      break;
    }
}

static void ShowTeams()
{
    using (var db = new PrimeraContext())
    {
        var teams = db.Teams.ToList();

        foreach (var team in teams)
        {
            Console.WriteLine(team);
        }
    }
}

static void EditStats()
{

    Console.WriteLine("Enter commands: [Name team]'");
    string nameteam = Console.ReadLine();
    Console.WriteLine("Enter commands: [w -wins | l - lose | d - draw]");
    string actionType = Console.ReadLine();
    Console.WriteLine("Enter commands: [x - quantity]'");
    int quantity = Convert.ToInt32(Console.ReadLine());
    
    using (var db = new PrimeraContext())
    {
        var team = db.Teams.FirstOrDefault((t)=> t.Name.ToLower() == nameteam.ToLower());

        if (team == null)
        {
            Console.WriteLine($"Team with name: {nameteam} is not exist");
            return;
        }

        switch (actionType.ToLower())
        {
            case "w":
                team.Wins += quantity;
                break;
            case "l":
                team.Lose += quantity;
                break;
            case "d":
                team.Draw += quantity;
                break;
            default:
                Console.WriteLine($"Command {actionType} is not correct!");
                break;
        }

        Console.WriteLine(team);
        //
        // if (new List<string>(){"w", "l", "d"}.Contains(actionType.ToLower()))
        // {
        //     db.SaveChanges();
        // }
        db.SaveChanges();

    }
    
    
    
    
    
    
}