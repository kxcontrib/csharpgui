using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using kx;
using System.Collections;

namespace whitepaperTestingProject
{
    static class ConnectionPool
    {
        private static int MaxPoolSize = 10;
        private static readonly Queue connPool = new Queue(MaxPoolSize);
        private static int counter = 0;
        private static String HOST = "oy632c1n3";
        private static int PRIMARY_PORT = 5010;
        private static int SECONDARY_PORT = 15010;

        public static c GetConnection()
        {
            return GetConnection(null, null);
        }

        public static c GetSecondaryConnection()
        {
            return GetSecondaryConnection(null, null);
        }

        public static c GetConnection(String user, string password)
        {
            c connection;
            if ((connPool.Count > 0) && (counter < MaxPoolSize))
            {
                connection = RetrieveFromPool(HOST, PRIMARY_PORT,user,password);
            }
            else
            {
                connection = OpenConnection(HOST, PRIMARY_PORT, user, password);
                counter++;
            }
            return connection;
        }

        public static c GetSecondaryConnection(String user, string password)
        {
            c connection;
            if ((connPool.Count > 0) && (counter < MaxPoolSize))
            {
                connection = RetrieveFromPool(HOST, SECONDARY_PORT, user, password);
            }
            else
            {
                connection = OpenConnection(HOST, SECONDARY_PORT, user, password);
                counter++;
            }
            return connection;
        }

        private static c RetrieveFromPool(String host, int port, string user,string password)
        {
            c connection;

            // if there is any objects in my collection
            if ((connPool.Count > 0) && (counter < MaxPoolSize))
            {
                connection = (c)connPool.Dequeue();
            }
            else
            {
                // return a new object
                connection = OpenConnection(host, port, user, password);
                counter++;
            }
            return connection;
        }

        public static void ReturnConnection(c connection)
        {
            connPool.Enqueue(connection);
        }

        private static c OpenConnection(String host, int port,string user,string password)
        {
            try
            {
                c conn;
                if ((user == null) || (password == null))
                {
                    conn = new c(host, port); //Takes host and port
                }
                else
                {
                    conn = new c(host, port, user, password); 
                }
                if (conn == null) //Returns null if no connection was made
                {
                    throw new Exception("Connection could not be established");
                }
                else
                {
                    return conn; //If connection was made, return conn object
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("An unexpected error occurred: " + e.ToString()); //Catch any unexpected errors and fail gracefully.
                throw e;
            }
        }    
    }
}
