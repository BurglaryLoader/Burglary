using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burglary.Addons.Attributes
{
    public class PriorityAttribute : Attribute
    {
        public PriorityAttribute(int priority) {
            prio = priority;
        }

        protected int prio;

        public int Priority { get { return prio; } }
    }
}
