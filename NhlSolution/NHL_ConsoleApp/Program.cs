// See https://aka.ms/new-console-template for more information
using NhlSystemClassLibrary;

//prompt and read in the team name
Console.Write("enter the team name:");
string teamName = Console.ReadLine();
try
{
    //Create a new Team instance
    Team currentTeam = new Team(teamName);
    //Print the Team Name
    Console.WriteLine($"Team Name: {currentTeam.Name}");
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch
{
    Console.WriteLine("Incorrect exception thrown");
}

