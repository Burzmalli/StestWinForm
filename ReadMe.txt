StestWinForm

This program is a simple shuffle and card-draw simulator, specifically for 7-card opening hand games using "Land" and "Spell" type cards.

To use the program:
1. Enter any number into the Lands and Spells fields. The sum of the two fields must be greater than 0.

2. Enter the minimum "good" number of lands in the Min field, and the maximum "good" number of lands in the Max field. For instance, if your ideal hand is between 3 and 5 lands, then enter 3 in Min and 5 in Max.

3. Enter a number of games to simulate.

4. Enter a number of draws to perform after each opening hand. This is currently only useful if you check the "Report Individual Results" box. Otherwise, adding draws will just slow down the simulation.

5. Check the "Report Individual Results" box if you want to personally verify the results of each shuffle and opening hand. Otherwise, the results box will only display the stats for the simulated hands.

And that's it! I make no promises that this program will run well or without crashing. Entering unexpected values (such as 0 for all fields) will likely cause problems. There is nothing malicious in the software, though. Also, it isn't threaded. So once you start a simulation, you have to wait for it to finish or close and relaunch the software.