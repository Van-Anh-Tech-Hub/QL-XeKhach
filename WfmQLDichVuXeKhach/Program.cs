using WfmQLDichVuXeKhach.GUI;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WfmQLDichVuXeKhach
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Frm_SignIn());
        }

    }
    public class ConnectStudio3T
    {
        private readonly IMongoDatabase Database;
        public ConnectStudio3T()
        {
            string conn = "mongodb://localhost:27017";
            var client = new MongoClient(conn);
            Database = client.GetDatabase("QLXeKhach");
        }
    }
}