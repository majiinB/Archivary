using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.DATABASE
{
    public class DatabaseConnection
    {
        private static readonly string SERVER = "localhost";
        private static readonly string DATABASE = "archivary";
        private static readonly string ID = "root";
        private static readonly string PASS = "";
        public static string ConnectionDetails()
        {
            return $"Server={SERVER};Database={DATABASE};User ID={ID};Password={PASS};";
        }
    }
}
