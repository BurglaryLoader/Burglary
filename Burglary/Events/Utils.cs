using Burglary.Addons;
using Burglary.Addons.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using static HarmonyLib.Code;

namespace Burglary.Events
{
    public class Utils
    {
        public static class dispatcher
        {
            public static void sceneload(Scene scene)
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    addon.OnSceneLoad(scene);
                }
            }
            public static void scenechange(Scene before,Scene after)
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    addon.OnSceneChanged(before,after);
                }
            }
            public static void sceneunload(Scene scene)
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    addon.OnSceneUnload(scene);
                }
            }
            public static void OnGUI()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    addon.OnGUI();
                }
            }
            public static void update()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    addon.OnUpdate();
                }
            }
            public static void fixedupdate()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    addon.OnFixedUpdate();
                }
            }
            public static void lateupdate()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    addon.OnLateUpdate();
                }
            }
            public static void burgunload()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    addon.OnBurglaryUnload();
                }
            }
        }
    }
}