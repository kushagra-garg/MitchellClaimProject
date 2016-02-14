using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace MitchellClaimService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MitchellClaimService : IMitchellClaimService
    {
        DAL.DAL dal = new DAL.DAL();
        SqlCommand cmd = new SqlCommand();

        #region Interface method Implementation
        public string CreateClaim(ClaimInfo claim)
        {
            cmd.Parameters.AddWithValue("@claimNumber", claim.ClaimNumber);
            cmd.Parameters.AddWithValue("@firstName", claim.Firstname);
            cmd.Parameters.AddWithValue("@lastName", claim.LastName);
            cmd.Parameters.AddWithValue("@status", claim.Status);
            cmd.Parameters.AddWithValue("@lossDate", claim.LossDate);
            cmd.Parameters.AddWithValue("@adjusterId", claim.AdjusterId);
     
            if (claim.lossInfo == null)
                cmd.Parameters.AddWithValue("@lossDetails", 0);
            else {
                cmd.Parameters.AddWithValue("@lossCause", claim.lossInfo.LossCause);
                cmd.Parameters.AddWithValue("@reportedDate", claim.lossInfo.ReportedDate);
                cmd.Parameters.AddWithValue("@description", claim.lossInfo.Description);
            }

            DataTable vehicleInfoDt = CreateVehicleInfo(claim);

            if (vehicleInfoDt.Rows.Count == 0)
                cmd.Parameters.AddWithValue("@vehicleDetails", 0);

            cmd.Parameters.AddWithValue("@vehicleInfo", vehicleInfoDt);

            return dal.CreateClaim(cmd);
        }

        public DataSet SearchClaim(string claimNumber)
        {
            cmd.Parameters.AddWithValue("@claimNumber", claimNumber);
            return dal.SearchClaim(cmd);
        }

        public DataSet GetClaim(DateTime lossFromDate, DateTime lossToDate)
        {
            cmd.Parameters.AddWithValue("@lossFromDate", lossFromDate);
            cmd.Parameters.AddWithValue("@lossToDate", lossToDate);
            return dal.GetClaimList(cmd);
        }

        public string DeleteClaim(string claimNumber)
        {
            cmd.Parameters.AddWithValue("@claimNumber", claimNumber);
            return dal.DeleteClaim(cmd);
        }

        public DataSet GetVehicleClaim(string claimNumber, int modelYear)
        {
            cmd.Parameters.AddWithValue("@claimNumber", claimNumber);
            cmd.Parameters.AddWithValue("@modelYear", modelYear);
            return dal.GetVehicleClaim(cmd);
        }
        #endregion


        #region Private Method
        private DataTable CreateVehicleInfo(ClaimInfo info)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("claimNumber", typeof(string));
            dt.Columns.Add("modelYear", typeof(string));
            dt.Columns.Add("make", typeof(string));
            dt.Columns.Add("model", typeof(string));
            dt.Columns.Add("engine", typeof(string));
            dt.Columns.Add("color", typeof(string));
            dt.Columns.Add("vin", typeof(string));
            dt.Columns.Add("licPlate", typeof(string));
            dt.Columns.Add("state", typeof(string));
            dt.Columns.Add("expDate", typeof(string));
            dt.Columns.Add("damage", typeof(string));
            dt.Columns.Add("mileage", typeof(string));

            foreach (VehicleInfo details in 
                info.vehicleInfoList)
            {
                DataRow dr = dt.NewRow();
                dr[0] = info.ClaimNumber;
                dr[1] = details.ModelYear;
                dr[2] = details.Make;
                dr[3] = details.Model;
                dr[4] = details.Engine;
                dr[5] = details.color;
                dr[6] = details.Vin;
                dr[7] = details.LicPlate;
                dr[8] = details.State;
                dr[9] = details.ExpDate;
                dr[10] = details.Damage;
                dr[11] = details.Mileage;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        #endregion
    }
}
