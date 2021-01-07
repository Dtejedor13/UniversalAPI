using System;
using System.Collections.Generic;
using EFDataAccessCore.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace EFDataAccessCore
{
    public class ProfilMerkmalSqlController :IDisposable
    {
        public List<ProfilMerkmalModel> DBset = new List<ProfilMerkmalModel>();

        public ProfilMerkmalSqlController()
        {
            const string connectionstring = "Data Source=RTOS22S;Integrated Security=True";

            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                DBset = connection.Query<ProfilMerkmalModel>("SELECT * FROM dbo.tblKProfilMerkmale").ToList();
            }
            
        }

        public void Dispose()
        {
            
        }
    }
}
