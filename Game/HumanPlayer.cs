using RockPaperScissorsDI.Game;

namespace RockPaperScissorsDI;

public class HumanPlayer : IPlayer
{
    public Choice GetChoice()
    {
        Console.Write("Choose Rock [R], Paper [P] or Scissors [S] ");
        
        var input = Console.ReadLine();
        if (input == "r")
        {
            return Choice.Rock;
        }
    
        if (input == "p") 
        {
            return Choice.Paper;
        }
        if (input == "s") 
        {
            return Choice.Scissors;
        }
        return GetChoice();
    }
}