using Burglary.Addons;
using Burglary.Addons.Attributes;
using Burglary.cons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ct = Burglary.cons.ConsoleUtils;

//namespace Burglary.Logging
//{
//    public class Logger
//    {
//        internal string addon;
//        public Logger(string target) {
//            this.addon = target;
//        }
//        public void Log(string message)
//        {
//            Log(message, ConsoleColor.Gray);
//        }
//        public void Log(string message, ConsoleColor textColor)
//        {
//            ct.WCol("[", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(DateTime.Now.ToString("(HH:mm:ss,fff)"), ConsoleColor.Green, BurglaryMain.SecondaryWriter);
//            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(addon, ConsoleColor.Blue, BurglaryMain.SecondaryWriter);
//            ct.WCol("] ", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WLColNL(message, textColor, BurglaryMain.SecondaryWriter);
//            ct.write_log();
//        }
//        public void Log(string message, ConsoleColor textColor, ConsoleColor backColor)
//        {
//            ct.WCol("[", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(DateTime.Now.ToString("(HH:mm:ss,fff)"), ConsoleColor.Green, BurglaryMain.SecondaryWriter);
//            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(addon, ConsoleColor.Blue, BurglaryMain.SecondaryWriter);
//            ct.WCol("] ", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WLColNL(message, backColor, textColor, BurglaryMain.SecondaryWriter);
//            ct.write_log();
//        }
//        public void Error(string error_message)
//        {
//            ct.WCol("[", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(DateTime.Now.ToString("(HH:mm:ss,fff)"), ConsoleColor.Green, BurglaryMain.SecondaryWriter);
//            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(" [", ConsoleColor.DarkRed, BurglaryMain.SecondaryWriter);
//            ct.WCol("ERROR", ConsoleColor.Red, BurglaryMain.SecondaryWriter);
//            ct.WCol("]", ConsoleColor.DarkRed, BurglaryMain.SecondaryWriter);
//            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(addon, ConsoleColor.Blue, BurglaryMain.SecondaryWriter);
//            ct.WCol("] ", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WLColNL(error_message, ConsoleColor.Red, BurglaryMain.SecondaryWriter);
//            ct.write_log();
//        }
//        public void Warn(string warning)
//        {
//            ct.WCol("[", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(DateTime.Now.ToString("(HH:mm:ss,fff)"), ConsoleColor.Green, BurglaryMain.SecondaryWriter);
//            ct.WCol("]", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(" [", ConsoleColor.DarkYellow, BurglaryMain.SecondaryWriter);
//            ct.WCol("WARNING", ConsoleColor.Yellow, BurglaryMain.SecondaryWriter);
//            ct.WCol("]", ConsoleColor.DarkYellow, BurglaryMain.SecondaryWriter);
//            ct.WCol(" [", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WCol(addon, ConsoleColor.Blue, BurglaryMain.SecondaryWriter);
//            ct.WCol("] ", ConsoleColor.White, BurglaryMain.SecondaryWriter);
//            ct.WLColNL(warning, ConsoleColor.Yellow, BurglaryMain.SecondaryWriter);
//            ct.write_log();
//        }
//    }
//}
