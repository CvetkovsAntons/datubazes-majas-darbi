using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    internal class GymSport : Model, ITableData
    {
        public int gym_id { get; set; }
        public int sport_id { get; set; }

        public string TableName => "gym_sport";
        public string PrimaryKey => "gym_id";
    }
}
