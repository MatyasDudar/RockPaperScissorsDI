using RockPaperScissorsDI.Game;

namespace RockPaperScissorsDI.Test;
public class TestPlayer(Choice choice) : IPlayer
{
    public Choice GetChoice()
    {
        return choice;
    }
}