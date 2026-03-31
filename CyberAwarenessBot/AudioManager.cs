using System;
using System.IO;
using System.Media;

/* S!--CODE ATTRIBUTION-->
<!--TITLE: Cyber awareness assistant - AudioManager.cs-->
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
    public class AudioManager
    {
        public void PlayGreeting()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "greeting.wav");

            try
            {
                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("\n[Audio Notice]: Voice greeting skipped (File not found in Resources).");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio Error: " + ex.Message);
            }
        }
    }
}