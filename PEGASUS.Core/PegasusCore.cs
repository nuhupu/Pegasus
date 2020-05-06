using PEGASUS.COM;
using PEGASUS.Protocol.lzru920_u921;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static PEGASUS.COM.ComDelegate;

namespace PEGASUS.Core
{
    public class PegasusCore
    {
        IComPort com;
        public PegasusCore(IComPort com)
        {
            this.com = com;
        }
        public bool InitCom()
        {
            bool check = false;
            if (com.Init()) 
            {
                if (com.Connect())
                {
                    com.OnComReaderReceived += new ComReaderReceived(this._port_DataReceived);
                }
                else
                {
                    return check;
                }

            }           
            else
            {
               return check;
            }

            return true;
        }

        private void _port_DataReceived(string cmd)
        {
            string txt01="";
            try
            {                
                    txt01 = cmd;           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SendData()
        {
            try
            {
                if (com != null /*&& com.IsConnected()*/)
                {
                    //byte[] sysc = new byte[] { 0xFF, 0xFE, 0xFD, 0xFC };
                    //byte[] data = new byte[] { 0x01 };
                   // ICommandBase comm = new SetRawDataMode(0);
                    byte[] datasend = { 0xA5 };
                    com.SendCommand(datasend);
                   
                }
                else
                {
                    MessageBox.Show("Disconnected");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

