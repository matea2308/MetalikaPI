using System.Configuration;
using System.IO;
using System.Reflection;

namespace Metalika
{
    class Konstante
    {
        // koristi se za one way enkripciju (prilikom logina i sl.)
        public static string EnkripcijskiKljuc = "2AR6737MDO7Q4E4U17S3";

        public static string GetConnectionString()
        {
            string connection = ConfigurationManager.ConnectionStrings["Entities"].ConnectionString;
            string exeLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            string newConnString = connection.Replace("LOCAL_DB_PATH", exeLocation + "\\Podatkovni_sloj\\MetalikaDB.mdf");

            return newConnString;
        }
    }
}
