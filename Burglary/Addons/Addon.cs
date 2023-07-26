using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burglary.Addons
{
    public abstract class Addon
    {
        public virtual void OnBurglaryInitialize() { }
        public virtual void OnBurglaryUnload() { }
        public virtual void OnBurglaryLoad() { }
        public virtual void OnRegister() { }
        public virtual void OnSceneLoad(int buildIndex, string sceneName) { }
        public virtual void OnSceneUnload(int buildIndex, string sceneName) { }
        public virtual void OnSceneInit(int buildIndex, string sceneName) { }
        public virtual void OnMissionLoad(missionModel Mission) { }
        public virtual void OnAlert(AiBrain brain) { }
        public virtual void OnUpdate() { }
        public virtual void OnFixedUpdate() { }
        public virtual void OnLateUpdate() { }
        public virtual void OnGUI() { }
    }
}
