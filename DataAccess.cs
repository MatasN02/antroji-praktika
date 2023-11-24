using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;

namespace FormUI
{
    public class DataAccess
    {
        public List<studentas> GetPeople()
        {
            using (MySqlConnection connection = new MySqlConnection(helper.CnnVal("iverciuSistema")))
            {
                var output = connection.Query<studentas>($"SELECT studentas.studentoID, studentas.vardas, studentas.pavarde, grupe.pavadinimas FROM studentas INNER JOIN grupe ON studentas.grupesID=grupe.grupesID").ToList();

                return output;
            }
        }

        public List<grupe> GetGrupes()
        {
            using (MySqlConnection connection = new MySqlConnection(helper.CnnVal("iverciuSistema")))
            {
                var output = connection.Query<grupe>($"SELECT * FROM grupe").ToList();
                return output;
            }
        }
    }
}
