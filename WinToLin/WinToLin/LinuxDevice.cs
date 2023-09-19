using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinToLin
{
    public class LinuxDevice
    {
        string DeviceIP { get; set; }
        string DeviceName { get; set; }
        string DeviceKey { get; set; }

        public LinuxDevice()
        { 
            this.DeviceIP = "-";
            this.DeviceName = "-";
            this.DeviceKey = "-";
        }
    }


}
