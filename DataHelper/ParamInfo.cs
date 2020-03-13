using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public class ParamInfo
    {
        public string ParamName { get; set; }
        public DbType ParamType { get; set; }
        public ParameterDirection ParamDirection { get; set; }
        public uint ParamSize { get; set; }
        public uint ParamScale { get; set; }
        public string SourceCloumn { get; set; }
        public DataRowVersion DataRowVersion { get; set; }

        public ParamInfo(string paramName, DbType paramType, ParameterDirection paramDirection, uint paramSize, uint paramScale, string sourceCloumn, DataRowVersion dataVersion)
        {
            this.ParamName = paramName;
            this.ParamType = paramType;
            this.ParamDirection = paramDirection;
            this.ParamSize = paramSize;
            this.ParamScale = paramScale;
            this.SourceCloumn = sourceCloumn;
            this.DataRowVersion = dataVersion;
        }

    }
}
