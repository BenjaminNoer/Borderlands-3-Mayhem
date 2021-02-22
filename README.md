# Borderlands-3-Mayhem

-------------------- Introduction --------------------

This is a tool that rerolls mayhem modifiers in Borderlands 3 using screenshots 
and an OCR.

This project uses the Tesseract library (https://tesseract.patagames.com/) 
and Input Simulator (https://archive.codeplex.com/?p=inputsimulator).

The tool takes screenshots of a specific area on the right side of the 
screen and uses Tesseract to read the text from the screenshot. 
Screenshots cannot be taken of the entire screen because the trial 
version of Tesseract only allows screenshots up to 500px wide. 
If the text does not include the names of the chosen modifiers, 
"Q" is pressed to reroll the modifiers.

Demonstration on YouTube: https://youtu.be/T0JT-KRz5Yc
Code on GitHub: https://github.com/BenjoKazooie/Borderlands-3-Mayhem

-------------------- Before you start --------------------

This tool will not speed up the process of rerolling modifiers but will 
automate it so you can go do something else while the tool handles the 
boring part. Filling in all 4 options for the tool takes 15-45 minutes 
to reroll.

The tool does not work in resolutions above 1440p and only works in English. 
Resolutions above 1440p do not work because the maximum width of the 
screenshots is 500px. In resolutions higher than 1440p screenshots do 
not capture the entire text of some longer modifier names.

This tool has not been tested for and is not expected to work on Mac and Linux. 

-------------------- Instructions --------------------

1. Start the game

2. Load the character you want to change mayhem modifiers for

3. Open the mayhem menu

4. Tab out of the game and open the tool from the .exe file, no 
installation required

5. With the tool open, slect the mayhem level you will be using in game

6. Choose the mayhem modifiers you want for each slot. Leaving any blank will 
make the tool ignore that modifier when rerolling

7. (Optional) Changing the "Wait after start (seconds)" attribute will change 
the number of seconds the tool waits before taking screenshots and pressing 
"Q" after the start button is pressed. You can increas ethe time if you need 
extra time to tab into the game.

8. Choose your resolution for the tool. If your game is in fullscreen, 
choose your game's resolution. If your game is windowed, make sure the 
game fills your screen and choose Windows' resolution. I recommend 
using fullscreen for consistency.

9. Press the start button and tab into Borderlands 3 which should already 
have the mayhem menu open. After the time set in seconds on the tool it will 
start. The tool will automatically stop when it sees the modifiers you set.
