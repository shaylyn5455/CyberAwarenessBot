using System;
/* S!--CODE ATTRIBUTION-->
<!--TITLE: Cyber awareness assistant - Chatbot.cs-->
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
    public class Chatbot
    {
        private string name;

        public void StartConversation()
        {
            UIManager ui = new UIManager();
            ui.TypeText("\nSystem Online. Please enter your name:", ConsoleColor.Yellow);
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name)) name = "User";

            ui.TypeText($"Hello {name}, I am ready to assist. Type 'phishing', 'password', or 'exit'.", ConsoleColor.Green);

            ChatLoop(ui);
        }

        private void ChatLoop(UIManager ui)
        {
            bool active = true;
            while (active)
            {
                Console.Write($"\n[{name}]: ");
                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrEmpty(input)) continue;

                if (input.Contains("phishing"))
                {
                    ui.TypeText("Bot: Phishing uses fake emails to steal data. Never click unknown links!", ConsoleColor.White);
                }
                else if (input.Contains("password"))
                {
                    ui.TypeText("Bot: Use strong passwords with 12+ characters, symbols, and numbers.", ConsoleColor.White);
                }
                else if (input.Contains("exit"))
                {
                    ui.TypeText("Bot: Secure logout complete. Goodbye!", ConsoleColor.Red);
                    active = false;
                }
                else
                {
                    ui.TypeText("Bot: I'm not sure. Try asking about 'phishing' or 'passwords'.", ConsoleColor.Gray);
                }
            }
        }
    }
}