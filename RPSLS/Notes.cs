using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Notes
    {
        //"Hey! Want to play RSPLS?". Initiate game/welcome to game(make part of Main Menu)
        //Main Menu -Choose Single player or multiplayer                   -Writeline/Readline/userInput
        //Input number of AI(limit to two) or players                      -Writeline/Readline/userInput
        //Input player names(maybe able to do on player selection screen)  -Writeline/Readline/userInput
        //Choose number of rounds(minimum 3, maybe set at 3)               -Writeline/Readline/userInput
        //Display rules and table of win/loss conditions                   -Writeline/Readline
        //Run game -choose player gesture(possibly a random option)       
        //         -randomly choose AI gesture
        //         -compare gestures against a list to determine winner
        //         -Display result and winner for round
        //         -Increment points
        //Repeat game for 3 rounds
        //Determine winner and display message on screen
        //Either conclude or loop back to Main Menu(Exit option needed on loop)

        //Game class
        //Player class. ---Methods can be overriden for human or AI---
        //Gestures may need to be class with inheritance(maybe later)
        //Program class runs scenario

        //-------------------------------------------------------------------------------------------------------------------------------

        //GAMEFLOW: PLAIN ENGLISH
        //PROBLEM: HOW DO WE PLAY THIS GAME?!?!?!
        //●Welcome to the game
        //●Explain the rules 
        //●Select players - is this single player or multiplayer(human vs. human OR human vs. computer)
        //●Choose names(two player, each chooses name, single player, name your opponent)
        //●Select the number of rounds(best of)
        //●Display the gesture options
        //●Both players choose their gestures
        //●Compare the gestures!●Determine which gesture wins
        //●Track the score of who won the round!
        //●Check to see if either player has enough points to win
        //●If neither player has the winning score, repeat until someone does!
        //●Declare the winner!
        //●End the game or play again!MVP = MINIMUM VIABLE PRODUCT - get your program working first, then make it better! 
        
        //CLASSES NEEDED:
        //●Game class
        //●Player(PARENT)
        //●Human(CHILD OF Player)
        //●AI or Computer class (CHILD of Player)
    }
}
