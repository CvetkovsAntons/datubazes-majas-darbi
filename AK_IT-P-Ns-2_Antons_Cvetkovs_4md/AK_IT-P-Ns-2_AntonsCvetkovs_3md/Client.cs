using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    internal class Client : Model, ITableData
    {
        public string personal_code { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public int phone_num { get; set; }

        public string TableName => "client";
        public string PrimaryKey => "personal_code";
    }
}
