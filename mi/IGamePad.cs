using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HidLibrary;
using ScpDriverInterface;

namespace mi
{
    public interface IGamePad
    {
        int Pid { get; }

        int Vid { get;  }

        bool HasVibration { get; }


        byte[] Vibration { get;   }
        HidDevice Device { get; }
        int Index { get; set; }
        bool check_connected();
        void unplug();

        void InitPad(HidDevice device, ScpBus scpBus, int index);
    }
}
