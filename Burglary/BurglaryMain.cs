using Burglary.Addons;
using Burglary.Addons.Attributes;
using Burglary.cons;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ct = Burglary.cons.ConsoleUtils;

namespace Burglary
{
    internal class BurglaryMain
    {
        

        public static Harmony HarmonyInstance { get; private set; }

        public static List<Addon> Addons { get; private set; } = new List<Addon>();

        private static void nl()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ct.WLColNL(ct.header, ConsoleColor.Blue);

            ct.WLCol("Creating and setting property HarmonyInstance...", ConsoleColor.DarkBlue);
            HarmonyInstance = new Harmony("Burglary");

            DirectoryInfo dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;

            string addonsPath = Path.Combine(dir.FullName, "addons");

            if (!Directory.Exists(addonsPath))
            {
                ct.WLCol("Addons directory doesn't exist! Creating...\n",ConsoleColor.Red);
                Directory.CreateDirectory(addonsPath);
            }

            dir = new DirectoryInfo(addonsPath);

            ct.WCol("Searching for Addons in \"",ConsoleColor.Cyan);
            ct.WCol(dir.FullName, ConsoleColor.DarkCyan);
            ct.WLCol("\"...", ConsoleColor.Cyan);

            List<string> filePaths = Directory.GetFiles(addonsPath).ToList();

            List<Type> addons = new List<Type>(); // so addons can be organized / stuff bnal lbal bla a
                                                   //(hard to get that through filenames lol)

            foreach (string FilePath in filePaths) {
                ct.WLColNL(FilePath + " found in addons.", ConsoleColor.DarkGray);
                if (FilePath.EndsWith(".dll"))
                {
                    Assembly assembly = Assembly.LoadFile(FilePath);
                    foreach(Type t in assembly.GetTypes())
                    {
                        if(t.IsClass & t.BaseType.Equals(typeof(Addon))){
                            //Addon a = (Addon) Activator.CreateInstance(t);
                            //removed for the sorting stuff

                            nl();
                            ct.WLColNL("found " + ((AddonData)t.GetCustomAttribute(typeof(AddonData))).Name,
                                ConsoleColor.DarkGray);
                            nl();
                            addons.Add(t);
                        }
                    }
                }
            }
            ct.WLColNL("Search concluded. Results: " + addons.Count.ToString(), ConsoleColor.Cyan);

addons = addons.OrderBy(a =>
            {
                PriorityAttribute priorityAttribute = a.GetCustomAttribute<PriorityAttribute>();
                return priorityAttribute != null ? priorityAttribute.Priority : 0;
            }).ToList();

            foreach(Type addon in addons)
            {
                ct.PrintAttributeData((AddonData)addon.GetCustomAttribute(typeof(AddonData)), ConsoleColor.Magenta);
                Addon a = asm_loader.load(addon);
                Addons.Add(a);
                a.OnRegister();
                a.OnBurglaryInitialize(); // these 2 are the exact same im just lazy
                a.OnBurglaryLoad(); // these 2 are the exact same im just lazy
            }

            while (true)
                Console.ReadKey(true);
        }
    }
}
