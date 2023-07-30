using Burglary.Addons;
using Burglary.Addons.Attributes;
using Burglary.cons;
using Burglary.Events;
using BurglaryClassLoader;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using ct = Burglary.cons.ConsoleUtils;

namespace Burglary
{
    public class BurglaryMain
    {
        //static BurglaryMain(){
        //    Console.WriteLine("hello from cctor");
        //    Console.WriteLine(Assembly.GetCallingAssembly().FullName);
        //    UnityEngine.Debug.Log("ECall exception?? hello from cctor!");
        //    Process.Start("https://example.com");
        //    //do we call the entrypoint from here?
        //}

        public static Harmony HarmonyInstance { get; set; }

        public static List<Addon> Addons { get; private set; } = new List<Addon>();
        public static StringWriter SecondaryWriter { get; private set; } = null;
        public static TextWriter ConsoleOut { get; private set; } = Console.Out;

        private static void nl()
        {
            Console.WriteLine();
            SecondaryWriter.WriteLine();
            ct.write_log();
        }

        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        public static string LogLocation { get; private set; }

        [Obsolete("Please use proper logging methods. This does not appear in console. Use the logging methods with your addon (Addon class).")]
        public static void Log(string msg)
        {
            string content = File.Exists(LogLocation) ? File.ReadAllText(LogLocation) : "";
            File.WriteAllText(LogLocation, content + "\n" + msg);
        }

        public static void InitBurglary(object[] args)
        {
            ConsoleOut = (TextWriter)args[2];
            LogLocation = args[0].ToString();
            SecondaryWriter = (StringWriter) args[1];
            ct.write_log();
            //if (File.Exists(LogLocation))
            //    File.Delete(LogLocation);
        }

        public async Task waitForSceneLoad() // OR JUST USE THE EVENT DUMBASS
        {
            do
            {
                await Task.Delay(250);
            } while (SceneManager.GetActiveScene() == null & SceneManager.GetActiveScene().isLoaded == false);

            Utils.dispatcher.sceneload(SceneManager.GetActiveScene());
        }

        //public static void InitBurglary(string[] args)
        //{
        //    //AllocConsole(); // god please work

        //    ct.WLCol("Creating and setting property HarmonyInstance...", ConsoleColor.DarkBlue);
        //    HarmonyInstance = new Harmony("Burglary");

        //    DirectoryInfo dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;

        //    string addonsPath = Path.Combine(dir.FullName, "addons");

        //    if (!Directory.Exists(addonsPath))
        //    {
        //        ct.WLCol("Addons directory doesn't exist! Creating...\n",ConsoleColor.Red);
        //        Directory.CreateDirectory(addonsPath);
        //    }

        //    dir = new DirectoryInfo(addonsPath);

        //    ct.WCol("Searching for Addons in \"",ConsoleColor.Cyan);
        //    ct.WCol(dir.FullName, ConsoleColor.DarkCyan);
        //    ct.WLCol("\"...", ConsoleColor.Cyan);

        //    List<string> filePaths = Directory.GetFiles(addonsPath).ToList();

        //    List<Type> addons = new List<Type>(); // so addons can be organized / stuff bnal lbal bla a
        //                                           //(hard to get that through filenames lol)

        //    foreach (string FilePath in filePaths) {
        //        ct.WLColNL(FilePath + " found in addons.", ConsoleColor.DarkGray);
        //        if (FilePath.EndsWith(".dll"))
        //        {
        //            Assembly assembly = Assembly.LoadFile(FilePath);
        //            foreach(Type t in assembly.GetTypes())
        //            {
        //                if(t.IsClass & t.BaseType.Equals(typeof(Addon))){
        //                    //Addon a = (Addon) Activator.CreateInstance(t);
        //                    //removed for the sorting stuff

        //                    nl();
        //                    ct.WLColNL("found " + ((AddonData)t.GetCustomAttribute(typeof(AddonData))).Name,
        //                        ConsoleColor.DarkGray);
        //                    nl();
        //                    addons.Add(t);
        //                }
        //            }
        //        }
        //    }
        //    ct.WLColNL("Search concluded. Results: " + addons.Count.ToString(), ConsoleColor.Cyan);

        //    addons = addons.OrderBy(a =>
        //    {
        //        PriorityAttribute priorityAttribute = a.GetCustomAttribute<PriorityAttribute>();
        //        return priorityAttribute != null ? priorityAttribute.Priority : 0;
        //    }).ToList();

        //    foreach(Type addon in addons)
        //    {
        //        Addon a = (Addon) Activator.CreateInstance(addon);//Burglary.asm_loader.load(addon);
        //        Addons.Add(a);
        //        a.OnRegister();
        //        a.OnBurglaryInitialize(); // these 2 are the exact same im just lazy
        //        a.OnBurglaryLoad(); // these 2 are the exact same im just lazy
        //    }
            
        //    //while (true)
        //    //    if (Process.GetProcessesByName("The Break In").Length <= 0)
        //    //    {
        //    //        ct.WLColNL("Application closed. Freeing console...", ConsoleColor.Red);
        //    //        FreeConsole();
        //    //        break;
        //    //    }
        //    //    else
        //    //        Console.ReadKey(true);
        //}
    }
}
