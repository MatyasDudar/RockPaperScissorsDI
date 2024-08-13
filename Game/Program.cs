using RockPaperScissorsDI;
using RockPaperScissorsDI.Game;

GameManager gameManager = new GameManager(new HumanPlayer(), new ComputerPlayer());
gameManager.Compare();
gameManager.Compare();