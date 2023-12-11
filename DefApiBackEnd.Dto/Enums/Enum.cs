using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefApiBackEnd.Dto.Enums
{
    public class Enum
    {
        public enum ConnectionTypes
        {
            POSTGRESQL = 0,
            SQLSERVER = 1,
            ODBC = 2
        }
    }
}
