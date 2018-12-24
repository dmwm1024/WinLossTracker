# WinLossTracker

This is to be used in conjunction with StreamLabs OBS, though it'll probably work with OBS just fine but I haven't confirmed.

When you first launch it, a file will be created on your desktop named 'KadeWinLoss.txt'. Create a Text Label in StreamLabs that reads from a file, and point it here. It will default to 0 - 0 - 0.

On the form, the box containing "{W} - {L} - {D}" is customizable. It will insert your Wins/Losses/Draws in place of the {W} etc. (first letter of whichever it is). You don't have to have them all, and you can add/change the existing text. 

*assuming a current record of 3 wins and 1 loss*
Example: Today's Record: {W} - {L} 
Output: Today's Record: 3 - 1

The keybinds are presently +, -, and * on the numpad. 
