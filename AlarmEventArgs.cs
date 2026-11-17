using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormstest
{
    public class AlarmEventArgs : EventArgs
    {
        public string DeviceName { get; }
        public string Message { get; }

        public AlarmEventArgs(string deviceName, string message)
        {
            DeviceName = deviceName;
            Message = message;
        }
    }
}
