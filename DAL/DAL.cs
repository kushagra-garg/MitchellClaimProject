using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL
    {
        //  private static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=MitchellClaimDB.mdf; Integrated Security=True";
        private static string connString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP-Coconut\Documents\Visual Studio 2015\Projects\MitchellClaimDB.mdf;Integrated Security = True";
        private SqlConnection conn = new SqlConnection(connString);

        public string CreateClaim(SqlCommand cmd)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string storedProc = "CreateMitchellClaim";
                    cmd.Connection = conn;
                    cmd.CommandText = storedProc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    string result = "Record Added Successfully!";
                    return result;
                }
            }
            catch (Exception ex)
            {
                return "Primary Key Violation";
            }
        }

        public DataSet SearchClaim(SqlCommand cmd)
        {
            DataSet ds = new DataSet();
            try
            {
                using (conn)
                {
                    conn.Open();
                    string storedProc = "GetMitchellClaim";
                    cmd.Connection = conn;
                    cmd.CommandText = storedProc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    conn.Close();
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Not able to fetch a Record");
            }
        }

        public DataSet GetClaimList(SqlCommand cmd)
        {
            DataSet ds = new DataSet();
            try
            {
                using (conn)
                {
                    conn.Open();
                    string storedProc = "GetMitchellClaimList";
                    cmd.Connection = conn;
                    cmd.CommandText = storedProc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    conn.Close();
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Not able to fetch a Record List");
            }
        }

        public string DeleteClaim(SqlCommand cmd)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string storedProc = "DeleteMitchellClaim";
                    cmd.Connection = conn;
                    cmd.CommandText = storedProc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    string result = "Record Deleted Successfully!";
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Not able to delete a Record");
            }
        }

        public DataSet GetVehicleClaim(SqlCommand cmd)
        {
            DataSet ds = new DataSet();
            try
            {
                using (conn)
                {
                    conn.Open();
                    string storedProc = "GetVehicleClaim";
                    cmd.Connection = conn;
                    cmd.CommandText = storedProc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    conn.Close();
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Not able to fetch a vehicle for a particular claim");
            }
        }



    }

}

