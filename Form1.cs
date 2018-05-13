using SerialReader.Class.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialReader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            DefaultSerialPort.serialPort.Open();
            DefaultSerialPort.serialPort.DataReceived += DataRecievedHandler;
        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            var test = DefaultSerialPort.serialPort.ReadLine(); 
            richTextBox1.Invoke(new Action(() => richTextBox1.Text = richTextBox1.Text + test));
        }

        private void Led1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(Led1CheckBox.Checked == true)
            {
                DefaultSerialPort.serialPort.WriteLine("LED1ON\n");
            }
            else
            {
                DefaultSerialPort.serialPort.WriteLine("LED1OF\n");
            }
        }

        private void Led2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Led2CheckBox.Checked == true)
            {
                DefaultSerialPort.serialPort.WriteLine("LED2ON\n");
            }
            else
            {
                DefaultSerialPort.serialPort.WriteLine("LED2OF\n");
            }
        }

        private void Led3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Led3CheckBox.Checked == true)
            {
                DefaultSerialPort.serialPort.WriteLine("LED3ON\n");
            }
            else
            {
                DefaultSerialPort.serialPort.WriteLine("LED3OF\n");
            }
        }
    }
}
