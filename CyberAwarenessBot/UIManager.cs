using System;
using System.Threading;

/* S!--CODE ATTRIBUTION-->
<!--TITLE: Cyber awareness assistant - UIManager.cs-->
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
    public class UIManager
    {
        public void DisplayHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
            ******************************************
            * CYBER AWARENESS ASSISTANT       *
            * VERSION 1.0                *
            ******************************************");
            Console.ResetColor();
        }

        public void TypeText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(25); // Simulates typing for Task 6
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}