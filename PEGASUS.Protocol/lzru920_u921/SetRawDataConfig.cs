using PEGASUS.Protocol.lzru920_u921.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEGASUS.Protocol.lzru920_u921
{
    public class SetRawDataConfig : CommandBase
    {
        #region Property
        public byte Baudrate { get; set; }
        public byte LpzInfo { get; set; }
        public byte LaserTimeout { get; set; }
        public byte TestFrame { get; set; }
        public byte Plane0 { get; set; }
        public byte Plane1 { get; set; }
        public byte Plane2 { get; set; }
        public byte Plane3 { get; set; }
        public ushort DistanceValues { get; set; }
        public ushort StartSpotNumber { get; set; }
        public ushort JumpBetween2SuccessiveSpots { get; set; }
        public byte TransmissionOfTheCANIDAndFrameCounter { get; set; }
        public byte DiodeLifetimeManagement { get; set; }
        public byte PolarityOfTheInput1 { get; set; }
        public byte Led1 { get; set; }
        public byte Led2 { get; set; }
        public byte LedBlue { get; set; }
        public byte LedError { get; set; }
        public byte DurationOfLED { get; set; }
        public ushort MaxDistanceRange { get; set; }
        #endregion


        public SetRawDataConfig()
        {
            Sync = new byte[] { 0xFF, 0xFE, 0xFD, 0xFC };
            Cmd = BitConverter.GetBytes(CommandId.GETRAWDATAMODE);
        }

        public SetRawDataConfig(int a)
        {
            Sync = new byte[] { 0xFF, 0xFE, 0xFD, 0xFC };
            Cmd = BitConverter.GetBytes(CommandId.GETRAWDATAMODE);
            //Data = new byte[] { 0x01 };
            Data = BitConverter.GetBytes(a);
            ushort len = (ushort)(Cmd.Length + Data.Length);
            Size = BitConverter.GetBytes(len);

            ushort checksum = calculaChecksum();
            Chk = BitConverter.GetBytes(checksum);
        }

        public int MyProperty { get; set; }
        private ushort calculaChecksum()
        {
            int value = 0;
            for (int i = 0; i < Cmd.Length; i++)
            {
                value = value ^ Cmd[i];
            }
            for (int i = 0; i < Data.Length; i++)
            {
                value = value ^ Data[i];
            }
            return (ushort)value;
        }

        public void getDatavalue()
        {
            List<byte> datavalue = new List<byte>();
            datavalue.Add(Baudrate);
            datavalue.Add(0);
            datavalue.Add(LpzInfo);

            Data = datavalue.ToArray();
            ushort len = (ushort)(Cmd.Length + Data.Length);
            Size = BitConverter.GetBytes(len);

            ushort checksum = calculaChecksum();
            Chk = BitConverter.GetBytes(checksum);
        }
    }
}

