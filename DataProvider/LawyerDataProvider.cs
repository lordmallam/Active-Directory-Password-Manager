using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADPasswordManager.Models;
using Dapper;
using System.Data;

namespace ADPasswordManager.DataProvider
{
    public class LawyerDataProvider: ILawyerDataProvider
    {

        private readonly string connectionString = Params.sqlConnectionString;

        public async Task<Lawyers> GetLawyer(string Username)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Lawyers WHERE Username = @Username;";
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@Username", Username);
                return await sqlConnection.QuerySingleOrDefaultAsync<Lawyers>(sql, new { Username = Username });
            }
        }

        public async Task<IEnumerable<Lawyers>> GetLawyers()
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                return await sqlConnection.QueryAsync<Lawyers>("SELECT * FROM Lawyers");
            }
        }
    }
}
