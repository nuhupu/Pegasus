using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEGASUS.Protocol.lzru920_u921.Enum
{
    public class CommandId
    {
        /// <summary>
        /// khai báo mã ra lệnh
        /// </summary>
        public const ushort SETRAWDATAMODE = 50001;
        /// <summary>
        /// 
        /// </summary>
        public const ushort SETRAWDATACONFIG = 50003;
        /// <summary>
        /// 
        /// </summary>
        public const ushort GETRAWDATADISTANCEVALUES = 50011;
        /// <summary>
        /// 
        /// </summary>
        public const ushort SETRAWDATAERRORLOGRESET = 50006;
        /// <summary>
        /// 
        /// </summary>
        public const ushort SETRAWDATAFRAMECOUNTERRESET = 50014;
        /// <summary>
        /// 
        /// </summary>
        public const ushort GETRAWDATAMODE = 50002;
        /// <summary>
        /// 
        /// </summary>
        public const ushort GETRAWDATACONFIG = 50004;
    }
}
