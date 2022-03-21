using System.Configuration;

namespace DapperLibrary.Models
{
    public class OpleidingenDbManager
    {
        public static string ConStr(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
