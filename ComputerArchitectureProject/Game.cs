using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ComputerArchitectureProject
{
    internal class Game
    {
        public string GameTitle = "Computer Basics";
        //public static string JournalFile = "Journal.txt";
        //public static string Content = "(Empty File)";

        public void Start()
        {
            Title = "Choices";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = @"
 ______   ______   ___ __ __   ______   __  __   _________  ______   ______         _______   ________   ______    ________  ______   ______      
/_____/\ /_____/\ /__//_//_/\ /_____/\ /_/\/_/\ /________/\/_____/\ /_____/\      /_______/\ /_______/\ /_____/\  /_______/\/_____/\ /_____/\     
\:::__\/ \:::_ \ \\::\| \| \ \\:::_ \ \\:\ \:\ \\__.::.__\/\::::_\/_\:::_ \ \     \::: _  \ \\::: _  \ \\::::_\/_ \__.::._\/\:::__\/ \::::_\/_    
 \:\ \  __\:\ \ \ \\:.      \ \\:(_) \ \\:\ \:\ \  \::\ \   \:\/___/\\:(_) ) )_    \::(_)  \/_\::(_)  \ \\:\/___/\   \::\ \  \:\ \  __\:\/___/\   
  \:\ \/_/\\:\ \ \ \\:.\-/\  \ \\: ___\/ \:\ \:\ \  \::\ \   \::___\/_\: __ `\ \    \::  _  \ \\:: __  \ \\_::._\:\  _\::\ \__\:\ \/_/\\_::._\:\  
   \:\_\ \ \\:\_\ \ \\. \  \  \ \\ \ \    \:\_\:\ \  \::\ \   \:\____/\\ \ `\ \ \    \::(_)  \ \\:.\ \  \ \ /____\:\/__\::\__/\\:\_\ \ \ /____\:\ 
    \_____\/ \_____\/ \__\/ \__\/ \_\/     \_____\/   \__\/    \_____\/ \_\/ \_\/     \_______\/ \__\/\__\/ \_____\/\________\/ \_____\/ \_____\/ 
Welcome to the fun program that teaches you about the basics. (use the arrow keys to navigate the menu)";
            string[] options = { "Start", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
                default:
                    break;
            }

        }

        private void RunFirstChoice()
        {
            string prompt = "What would like you like to look at?";
            string[] options = { "MotherBoard", "CPU", "GPU", "RAM", "Storage" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    WriteLine("\nThe motherboard controls everything, it handles controls and holds it together. It is the " +
                        "main source of communication, and both the CPU and the motherboard are together in a ‘chipset’." +
                        " That is where other devices get plugged in if you don’t own a Bluetooth mouse, pen, or headphones. " +
                        "The motherboard, I like to refer to as the life of the computer, it runs everything and holds all " +
                        "the important things. If you need to remember the motherboard, think of it as glue that holds the " +
                        "project together.");
                    WriteLine("Press any key to return.");
                    ReadKey(true);
                    RunFirstChoice();

                    break;

                case 1:
                    WriteLine("\n CPU, which stands for central processing unit. The central processing unit is considered the " +
                        "brain of the computer. This is used to break down lines of code, in any type of language you use such as " +
                        "C#, C++, Python, or any other language, and turn them in to an assembly language. Which is a low-level " +
                        "programming language that directly communicates with the hardware of the computer. It is basically " +
                        "machine language, and this is how it executes what is being asked of it. It fetches, decodes, and follows" +
                        " those instructions. You can see that the CPU handles all those processes that a computer needs to handle." +
                        " So, I would say think about it like your brain and how you comprehend things in a certain way. " +
                        "You comprehend things in a totally different way than most and this is something that comprehends things " +
                        "differently from you.");
                    WriteLine("Press any key to return.");
                    ReadKey(true);
                    RunFirstChoice();

                    break;

                 case 2:
                    WriteLine("\nThis is used for those beautiful game play pictures, artist pieces as well as modeling pieces. " +
                        "GPUs are used to generate high-end visuals. They tend to communicate with the display monitor directly. " +
                        "You can see this in a lot of computers, monitors, phones, TVs, and handheld video games. Lots of these " +
                        "devices have a liquid display, OLED display, QLED display, 4KHD, etc. The best part about this one is that " +
                        "you can see it for yourself. If you have a Nintendo Switch and you go and buy the Nintendo Switch OLED model," +
                        " you’ll see a difference in the graphics being shown to you and the picture is clearer. I, for one, have " +
                        "seen the difference due to the fact that I have a Nintendo Switch Lite and a Nintendo Switch OLED model and " +
                        "the graphics are more vibrant and clearer on the OLED model. Here’s a quick lesson on OLED and QLED. OLED " +
                        "stands for organic light emitted diode and QLED stands for quantum light emitting diode. OLED are more " +
                        "preferred due to all they can accomplish and handle.");
                    WriteLine("Press any key to return.");
                    ReadKey(true);
                    RunFirstChoice();

                    break;

                case 3:
                    WriteLine("\nRAM which stands for random access memory. As far as memory goes, it how much it holds, I like " +
                        "to think of it as your long-term memory because it holds the short term while the storage is like the " +
                        "long term memory. Ram is also known as volatile memory, stores data regarding frequently accessed " +
                        "programs. Also, a reason as to why it’s called volatile memory is because it gets erased if the " +
                        "computer restarts. I have many frequently accessed programs on my computer that require so much RAM, " +
                        "like my other computer has 16 gb of RAM just hold some adobe programs. If you have too much on the RAM," +
                        " then your programs and games will run slower and that’s how it feels when you get too much information" +
                        " at once. You have to process it more because it’s a lot rather than when you receive a little amount " +
                        "of information. ");
                    WriteLine("Press any key to return.");
                    ReadKey(true);
                    RunFirstChoice();
                    break;

                case 4:
                    WriteLine("\nStorage is so important because it helps hold the programs and keep them on your computers. " +
                        "All computers need somewhere to store the data you create such as the word documents that you create or " +
                        "the code you make. You have either a hard disk drive or solid-state drive. Those are known as HDD and SSD. " +
                        "So, HDDs are made of an actual disk where data is stored and read by a mechanical arm. These are becoming" +
                        " more obsolete. SSDs are smaller and much faster than a hard drive because they don’t need the mechanical " +
                        "arm. I like to think of this as long-term memory because unless you wipe it, it’s there forever.");
                    WriteLine("Would you like to test your knowledge? yes or no: ");
                    ReadLine();
                    string playerAnswer = ReadLine().Trim().ToLower();
                    if (playerAnswer == "yes")
                    {
                        WriteLine("Great, Let's Go!");
                        Play();
                    }
                    else if (playerAnswer == "n0")
                    {
                        WriteLine("Well see you later.");
                        ExitGame();
                        ReadKey(true);
                    }
                    

                    break;

                    void Play()
                    {
                        Clear();
                        WriteLine("Pleas write your answers in lower case. :)");
                        WriteLine("True or False: Is the motherboard described as the brain of the computer?");
                        string playerAnswer = ReadLine();
                        if (playerAnswer == "false") 
                        {
                            WriteLine("Your answer is correct! The motherboard is the glue that holds it together.");
                        }
                        else if (playerAnswer == "true") 
                        {
                            WriteLine("Your answer is wrong. :( The CPU is the brain of the computer.");
                        }

                        WriteLine();

                        WriteLine("True or False: The CPU uses assembly langauge to break down complex like this one used to make this.");
                        string playerChoice = ReadLine();
                        if (playerChoice == "true") 
                        {
                            WriteLine("Your answer is correct! The CPU uses that language to break down all kinds of languages such as C#, C++, Python, etc.");
                        }
                        else if (playerChoice == "false")
                        {
                            WriteLine("Your answer is wrong. :( The CPU does use assembly language for things like this.");
                        }

                        WriteLine();

                        WriteLine("True or False: The GPU is known as the Graphic Process Unit.");
                        string playerSolution = ReadLine();
                        if (playerSolution == "false") 
                        {
                            WriteLine("Your answer is wrong. :( That is the name of GPU.");
                        }
                        else if (playerSolution == "true") 
                        {
                            WriteLine("Your answer is correct! That is what GPU stands for.");
                        }

                        WriteLine();

                        WriteLine("True or False: RAM is like long-term memory storage.");
                       string playerReply = ReadLine();
                        if (playerReply == "false") 
                        {
                            WriteLine("Your answer is correct! RAM is volatile memory so it is short-term memory.");
                        }
                        else if (playerReply == "true") 
                        {
                            WriteLine("Your answer is wrong. :( RAM is like the short-term memory");
                        }

                        WriteLine();

                        WriteLine("True or False: Storage only holds frequently opened programs.");
                        string playerResponse = ReadLine();
                        if (playerResponse == "false") 
                        {
                            WriteLine("Your answer is correct! Storage holds things like word documents and things like that.");
                            WriteLine("You may exit the game.");
                            ExitGame();
                            ReadKey(true);
                        }
                        else if (playerResponse == "true") 
                        {
                            WriteLine("Your answer is wrong. :( RAM holds the frequently opened programs, storage holds documents");
                            WriteLine("You may exit the game.");
                            ExitGame();
                            ReadKey(true);

                        }
                    }
            }
        }

        private void DisplayInfo()
        {
            Clear();
            WriteLine("This program was made by Maya K. Hunter");
            WriteLine("Press any key to return to the main menu.");
            WriteLine("Credits");
            WriteLine("https://textkool.com/en/ascii-art-generator?hl=default&vl=default&font=Swamp%20Land&text=Computer%20Basics");
            WriteLine("kevin kreamer - kreamer@centraltx.net");
            WriteLine("https://www.britannica.com/technology/computer");
            WriteLine("https://www.britannica.com/technology/digital-computer");
            WriteLine("https://www.tutorialspoint.com/what-are-the-elements-of-modern-computers#:~:text=A%20modern%20computer%20is%20an%20integrated%20system%20including,mathematical%20systems%20and%20endless%20integer%20or%20floating-point%20computations.");
            WriteLine("https://www.idtech.com/blog/parts-of-a-computer#:~:text=Whether%20it%27s%20a%20gaming%20system%20or%20a%20home,State%20Drive%20%28SSD%29%20or%20Hard%20Disk%20Drive%20%28HDD%29");
            WriteLine("https://www.digitaltrends.com/home-theater/qled-vs-oled-tv/#:~:text=%20QLED%20comes%20out%20on%20top%20on%20paper%2C,gaming%2C%20and%20might%20be%20better%20for%20your%20health.");
            ReadKey(true);
            RunMainMenu();
        }

        private void ExitGame()
        {
            WriteLine("\n Press any key to exit...");
            ReadKey(true);
        }
    }
}
