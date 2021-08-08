# Signum Vanity Address Generator
Vanity Address Generator for the Signum Blockchain Platform

![image](https://user-images.githubusercontent.com/60077909/128460412-67968bb3-13d0-48f8-8959-dad7535eda46.png)


## About
This program will help you search for a more unique/custom Signum address. 
Create your personalized Signum Address, like `S-FOOD-DGAE-5H63-HDFA8`, `S-98DJ-DGAE-5H63-HELLQ`, `S-GAME-STQP-493N-9JHLO`.
The limitations on this will be time and whether the character/word set length would actually find what you're looking for.

### Key features:
- Multithreaded search  (Select number of CPU threads to use)
- Multi-length word/char length.  (Helps increase entropy for more complex finds)
- Create a string of random characters or phrase using words for the output passphrase.
- Program will need a valid SRS node to make sure any address found is not already in use (currently listed major sponsored Signum Nodes)


# How it works
The program will need an up-to-date and valid SRS Node before the main search and options become available.  If this initial check fails then the program will not allow you to try and find a matching address and it's passphrase.


>Prerequisites: Currently supported OS is Windows x64 .  
Download the .exe file from the Github releases and run


## More Info
This program was developed with Visual Studio 2022 Preview with the targeted SDK is .NET 6 preview. 
  
Published releases will have the .NET sdk included in the executable to help mitigate any additional downloading of the framework. 
.NET 6 was chosen to help create future releases that would be compatible with OSX and/or linux in the future.

## Donate
If you like the efforts and sotware help buy me a coffee or beer!

`S-TGS2-BU2Q-DBFR-DNATE`

## Credits
The team that worked on QBundle software for BURST provided much of the groundwork to help me learn, update and modify their base code for this implementation.  Their original work was done in VB.net and i ported this to a C# implementation.

@HeosSacer
@Quibus
@SvlatCjelli
@Venkat Naidu
