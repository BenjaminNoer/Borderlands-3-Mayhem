# Borderlands-3-Mayhem
A tool that rerolls mayhem modifiers in Borderlands 3 using screenshots and an OCR.

This project uses the Tesseract library (https://tesseract.patagames.com/) and Input Simulator (https://archive.codeplex.com/?p=inputsimulator).

The tool takes screenshots of a specific area on the right side of the screen and uses Tesseract to read the text from the screenshot. Screenshots cannot be taken of the entire screen because the trial version of Tesseract only allows screenshots up to 500px wide. If the text does not include the names of the chosen modifiers, "Q" is pressed to reroll the modifiers.

Resolution needs to be specified so screenshots can be taken in the right place. If the game is in fullscreen use the game's resolution, but if the game is windowed use Window's resolution.

If the game is windowed make sure it fills the screen so the screenshots are still taken in the right place. I recommend using fullscreen for consistency.

This tool will not speed up the process of rerolling modifiers but will automate it so you can go do something else while the tool handles the boring part. Filling in all 4 options for the tool takes 15-45 minutes to reroll.

The tool does not work in resolutions above 1440p and only works in English.
