using PEGASUS.COM;
using PEGASUS.Core;
using PEGASUS.Protocol.lzru920_u921;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static PEGASUS.COM.ComDelegate;

namespace PEGASUS.Test
{
    public partial class Form1 : Form
    {
        PegasusCore core;
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            // Thêm toàn bộ các COM đã tìm được vào combox cbCom
            cbCom.Items.AddRange(ports);
        }

        private void btnTestCom_Click(object sender, EventArgs e)
        {
            string comNameSelected = cbCom.SelectedItem.ToString();
            string a = comNameSelected.Substring(2);
            int port = int.Parse(comNameSelected.Substring(3));
            core = new PegasusCore(new ComPort(port));
           
           bool check = core.InitCom();
            if (check)
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Disconnected");
            }
        }





        private void btnTestSend_Click(object sender, EventArgs e)
        {
            core = new PegasusCore(new ComPort(7));
            core.SendData();
        }


    }
}
