using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ServiceBus.Messaging;
using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Common;

namespace AzureIoTHubSimpleTerminal
{
     public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer1;

        private Queue<string> DataStream = new Queue<string>();

        private bool azureCommMode = false;

        private static string deviceID;
        private static string activeIoTHubConnectionString;
        private static CancellationTokenSource ctsForDataMonitoring;

        private void makeCommDataForLogData(string whoIam, byte[] bArray)
        {
            string newText = Encoding.UTF8.GetString(bArray);

            string time = DateTime.Now.ToString("HH:mm:ss.fff");

            string logText = time + " " + whoIam + " " + newText;

            DataStream.Enqueue(logText);

        }

        public MainForm()
        {
            InitializeComponent();

            this.timer1 = new System.Windows.Forms.Timer();
            this.timer1.Interval = 100;
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (DataStream.Count != 0)
            {
                string text = DataStream.Dequeue();

                if (text != null)
                {
                    List<string> lines = new List<string>(commLogtextBox.Lines);

                    if (lines.Count > 10)
                    {
                        lines.RemoveAt(0);
                        commLogtextBox.Text = String.Join(Environment.NewLine, lines);

                    }

                    commLogtextBox.AppendText(text + Environment.NewLine);

                }

            }

        }

        private async void MonitorEventHubAsync(DateTime startTime, CancellationToken ct, string consumerGroupName)
        {
            EventHubClient eventHubClient = null;
            EventHubReceiver eventHubReceiver = null;

            try
            {
                eventHubClient = EventHubClient.CreateFromConnectionString(activeIoTHubConnectionString, "messages/events");
                int eventHubPartitionsCount = eventHubClient.GetRuntimeInformation().PartitionCount;
                string partition = EventHubPartitionKeyResolver.ResolveToPartition(deviceID, eventHubPartitionsCount);
                eventHubReceiver = eventHubClient.GetConsumerGroup(consumerGroupName).CreateReceiver(partition, startTime);

                //receive the events from startTime until current time in a single call and process them
                var events = await eventHubReceiver.ReceiveAsync(int.MaxValue, TimeSpan.FromSeconds(20));

                foreach (var eventData in events)
                {
                    byte[] rxbuff = eventData.GetBytes();
                    makeCommDataForLogData("Rx", rxbuff);
                }

                //having already received past events, monitor current events in a loop
                while (true)
                {
                    ct.ThrowIfCancellationRequested();

                    var eventData = await eventHubReceiver.ReceiveAsync(TimeSpan.FromSeconds(0.5));

                    if (eventData != null)
                    {
                        byte[] rxbuff = eventData.GetBytes();
                        makeCommDataForLogData("Rx", rxbuff);

                    }
                }
            }
            catch (Exception ex)
            {
                if (ct.IsCancellationRequested)
                {
                    //Stopped Monitoring events by user action.
                }
                else
                {
                    //Something happen.
                }

                if (eventHubReceiver != null)
                {
                    eventHubReceiver.Close();
                }
                if (eventHubClient != null)
                {
                    eventHubClient.Close();
                }

            }
        }

        private async void sendMessageToDevice(List<byte> frame)
        {
            try
            {
                List<byte> txBuff = new List<byte>(frame);

                ServiceClient serviceClient = ServiceClient.CreateFromConnectionString(activeIoTHubConnectionString);

                var serviceMessage = new Microsoft.Azure.Devices.Message(txBuff.ToArray());
                serviceMessage.Ack = DeliveryAcknowledgement.Full;
                serviceMessage.MessageId = Guid.NewGuid().ToString();

                await serviceClient.SendAsync(deviceID, serviceMessage);
                await serviceClient.CloseAsync();

                makeCommDataForLogData("Tx", txBuff.ToArray());

            }
            catch (Exception ex)
            {

            }
        }

        private void azureCommConnectButton_Click(object sender, EventArgs e)
        {
            if (azureCommMode == false)
            {
                deviceID = deviceIDTextBox.Text;
                activeIoTHubConnectionString = connectionStringTextBox.Text;

                ctsForDataMonitoring = new CancellationTokenSource();

                MonitorEventHubAsync(DateTime.Now, ctsForDataMonitoring.Token, "$Default");

                azureCommMode = true;

                azureCommConnectButton.Text = "Disconnect";

            }
            else
            {
                ctsForDataMonitoring.Cancel();

                azureCommMode = false;

                azureCommConnectButton.Text = "Connect";

            }

        }

        private void azureCommTxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string text = azureCommTxTextBox.Text;

                if (string.IsNullOrEmpty(text) == true)
                {
                    return;

                }

                if (newLineCheckBox.Checked == true)
                {
                    text += Environment.NewLine;

                }

                try
                {
                    List<byte> azureTxBytes = new List<Byte>(Encoding.ASCII.GetBytes(text));

                    sendMessageToDevice(azureTxBytes);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

        }
    }

}
