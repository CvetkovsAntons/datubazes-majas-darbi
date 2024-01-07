using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    internal interface ITableData
    {
        string TableName { get; }
        string PrimaryKey { get; }
    }
}
