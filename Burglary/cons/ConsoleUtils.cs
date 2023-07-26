using System;
using System.Collections.Generic;
using System.Linq;
using Burglary.Addons.Attributes;

namespace Burglary.cons
{
    internal static class ConsoleUtils
    {
        public static string header = @"
===============================================

BURGLARY - DLL Mod Loader For 'The Break in'

Made by:
Discord: joeswanson.

===============================================

";
        public static void WLCol(string text, ConsoleColor bg, ConsoleColor fg)
        {
            //spaghetti (but formatted!)
            ConsoleColor prevBG = Console.BackgroundColor;
            ConsoleColor prevFG = Console.ForegroundColor;

            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;

            Console.WriteLine(text);
            Console.WriteLine("\n");

            Console.BackgroundColor = prevBG;
            Console.ForegroundColor = prevFG;
        }
        public static void WLColNL(string text, ConsoleColor bg, ConsoleColor fg)
        {
            //spaghetti (but formatted!)
            ConsoleColor prevBG = Console.BackgroundColor;
            ConsoleColor prevFG = Console.ForegroundColor;

            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;

            Console.WriteLine(text);

            Console.BackgroundColor = prevBG;
            Console.ForegroundColor = prevFG;
        }
        public static void WCol(string text, ConsoleColor bg, ConsoleColor fg)
        {
            //spaghetti (but formatted!)
            ConsoleColor prevBG = Console.BackgroundColor;
            ConsoleColor prevFG = Console.ForegroundColor;

            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;

            Console.Write(text);

            Console.BackgroundColor = prevBG;
            Console.ForegroundColor = prevFG;
        }
        public static void WLCol(string text, ConsoleColor fg)
        {
            ConsoleColor prevFG = Console.ForegroundColor;
            Console.ForegroundColor = fg;
            Console.WriteLine(text);
            Console.WriteLine("\n");
            Console.ForegroundColor = prevFG;
        }
        public static void WLColNL(string text, ConsoleColor fg)
        {
            ConsoleColor prevFG = Console.ForegroundColor;
            Console.ForegroundColor = fg;
            Console.WriteLine(text);
            Console.ForegroundColor = prevFG;
        }
        public static void WCol(string text, ConsoleColor fg)
        {
            ConsoleColor prevFG = Console.ForegroundColor;
            Console.ForegroundColor = fg;
            Console.Write(text);
            Console.ForegroundColor = prevFG;
        }

        public static void PrintAttributeData(AddonData data,ConsoleColor fg)
        {
            WLColNL("=====================",fg);
            WLColNL(data.Name,fg);
            WLColNL('"'+data.Description+'"',fg);
            WLColNL("By \""+data.Author+'"',fg);
            WLColNL('v'+data.Version,fg);
            WLColNL("=====================", fg);
        }

        public static string Indent(int indentAmount, string text)
        {
            return new string('\t', indentAmount) + text;
        }
    }
}
