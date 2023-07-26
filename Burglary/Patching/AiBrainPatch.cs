using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Burglary.Events;
using HarmonyLib;

namespace Burglary.Patching
{
    [HarmonyPatch(typeof(AiBrain))]
    internal class AiBrainPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch("alert")]
        public static void Postfix(AiBrain __instance)
        {
            Utils.dispatcher.alert(__instance);
        }
    }
}
