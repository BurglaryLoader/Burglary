using Burglary.Addons.Attributes;
using Burglary.cons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using static HarmonyLib.Code;
using ct = Burglary.cons.ConsoleUtils;

namespace Burglary.Addons
{
    public abstract class Addon
    {
        //public Logger LOGGER
        //{
        //    get
        //    {
        //        if(LOGGER == null)
        //        {
        //            //Console.WriteLine("logger does not exist. creating");
        //            //BurglaryMain.SecondaryWriter.WriteLine("logger does not exist. creating");
        //            //ConsoleUtils.write_log();
        //            LOGGER = new Logger(GetType().GetCustomAttribute<AddonData>().Name);
        //        }
        //        return LOGGER;
        //    } private set { LOGGER = value; }
        //}

        public void Log(string message)
        {
            ct.Ensure();
            Log(message, ConsoleColor.Gray);
        }
        public void Log(string message, ConsoleColor textColor)
        {
            ct.Ensure();
            ct.WCol("[", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(DateTime.Now.ToString("HH:mm:ss.fff"), ConsoleColor.Green, BurglaryMain.SecondaryWriter);
            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol("LOG", ConsoleColor.Gray, BurglaryMain.SecondaryWriter);
            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(GetType().GetCustomAttribute<AddonData>().Name, ConsoleColor.Blue, BurglaryMain.SecondaryWriter);
            ct.WCol("] ", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WLColNL(message, textColor, BurglaryMain.SecondaryWriter);
            ct.write_log();
        }
        public void Log(string message, ConsoleColor textColor, ConsoleColor backColor)
        {
            ct.Ensure();
            ct.WCol("[", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(DateTime.Now.ToString("HH:mm:ss.fff"), ConsoleColor.Green, BurglaryMain.SecondaryWriter);
            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol("LOG", ConsoleColor.Gray, BurglaryMain.SecondaryWriter);
            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(GetType().GetCustomAttribute<AddonData>().Name, ConsoleColor.Blue, BurglaryMain.SecondaryWriter);
            ct.WCol("] ", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WLColNL(message, backColor, textColor, BurglaryMain.SecondaryWriter);
            ct.write_log();
        }
        public void Error(string error_message)
        {
            ct.Ensure();
            ct.WCol("[", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(DateTime.Now.ToString("HH:mm:ss.fff"), ConsoleColor.Green, BurglaryMain.SecondaryWriter);
            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(" [", ConsoleColor.DarkRed, BurglaryMain.SecondaryWriter);
            ct.WCol("ERR", ConsoleColor.Red, BurglaryMain.SecondaryWriter);
            ct.WCol("]", ConsoleColor.DarkRed, BurglaryMain.SecondaryWriter);
            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(GetType().GetCustomAttribute<AddonData>().Name, ConsoleColor.Blue, BurglaryMain.SecondaryWriter);
            ct.WCol("] ", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WLColNL(error_message, ConsoleColor.Red, BurglaryMain.SecondaryWriter);
            ct.write_log();
        }
        public void Warn(string warning)
        {
            ct.Ensure();
            ct.WCol("[", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(DateTime.Now.ToString("HH:mm:ss.fff"), ConsoleColor.Green, BurglaryMain.SecondaryWriter);
            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(" [", ConsoleColor.DarkYellow, BurglaryMain.SecondaryWriter);
            ct.WCol("WRN", ConsoleColor.Yellow, BurglaryMain.SecondaryWriter);
            ct.WCol("]", ConsoleColor.DarkYellow, BurglaryMain.SecondaryWriter);
            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WCol(GetType().GetCustomAttribute<AddonData>().Name, ConsoleColor.Blue, BurglaryMain.SecondaryWriter);
            ct.WCol("] ", ConsoleColor.White, BurglaryMain.SecondaryWriter);
            ct.WLColNL(warning, ConsoleColor.Yellow, BurglaryMain.SecondaryWriter);
            ct.write_log();
        }

        public virtual void OnBurglaryInitialize() { }
        public virtual void OnBurglaryUnload() { }
        public virtual void OnBurglaryLoad() { }
        public virtual void OnRegister() { }
        public virtual void OnSceneLoad(Scene scene) { }
        public virtual void OnSceneUnload(Scene scene) { }
        public virtual void OnSceneChanged(Scene before, Scene after) { }
        public virtual void OnUpdate() { }
        public virtual void OnFixedUpdate() { }
        public virtual void OnLateUpdate() { }
        public virtual void OnGUI() { }
    }
}
