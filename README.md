# WinLossTracker

This is to be used in conjunction with StreamLabs OBS, though it'll probably work with OBS just fine but I haven't confirmed.

When you first launch it, a file will be created on your desktop named 'KadeWinLoss.txt'. Create a Text Label in StreamLabs that reads from a file, and point it here. It will default to 0 - 0 - 0.

On the form, the box containing "{W} - {L} - {D}" is customizable. It will insert your Wins/Losses/Draws in place of the {W} etc. (first letter of whichever it is). You don't have to have them all, and you can add/change the existing text. 

*assuming a current record of 3 wins and 1 loss*

Example: Today's Record: {W} - {L} 

Output: Today's Record: 3 - 1

The keybinds are presently +, -, and * on the numpad. 

- You do not have to tab out to update. If you Win, press +... Lose, press -, Draw, press *
- Do not bind to keys that you use for in-game purposes, as this overrides that key. I'll possibly change that in the future, but this was built for myself and I'm fine with the way it is... If anyone uses this and isn't sure how to make that change, ask and I'll do it.
