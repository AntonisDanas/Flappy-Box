# Flappy-Box
My own version of the Flappy Bird Game, starring a box!

The game itself is, as I said, a clone of the flappy bird game with my own touches. Every asset is mostly done by me, including art
and music (to be added).

In this project I was mostly focused on creating a completely Object-Oriented game, where each class is independent from the others.
Every class defines only the functionality of the game object it controls. Lastly, there is the GameController that decides what
happens in each state of the main game.
There are 3 states in the main game, the Idle Mode, the Playing Mode and the Dead Mode. The idle mode is when the game is waiting for the
player to start the game. The playing mode is where the player is controling the bird (or box in my case). The dead mode is where 
the bird is dead, and the player can see his current score and his high score.
The game also uses Player Preferences so that it can store information about high scores and volume control, in between sessions.

