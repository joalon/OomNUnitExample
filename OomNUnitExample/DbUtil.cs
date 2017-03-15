using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OomNUnitExample
{
    public class DbUtil
    {
        public static void InsertSeed(string DbName)
        {

        }

        public static void CreateDb(string dbName)
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=Test01;Trusted_Connection=True;"))
            {
                var dropIfExists = string.Format("IF(SELECT COUNT(*) FROM sys.databases WHERE name = '{0}') > 0 BEGIN ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [{0}] END", dbName);
                using (SqlCommand cmd = new SqlCommand(dropIfExists, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }
        }

        public static void DropDb(string dbName)
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=Test01;Trusted_Connection=True;"))
            {
                var dropIfExists = string.Format("IF(SELECT COUNT(*) FROM sys.databases WHERE name = '{0}') > 0 BEGIN ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [{0}] END", dbName);
                using (SqlCommand cmd = new SqlCommand(dropIfExists, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }
        }

    }
}
