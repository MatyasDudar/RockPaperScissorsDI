using RockPaperScissorsDI.Game;

namespace RockPaperScissorsDI.Test;

public class Tests
{
    [Test]
    [TestCase(Choice.Rock,Choice.Scissors,Result.won)]
    [TestCase(Choice.Rock,Choice.Paper,Result.lose)]
    [TestCase(Choice.Rock,Choice.Rock,Result.tie)]
    [TestCase(Choice.Scissors,Choice.Scissors,Result.tie)]
    [TestCase(Choice.Scissors,Choice.Paper,Result.won)]
    [TestCase(Choice.Scissors,Choice.Rock,Result.lose)]
    [TestCase(Choice.Paper,Choice.Scissors,Result.lose)]
    [TestCase(Choice.Paper,Choice.Paper,Result.tie)]
    [TestCase(Choice.Paper,Choice.Rock,Result.won)]
    public void FirstBeatsSecond(Choice firstPlayerChoice, Choice secondPlayerChoice, Result result)
    {
        GameManager gameManager = new GameManager(new TestPlayer(firstPlayerChoice), new TestPlayer(secondPlayerChoice));
        Assert.That(gameManager.Compare(), Is.EqualTo(result));
    }
}