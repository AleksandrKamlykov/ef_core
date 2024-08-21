using Microsoft.EntityFrameworkCore;
using Primera.Context;



ShowTeams();

// while (true)
// {
//     Console.WriteLine("Enter command: Edit | Show \n x - for exit");
//     string command = Console.ReadLine();
//     
//     if (command.ToLower() == "show")
//     {
//         ShowTeams();
//         continue;
//     }
//     if (command.ToLower() == "edit")
//     {
//         EditStats();
//         continue;
//     }
//     if (command.ToLower() == "x")
//     {
//       break;
//     }
//}

static void ShowTeams()
{
    using (var db = new PrimeraContext())
    {
        var teams = db.Teams;
        var qs = teams.ToQueryString();
        
        Console.WriteLine(qs);

    var teamsList = teams.ToList();
        foreach (var team in teamsList)
        {
            Console.WriteLine(team);
        }
    }
}
