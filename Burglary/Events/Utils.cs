using Burglary.Addons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burglary.Events
{
    internal class Utils
    {
        public static class dispatcher
        {
            public static void alert(AiBrain brain)
            {
                foreach(Addon addon in BurglaryMain.Addons){
                    addon.OnAlert(brain);
                }
            }
        }
    }
}
