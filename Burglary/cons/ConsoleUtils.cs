using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Burglary.Addons.Attributes;
using MeshCombineStudio;
using Console = System.Console;

namespace Burglary.cons
{
    public static class ConsoleUtils
    {
        public static string header = @"
===============================================

BURGLARY - DLL Mod Loader For 'The Break in'

Made by:
Discord - joeswanson.

===============================================

";
        private static string[] motds_internal = { };
        public static string[] motds { get
            {
                if(motds_internal.Length>0)
                    return motds_internal;
                return @"hydrochloric acid works great
what is a joe swanson
if youre using this for cheats, tf are you doin?
ERROR! Error injecting into process. Stacktrace: ERROR! Error injecting into process. Stacktrace: haha got u. did i? did it work? hello?
ConsoleColor.Red); cs xss real
oliver when he hears about il2cpp:
line ~~13~~ 7*
are you using the break in [REDACTED THIS WAS A NICE WORD DONT WORRY!!!!] mod real?!?!?!/
guys watch i can piss of the c# programmers: java is such a good lanugage
public Burglary(){ super(""HAHA ITS JAVA nice word YOU!!!!!!""); }
static { System.out.println(""you cant stop me""); }
im having too much fun writing these
im on BLEEP. sulfuric. REMOVED FOR REFERENCE OF DRUG USE!
wtf is a melon loader??!?!?!?
if you want a family friendly mod loader BLEEP right off to melonloader or bepinex im not gunna kiss your WOAH BUDDY CALM DOWN THERE WE NEED TO FOLLOW GUIDELINES! GOD...
oh thats why! theres a newline here.... you probably dont get this.
theres a pretty big chance that you get an empty quote here. will i fix it? probably not
trying to create something that appeals to a community im exiled from is not an easy task
50% more middlemen
250% more censorship in attempts to comply with requests!
no pirat cod!! cese an desit!!!
guys PLEASEE dont abuse the deserialization rce exploit! (this is a joke)
there was a period of time where i was considering using bepinex's console idea. yeah no lol
big L for unix & linux users
did you guys know that apple tv has ads? wild.
pancake is cool
kube please shush
pimpmonke was a tester. i think. pcvr though. well heres some credit????
floofies tysm for being cool and supporting this thing
floofies ty for also being a proxy for me to talk to oliver
SATURN5VFIVE IS UHHH WAIT UHH WHATS SOMETHING PG I CAN SAY ABOUT HIM
https://github.com/BurglaryLoader/BurglaryHosting/edit/main/header_messages.txt".Split('\n');
                //using(WebClient c = new WebClient())
                //{
                //    return c.DownloadString("https://raw.githubusercontent.com/BurglaryLoader/BurglaryHosting/main/header_messages.txt").Split('\n');
                //}
            } 
        }
        private static Random rand = new Random();
        public static string motd_header { get { return @"
===============================================

BURGLARY - DLL Mod Loader For 'The Break in'

'MESSAGE_HERE'

Made by:
Discord - joeswanson.

===============================================

".Replace("MESSAGE_HERE", motds[rand.Next(0,motds.Length)]); } }
        public static void write_log()
        {
            Ensure();
            File.WriteAllText(BurglaryMain.LogLocation, BurglaryMain.SecondaryWriter.ToString());
        }
        public static void WLCol(string text, ConsoleColor bg, ConsoleColor fg,StringWriter secondary)
        {
            Ensure();
            //spaghetti (but formatted!)
            ConsoleColor prevBG = Console.BackgroundColor;
            ConsoleColor prevFG = Console.ForegroundColor;

            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;

            Console.WriteLine(text);
            Console.WriteLine("\n");
            secondary.WriteLine(text);
            secondary.WriteLine("\n");

            Console.BackgroundColor = prevBG;
            Console.ForegroundColor = prevFG;
        }
        public static void WLColNL(string text, ConsoleColor bg, ConsoleColor fg, StringWriter secondary)
        {
            Ensure();
            //spaghetti (but formatted!)
            ConsoleColor prevBG = Console.BackgroundColor;
            ConsoleColor prevFG = Console.ForegroundColor;

            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;

            Console.WriteLine(text);
            secondary.WriteLine(text);

            Console.BackgroundColor = prevBG;
            Console.ForegroundColor = prevFG;
        }
        public static void WCol(string text, ConsoleColor bg, ConsoleColor fg, StringWriter secondary)
        {
            Ensure();
            //spaghetti (but formatted!)
            ConsoleColor prevBG = Console.BackgroundColor;
            ConsoleColor prevFG = Console.ForegroundColor;

            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;

            Console.Write(text);
            secondary.Write(text);

            Console.BackgroundColor = prevBG;
            Console.ForegroundColor = prevFG;
        }
        public static void WLCol(string text, ConsoleColor fg, StringWriter secondary)
        {
            Ensure();
            ConsoleColor prevFG = Console.ForegroundColor;
            Console.ForegroundColor = fg;
            Console.WriteLine(text);
            Console.WriteLine("\n");
            secondary.WriteLine(text);
            secondary.WriteLine("\n");
            Console.ForegroundColor = prevFG;
        }
        public static void WLColNL(string text, ConsoleColor fg, StringWriter secondary)
        {
            Ensure();
            ConsoleColor prevFG = Console.ForegroundColor;
            Console.ForegroundColor = fg;
            Console.WriteLine(text);
            secondary.WriteLine(text);
            Console.ForegroundColor = prevFG;
        }
        public static void WCol(string text, ConsoleColor fg, StringWriter secondary)
        {
            Ensure();
            ConsoleColor prevFG = Console.ForegroundColor;
            Console.ForegroundColor = fg;
            Console.Write(text);
            secondary.Write(text);
            Console.ForegroundColor = prevFG;
        }
        public static void Ensure()
        {
            if(Console.Out!=BurglaryMain.ConsoleOut)
            {
                Console.SetOut(BurglaryMain.ConsoleOut);
            }
        }

        public static void PrintAttributeData(AddonData data,ConsoleColor fg, StringWriter secondary)
        {
            Ensure();
            WLColNL("=====================",fg,secondary);
            WLColNL(data.Name,fg, secondary);
            WLColNL('"'+data.Description+'"',fg, secondary);
            WLColNL("By \""+data.Author+'"',fg, secondary);
            WLColNL('v'+data.Version,fg, secondary);
            WLColNL("=====================", fg, secondary);
        }

        public static string Indent(int indentAmount, string text)
        {
            return new string('\t', indentAmount) + text;
        }
    }
}
