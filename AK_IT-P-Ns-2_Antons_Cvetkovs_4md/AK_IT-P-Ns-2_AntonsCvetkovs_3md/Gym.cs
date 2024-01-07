using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    internal class Gym : Model, ITableData
    {
        public int id { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string building { get; set; }

        public string TableName => "gym";
        public string PrimaryKey => "id";
    }
}
