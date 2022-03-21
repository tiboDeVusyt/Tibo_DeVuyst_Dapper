using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DapperLibrary.Models
{
    public class OpleidingenService
    {
        public static List<Campus> GetCampuses()
        {
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.ConStr("Opleidingen")))
            {
                string sql = "select * from Campussen";
                var result = connection.Query<Campus>(sql).ToList();
                return result;
            }
        }
        public static List<Docent> GetDocentsByCampus(int CampusNr)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@CampusNr", CampusNr);
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.ConStr("Opleidingen")))
            {
                List<Docent> result = connection.Query<Docent>("spGetDocentByCampus", param, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public static void AddDocent(Docent docent)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Voornaam", docent.Voornaam);
            param.Add("@Familienaam", docent.Familienaam);
            param.Add("@Wedde", docent.Wedde);
            param.Add("@CampusNr", docent.CampusNr);
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.ConStr("Opleidingen")))
            {
                 connection.Query<Docent>("spAddDocent", param, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static void DelDocent(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", id);
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.ConStr("Opleidingen")))

            {
                 connection.Query<Docent>("spDelDocent", param, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
