namespace RockPaperScissorsDI.Game;

public class GameManager(IPlayer player1, IPlayer player2)
{
    public Result Compare()
    {
        Choice p1 = player1.GetChoice();
        Console.WriteLine("Player 1 chose " + p1);
        Choice p2 = player2.GetChoice();
        Console.WriteLine("Player 2 chose " + p2);

        if ( p1 == p2) 
        {
            Console.WriteLine("It's a " + Result.tie);
            return Result.tie;
        }
        else if( 
            ( p1 == Choice.Rock && p2 == Choice.Scissors) || 
            ( p1 == Choice.Scissors && p2 == Choice.Paper) || 
            ( p1 == Choice.Paper && p2 == Choice.Rock))
            {
                Console.WriteLine("Player 1 " + Result.won);
                return Result.won;
            }
        else 
        {
            Console.WriteLine("Player 1 " + Result.lose);
            return Result.lose;
        }
    }
}

public enum Choice
{
    Rock,
    Paper,
    Scissors
}

public enum Result
{
    won,
    lose,
    tie
}