using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeStopReminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _started = false;
        private DateTime? _lastReminder = null;
        private DateTime? _nextReminder = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private async Task Reset()
        {
            await Task.Run(() => {});

            if (this.lblCurrentStatus.InvokeRequired)
            {
                lblCurrentStatus.BeginInvoke((MethodInvoker)delegate { lblCurrentStatus.Text = _started ? "Running" : "Not Running"; });
                lblLastAlertTime.BeginInvoke((MethodInvoker)delegate { lblLastAlertTime.Text = _lastReminder == null ? "N/A" : _lastReminder.Value.ToShortTimeString(); });
                lblNextAlertTime.BeginInvoke((MethodInvoker)delegate { lblNextAlertTime.Text = _nextReminder == null ? "N/A" : _nextReminder.Value.ToShortTimeString(); });
                btnStart.BeginInvoke((MethodInvoker)delegate { btnStart.Enabled = !_started; });
                btnStop.BeginInvoke((MethodInvoker)delegate { btnStop.Enabled = _started; });
            }
            else
            {
                lblCurrentStatus.Text = _started ? "Running" : "Not Running";
                lblLastAlertTime.Text = _lastReminder == null ? "N/A" : _lastReminder.Value.ToShortTimeString();
                lblNextAlertTime.Text = _nextReminder == null ? "N/A" : _nextReminder.Value.ToShortTimeString();
                btnStart.Enabled = !_started;
                btnStop.Enabled = _started; 
            }
        }

        private async void Start() {
            _nextReminder = DateTime.Now.AddMinutes(5);
            _started = true;
            await Reset();
            await Checker();
        }

        private async void Stop() {
            _started = false;
            _nextReminder = null;
            await Reset();
        }

        private async void Alert()
        {
            var form = new Form2();
            var hey = form.ShowDialog();
            await Reset();
        }

        private async Task Checker()
        {
            while (_started)
            {
                await Task.Run(() =>
                {
                    if (DateTime.Now > _nextReminder.Value)
                    {
                        Alert();
                        _lastReminder = DateTime.Now;
                        _nextReminder = DateTime.Now.AddMinutes(5);
                        Reset();
                    }

                    Task.Delay(10000);
                });
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
