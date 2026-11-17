using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormstest
{
    
    
        // 接口
        public interface IDevice
        {
            string DeviceName { get; }
            event EventHandler<AlarmEventArgs> OnAlarm;
            Task<string> ReadData();
        }

        //具体设备
        public class PlcDevice: IDevice
        {
            public string DeviceName => "西门子plc";
            public event EventHandler<AlarmEventArgs> ?OnAlarm;

            public async Task<string> ReadData()
            {
                await Task.Delay(3000);
                OnAlarm?.Invoke(this,new AlarmEventArgs(DeviceName, "温度超标：95℃！"));
                return "温度:95℃";
            }

        }
        public class ScannerDevice: IDevice
        {
            public string DeviceName => "基恩士扫码枪";
            public event EventHandler<AlarmEventArgs> ?OnAlarm;

            public async Task<string> ReadData()
            {
                await Task.Delay(4000);
                return "编号:B-007-001";
            }
        }
    
}
