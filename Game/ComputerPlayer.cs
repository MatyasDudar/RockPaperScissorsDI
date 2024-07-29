using RockPaperScissorsDI.Game;

namespace RockPaperScissorsDI;

public class ComputerPlayer : IPlayer
{
    private readonly Random _rgn = new();

    public Choice GetChoice()
    {
        return (Choice)_rgn.Next(0,3);
    }
}
