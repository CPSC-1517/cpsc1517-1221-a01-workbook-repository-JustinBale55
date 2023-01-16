// See https://aka.ms/new-console-template for more information
using NhlSystemClassLibrary;

//prompt and read in the team name
//Console.Write("enter the team name:");
//string teamName = Console.ReadLine();
try
{
    //Create a new Team instance
    Team oilers = new Team("Oilers asd", "Edmonton", "Rogers Place", Conference.Western, Division.Pacific);

    //Print the Team Name
    //Console.WriteLine($"Team Name: {currentTeam.Name}");
    Console.WriteLine(oilers);
    //Console.WriteLine($"Name: {oilers.Name}, City: {oilers.City}, Arena: {oilers.Arena}");
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch
{
    Console.WriteLine("Incorrect exception thrown");
}

