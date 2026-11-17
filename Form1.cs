using WinFormstest;

namespace WinFormstest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvData.Columns.Add("Device", "设备");
            dgvData.Columns.Add("Value", "测试值");
            dgvData.Columns[0].Width = 150;
            dgvData.Columns[1].Width = 250;
            dgvData.AllowUserToAddRows = false;

        }

        private async void Btnstart_Click(object sender, EventArgs e)
        {

            btnstart.Enabled = false;
            lblStatus.Text = "正在并发采集数据...";
            lblAlarm.Text = "设备正常";
            lblAlarm.ForeColor = System.Drawing.Color.Black;
            dgvData.Rows.Clear(); // 清空旧数据
            try
            {
                IDevice plc = new PlcDevice();
                IDevice scanner = new ScannerDevice();

                plc.OnAlarm += HandleAlarm;
                scanner.OnAlarm += HandleAlarm;

                Task<string> plcTask = plc.ReadData();
                Task<string> scannerTask = scanner.ReadData();
                await Task.WhenAll(plcTask, scannerTask);

                string plcResult = await plcTask;
                string scannerResult = await scannerTask;

                
                dgvData.Rows.Add(plc.DeviceName, plcResult);
                dgvData.Rows.Add(scanner.DeviceName, scannerResult);

                lblStatus.Text = "采集完成！";

            }
            catch (Exception ex)
            {
                lblStatus.Text = "采集失败：" + ex.Message;
            }
            finally
            {
                btnstart.Enabled = true;
            }

        }

        private void LblStatus_Click(object sender, EventArgs e)
        {

        }

        private void LalAlarm_Click(object sender, EventArgs e)
        {

        }

        private void HandleAlarm(object ?sender, AlarmEventArgs e)
        {
            
            lblAlarm.Text = $"{e.DeviceName} 报警: {e.Message}";
            lblAlarm.ForeColor = System.Drawing.Color.Red; 
            Console.Beep(); 
        }


    }
}
