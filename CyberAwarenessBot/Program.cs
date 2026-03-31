using System;
/* S!--CODE ATTRIBUTION-->
<!--TITLE: Cyber awareness assistant - Program.cs-->
<--AUTHOR: (Adnan Yusra)->
SDATE: (31/03/2026)->
<--VERSION: (FIREST EDITION) --3
≤-AVAILABLE:
(https://advtechonline.sharepoint.com/:w:/r/sites/TertiaryStudents/_layouts/15/Doc.aspx?sour
/* * REFERENCE: Microsoft Learn (2024) - System.Media.SoundPlayer
 * URL: https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer
 * Purpose: Implements audio playback for Task 1.
 */
namespace CyberAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            UIManager ui = new UIManager();
            AudioManager audio = new AudioManager();
            Chatbot bot = new Chatbot();

            // Display Header first
            ui.DisplayHeader();

            // TASK 5: Input Validation (Password Gate)
            Console.Write("Enter Security Access Code: ");
            string accessCode = Console.ReadLine();

            if (accessCode == "user123")
            {
                ui.TypeText("\n[SUCCESS] Access Granted. System Initializing...", ConsoleColor.Green);

                // TASK 1: Play Audio after successful login
                audio.PlayGreeting();

                // TASK 3: Start Chatbot interaction
                bot.StartConversation();
            }
            else
            {
                ui.TypeText("\n[ERROR] Invalid Access Code. Access Denied.", ConsoleColor.Red);
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}