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

namespace Transmitter
{
    public partial class Form1 : Form
    {
        communication communication;
        double roll, yaw, pitch, lat, lng;
        int state;

        public Form1()
        {
            InitializeComponent();
            communication = new communication();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            com_port_combo.Items.AddRange(ports);
            lat_text.Text = (51.761618).ToString();
            long_text.Text = (19.486801).ToString();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void openCOM_btn_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 115200;
            serialPort1.PortName = com_port_combo.Text;
            serialPort1.DataBits = 8;
            serialPort1.ReceivedBytesThreshold = 1;

            try { 
            serialPort1.Open();
            progressBar1.Value = 100;
            start_btn.Enabled = true;
            stop_btn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void closeCOM_btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Byte[] array;
            lat = Convert.ToDouble(lat_text.Text);
            lng = Convert.ToDouble(long_text.Text);
            yaw = yaw_track.Value;
            roll = roll_track.Value ;
            pitch = pitch_track.Value;
            state = Convert.ToInt16(state_num.Value);

            
            if (serialPort1.IsOpen == true)
            {
                array = communication.Com_PrepareFrameGPS(yaw, pitch, roll, lng, lat, state);
                serialPort1.Write(array, 0, 21);
                //MessageBox.Show(lat + " " + lng + " " + yaw + " " + roll + " " + pitch + "   ");
            }
        }

        private void roll_track_Scroll(object sender, EventArgs e)
        {
            roll_value.Text = roll_track.Value.ToString();
            roll = roll_track.Value;
        }

        private void yaw_track_Scroll(object sender, EventArgs e)
        {
            yaw_value.Text = yaw_track.Value.ToString();
            yaw = yaw_track.Value;
        }

        private void pitch_track_Scroll(object sender, EventArgs e)
        {
            pitch_value.Text = pitch_track.Value.ToString();
            pitch = pitch_track.Value; 
        }
    }
}
