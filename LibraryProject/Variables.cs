using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
//using Oracle.DataAccess.Types;
//using Oracle.DataAccess.Client;
using System.Configuration;

namespace Vars.Properties
{
    class Variables
    {
        public static string host = "localhost";
        public static int port = 1521;
        public static string service_name = "xe";
        public static string userid = "DimasDataBase";
        public static string password = "Barbarossa#23";

        public static string connString = "Data Source = (DESCRIPTION = " +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = "+ host +")(PORT = "+ port +"))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = " + service_name + ")" +
            ")" +
            ");User Id =" + userid + ";password="+ password +";";
    }
}
