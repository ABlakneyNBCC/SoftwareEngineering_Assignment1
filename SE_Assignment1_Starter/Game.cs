public class Game
{
    // TODO: Create a public property to store the HumanPlayer object

    // TODO: Create a public property to store the ComputerPlayer object

    // TODO: Create a constructor that accepts a HumanPlayer and ComputerPlayer
    // TODO: Assign the provided players to the corresponding properties

    // TODO: Create a method that controls the full game flow called Play()
    public void Play()
    {
        // TODO: Display the game settings at the start of the game
        // TODO: Print number of rounds
        // TODO: Print points needed to win
        // TODO: Print human player name
        // TODO: Print computer player name
        // TODO: Print all possible moves
        // YOU MUST USE THE VALUES FROM THE GAMESETTINGS CLASS, NO HARDCODING ANY VALUES!

        int round = 1;

        // TODO: Create a flag that tracks whether the game is over
        bool gameOver = false;

        // TODO: Loop while the game is not over AND rounds remain
        // YOU MUST USE THE VALUES FROM THE GAMESETTINGS CLASS, NO HARDCODING ANY VALUES!
        while (???)
        {
            // TODO: Display the current round number
            // "---- Round <round> ----"

            // TODO: Ask the human player to choose a move

            // TODO: Ask the computer player to choose a move

            // TODO: Determine the winner of the round
            string winner = DetermineWinner(); // EXPLAINED BELOW

            // TODO: If the human won the round:
            // TODO:   Increase the human player's score
            // TODO:   Display a message indicating the human won
            // <Human.Name> wins the round!


            // TODO: Else if the computer won the round:
            // TODO:   Increase the computer player's score
            // TODO:   Display a message indicating the computer won
            // <Computer.Name> wins the round!


            // TODO: Otherwise, the round is a tie
            // TODO: Display a tie message
            // It's a tie!

            // TODO: Move to the next round
            round = round + 1;

            // TODO: Display the current scores after the round
            // Score: <Human.Name> <Human.Score> - <Computer.Name> <Computer.Score>

            // TODO: Check if the human player has reached the points required to win
            // TODO: If so, end the game and announce the human as the winner
            // YOU MUST USE THE VALUE FROM THE GAMESETTINGS CLASS, NO HARDCODING ANY VALUES!
            // <Human.Name> has reached <points> points and wins the game!

            // TODO: Check if the computer player has reached the points required to win
            // TODO: If so, end the game and announce the computer as the winner
            // YOU MUST USE THE VALUE FROM THE GAMESETTINGS CLASS, NO HARDCODING ANY VALUES!
            // <Computer.Name> has reached <points> points and wins the game!
        }

        // TODO: If the game ended because rounds reach the maximum number rounds (no early winner):
        // TODO: Compare scores to determine who ended the game with the most points or handle a tie scenario
        // TODO: Display a message stating the result (one of the following):
        // <Human.Name> has more points!
        // <Computer.Name> has more points!
        // <Human.Name> and <Computer.Name> ended with equal points!

        // TODO: Display the final scores for both players
        // ---- FINAL SCORE ----
        // <Human.Name>: <Human.Score>
        // <Computer.Name>: <Computer.Score>
    }

    // TODO: Create a helper method that determines the winner of a single round called DetermineWinner()
    // When the winner is determined, return the winner's name
    // If it is a tie, return the GameSettings value for tie
    // YOU MUST USE THE VALUES FROM THE GAMESETTINGS CLASS, NO HARDCODING ANY VALUES IN THIS METHOD!
    private string DetermineWinner()
    {
        // TODO: If the human made an invalid move, the computer wins

        // TODO: If both players chose the same move, it's a tie

        // TODO: Check all winning combinations where the human beats the computer:
        // TODO: rock beats scissors
        // TODO: paper beats rock
        // TODO: scissors beats paper
        // If any of these are true, the human wins

        // TODO: If none of the above conditions are true, the computer wins

        return ""; // place holder
    }
}

