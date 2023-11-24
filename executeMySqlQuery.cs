using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    internal class ExecuteMySqlCommand
    {
        public void executeNoReturnQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(helper.CnnVal("iverciusistema")))
            {
                connection.Open(); // būtina rašyti, nes kitaip neveiks. 

                MySqlCommand someCmd = new MySqlCommand(query, connection);
                someCmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        public int executeReturnQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(helper.CnnVal("iverciusistema")))
            {
                connection.Open(); // būtina rašyti, nes kitaip neveiks. 

                MySqlCommand someCmd = new MySqlCommand(query, connection);

                int groupId = (int)someCmd.ExecuteScalar();

                connection.Close();
                return (int)groupId;
            }
        }

        public DataTable getDataInListFormTable(string query)
        {
            DataTable aDataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(helper.CnnVal("iverciusistema")))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    aDataTable.Load(reader);
                }
            }

            return aDataTable;
        }



    }
}
