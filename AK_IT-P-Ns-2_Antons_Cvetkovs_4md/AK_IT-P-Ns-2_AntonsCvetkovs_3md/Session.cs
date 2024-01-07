using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    internal class Session : Model, ITableData
    {
        public int id { get; set; }
        public string client { get; set; }
        public int gym_id { get; set; }
        public DateTime date { get; set; }

        public string TableName => "session";
        public string PrimaryKey => "id";
    }
}
