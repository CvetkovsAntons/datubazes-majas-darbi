using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    internal class Database
    {
        protected SqlConnection connection;

        private string database = "sport_club";

        public Database()
        {
            connection = new SqlConnection($"Data Source=(local);Initial Catalog={database};Integrated Security=True;MultipleActiveResultSets=True");
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot connect to db. Error: " + ex.Message);
            }
        }

        public void DeleteAllData() // izdes visus ierakstus, visas tabulas datubazee
        {
            try
            {
                string query = $"SELECT table_name FROM {database}.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string table_name = reader["table_name"].ToString();

                            using (SqlCommand deleteCommand = new SqlCommand($"DELETE FROM {table_name}", connection))
                            {
                                deleteCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting all data from database. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
