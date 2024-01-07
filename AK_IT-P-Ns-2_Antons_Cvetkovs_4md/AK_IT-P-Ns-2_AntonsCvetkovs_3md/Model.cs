using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    internal class Model : Database
    {
        public DataTable GetAll<T>() where T : Model, ITableData, new() // fucnkija atgriez visus ierakstus
        {
            DataTable data_table = new DataTable();
            try
            {
                data_table.Load((new SqlCommand($"SELECT * FROM {new T().TableName}", connection)).ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data from {new T().TableName}. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data_table;
        }

        public DataTable Search<T>(string column, string input) where T : Model, ITableData, new() // funkcija atgriez ierakstuts pec noraditas kolonnas vertibas
        {
            DataTable data_table = new DataTable();
            try
            {
                data_table.Load(new SqlCommand($"SELECT * FROM {new T().TableName} WHERE {column} LIKE '%{input}%'", connection).ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching data from {new T().TableName}. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data_table;
        }

        public List<string> GetColumns<T>() where T : Model, new() // funkcija atgriez tabulas kolonnas
        {
            List<string> columns = new List<string>();
            List<string> properties_to_remove = typeof(ITableData).GetProperties().Select(property => property.Name).ToList();

            foreach (var prop in typeof(T).GetProperties())
            {
                if (!properties_to_remove.Contains(prop.Name)) columns.Add(prop.Name);
            }

            return columns;
        }

        public void Create<T>(Dictionary<string, string> data) where T : Model, ITableData, new() // funkcija pievieno jaunu ierakstu tabulaa
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = 
                        $"INSERT INTO {new T().TableName} ({string.Join(", ", data.Keys)}) " +
                        $"VALUES ({string.Join(", ", data.Values.Select(value => $"'{value}'"))})";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating data in {new T().TableName}. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update<T>(DataRow row, object pk) where T : Model, ITableData, new() // funkcija, kas atjauno ierakstu tabulaa
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    string query = $"UPDATE {new T().TableName} SET ";

                    foreach (DataColumn column in row.Table.Columns)
                    {
                        if (column.ColumnName != new T().PrimaryKey)
                        {
                            query += $"{column.ColumnName} = '{row[column.ColumnName]}', ";
                        }
                    }

                    query = query.TrimEnd(',', ' ');
                    query += $" WHERE {new T().PrimaryKey} = '{pk}'";
                    Console.WriteLine(query);
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data in the database. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete<T>(string primary_key) where T : Model, ITableData, new() // funckija, kas nodes ierakstu tabulaa
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"DELETE FROM {new T().TableName} WHERE {new T().PrimaryKey} = '{primary_key}'";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting data from {new T().TableName}. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ImportData<T>(string file_path) where T : Model, ITableData, new() // importe datus no csv faila tabulaa
        {
            using (SqlBulkCopy bulk_copy = new SqlBulkCopy(connection))
            {
                bulk_copy.DestinationTableName = new T().TableName;

                using (TextFieldParser parser = new TextFieldParser(file_path))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    DataTable dt = new DataTable();

                    string[] fields = parser.ReadFields();

                    foreach (string field in fields) dt.Columns.Add(field);
                    while (!parser.EndOfData) dt.Rows.Add(parser.ReadFields());

                    bulk_copy.WriteToServer(dt);
                }
            }
        }

        public string GetPrimaryKey<T>() where T : Model, ITableData, new() // atgriez tabulas primaro atslegu
        {
            return new T().PrimaryKey;
        }
    }
}
