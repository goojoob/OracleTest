using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace OracleTest
{
    class Database
    {
        private String hostIP;
        private String hostPort;
        private String serviceName;
        private String userScheme;
        private String passScheme;
        private String dataSource;

        private OracleConnection connection;

        public Database(String ip, String port, String service, String user, String pass)
        {
            hostIP = ip;
            hostPort = port;
            serviceName = service;
            userScheme = user;
            passScheme = pass;

            dataSource = "Data Source = (DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + hostIP + ")" +
                         "(PORT=" + hostPort + ")))" +
                         "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=" + serviceName + "))); " +
                         "User Id = " + userScheme + "; " +
                         "Password = " + passScheme + ";";
        }



        public void oracleOpenConnection()
        {
            try
            {
                connection = new OracleConnection(dataSource);
                connection.Open();
            }
            catch (Exception e)
            {
                throw new Exception("\nDatabase: Error opening Oracle connection:\n" + e, e);
            }
        }

        public void oracleCloseConnection()
        {
            try
            {
                connection.Close();
                connection.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("\nDatabase: Error closing Oracle connection:\n" + e, e);
            }
        }

        public void executeSQL(String sql)
        {
            try
            {
                oracleOpenConnection();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                oracleCloseConnection();
            }
            catch (System.InvalidOperationException e)
            {
                throw new Exception("\nDatabase: Invalid Operation executing SQL:\n" + e, e);
            }
            catch (Oracle.DataAccess.Client.OracleException e)
            {
                throw new Exception("\nDatabase: Oracle Exception executing SQL:\n" + e, e);
            }
            catch (Exception e)
            {
                throw new Exception("\nDatabase: Exception executing SQL:\n" + e, e);
            }
        }

    }
}