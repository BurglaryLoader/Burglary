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
                    try
                    {
                        addon.OnSceneLoad(scene);
                    }
                    catch { }
                }
            }
            public static void scenechange(Scene before, Scene after)
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    try
                    {
                        addon.OnSceneChanged(before, after);
                    }
                    catch { }
                }
            }
            public static void sceneunload(Scene scene)
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    try
                    {
                        addon.OnSceneUnload(scene);
                    }
                    catch { }
                }
            }
            public static void OnGUI()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    try
                    {
                        addon.OnGUI();
                    }
                    catch { }
                }
            }
            public static void update()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    try
                    {
                        addon.OnUpdate();
                    }
                    catch { }
                }
            }
            public static void fixedupdate()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    try
                    {
                        addon.OnFixedUpdate();
                    }
                    catch { }
                }
            }
            public static void lateupdate()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    try
                    {
                        addon.OnLateUpdate();
                    }
                    catch { }
                }
            }
            public static void burgunload()
            {
                foreach (Addon addon in BurglaryMain.Addons)
                {
                    try
                    {
                        addon.OnBurglaryUnload();
                    }
                    catch { }
                }
            }
        }
    }
}