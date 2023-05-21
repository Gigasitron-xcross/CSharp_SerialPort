using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Serial
{
    public partial class MainForm : Form
    {
        #region Constant
        private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
        #endregion

        private SerialPort Serial = new SerialPort();

        #region Local Helpers
        private void UpdateCOMPortList()
        {
            // Get all existing Com Port names
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            cboxComport.Items.Clear();
            cboxBaudrate.Items.Clear();

            // Append existing COM to the cboxComport list
            foreach (var item in Ports)
            {
                cboxComport.Items.Add(item);
            }

            // Append possible Baudrate to the cboxBaudrate list
            foreach (var baud in baudrate)
            {
                cboxBaudrate.Items.Add(baud.ToString());
            }
        }
        #endregion

        #region Delegates
        public delegate void UPDATE_OUTPUT_TEXT(String Str);
        public void UpdateOutputText(String Str)
        {
            tboxReceive.Text += Str;
            tboxReceive.ScrollToCaret();
        }
        #endregion


        #region Handlers
        void SerialOnReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            String str = Serial.ReadExisting();
            
           Invoke(new UPDATE_OUTPUT_TEXT(UpdateOutputText), str);
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // If user click disconnect
            if ("Disconnect" == btnConnect.Text.ToString())
            {
                if (true == Serial.IsOpen)
                {
                    Serial.Close();
                }

                btnConnect.Text = "Connect";
                cboxComport.Enabled = true;
                cboxBaudrate.Enabled = true;
                btnRefresh.Enabled = true;

                return;
            }

            // else we gonna open the desired COM port
            // Get user comport from cbox
            try
            {
                Serial.PortName = cboxComport.Text;
            }
            catch
            {
                MessageBox.Show("Error! No COM Port selected");
                return;
            }

            // Get user baudrate from cbox
            try
            {
                Serial.BaudRate = int.Parse(cboxBaudrate.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Error! No Baudrate selected");
                return;
            }

            // Serial Port Configuration
            Serial.Parity = Parity.None;
            Serial.DataBits = 8;
            Serial.ReceivedBytesThreshold = 1;
            Serial.StopBits = StopBits.One;
            Serial.Handshake = Handshake.None;
            Serial.WriteTimeout = 3000;

            // Check if com port is opened by other application
            if (false == Serial.IsOpen)
            {
                try
                {
                    // Com port available
                    Serial.Open();
                }
                catch
                {
                    MessageBox.Show("The COM port is not accessible", "Error");
                    return;
                };


                // double comform it is opened
                if (true == Serial.IsOpen)
                {
                    btnConnect.Text = "Disconnect";
                    cboxComport.Enabled = false;
                    cboxBaudrate.Enabled = false;
                    btnRefresh.Enabled = false;

                    // Add callback handler for receiving
                    Serial.DataReceived += new SerialDataReceivedEventHandler(SerialOnReceivedHandler);

                }

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // We need to populate the lists during mainform is loading
            UpdateCOMPortList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // We need to update all lists again if user requested
            UpdateCOMPortList();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(null != Serial)
            {
                if(true == Serial.IsOpen)
                {
                    Serial.Write(tboxData.Text);
                }
                else
                {
                    MessageBox.Show("COM Port is not Opened");
                }
            }
        }
    }
}
