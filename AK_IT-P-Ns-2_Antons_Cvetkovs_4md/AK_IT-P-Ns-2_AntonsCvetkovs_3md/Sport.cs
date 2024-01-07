using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    internal class Sport : Model, ITableData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string TableName => "sport";
        public string PrimaryKey => "id";
    }
}
