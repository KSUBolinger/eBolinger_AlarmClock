using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolinger_AlarmClock
{
    public interface IAlarm
    {
        bool OnSet { get; }

    }
}
