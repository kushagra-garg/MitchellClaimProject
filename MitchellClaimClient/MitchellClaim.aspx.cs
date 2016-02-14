using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net;
using System.Text;
using System.IO;
using System.ServiceModel;
using System.Web.Services.Description;
using System.ServiceModel.Description;
using System.Xml;
using System.Drawing;

namespace MitchellClaimClient
{
    public partial class MitchellClaim : System.Web.UI.Page
    {
        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetInitialRowVehicle();
                Tab1.CssClass = "Clicked";
                MainView.ActiveViewIndex = 0;
            }
            ClientScript.GetPostBackEventReference(this, string.Empty);
        }
        #endregion

        #region Private Methods
        private void SetInitialRowVehicle()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add(new DataColumn("Year", typeof(string)));
            dt.Columns.Add(new DataColumn("Model", typeof(string)));
            dt.Columns.Add(new DataColumn("Engine", typeof(string)));
            dt.Columns.Add(new DataColumn("Color", typeof(string)));
            dt.Columns.Add(new DataColumn("Vin", typeof(string)));
            dt.Columns.Add(new DataColumn("LicPlate", typeof(string)));
            dt.Columns.Add(new DataColumn("LicState", typeof(string)));
            dt.Columns.Add(new DataColumn("LicExpDate", typeof(string)));
            dt.Columns.Add(new DataColumn("Damage", typeof(string)));
            dt.Columns.Add(new DataColumn("Mileage", typeof(string)));
            dr = dt.NewRow();

            dr["Year"] = string.Empty;
            dr["Model"] = string.Empty;
            dr["Engine"] = string.Empty;
            dr["Color"] = string.Empty;
            dr["Vin"] = string.Empty;
            dr["LicPlate"] = string.Empty;
            dr["LicState"] = string.Empty;
            dr["LicExpDate"] = string.Empty;
            dr["Damage"] = string.Empty;
            dr["Mileage"] = string.Empty;

            dt.Rows.Add(dr);
            //dr = dt.NewRow();

            //Store the DataTable in ViewState
            ViewState["CurrentTable"] = dt;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private void AddNewRowToGrid()
        {
            int rowIndex = 0;

            if (ViewState["CurrentTable"] != null)
            {
                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                DataRow drCurrentRow = null;
                if (dtCurrentTable.Rows.Count > 0)
                {
                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {
                        //extract the TextBox values
                        TextBox box1 = (TextBox)GridView1.Rows[rowIndex].Cells[1].FindControl("txtYear");
                        TextBox box2 = (TextBox)GridView1.Rows[rowIndex].Cells[2].FindControl("txtModel");
                        TextBox box3 = (TextBox)GridView1.Rows[rowIndex].Cells[3].FindControl("txtEngine");
                        TextBox box4 = (TextBox)GridView1.Rows[rowIndex].Cells[4].FindControl("txtColor");
                        TextBox box5 = (TextBox)GridView1.Rows[rowIndex].Cells[5].FindControl("txtVin");
                        TextBox box6 = (TextBox)GridView1.Rows[rowIndex].Cells[6].FindControl("txtLicPlate");
                        TextBox box7 = (TextBox)GridView1.Rows[rowIndex].Cells[7].FindControl("txtLicState");
                        TextBox box8 = (TextBox)GridView1.Rows[rowIndex].Cells[8].FindControl("txtLicExpDate");
                        TextBox box9 = (TextBox)GridView1.Rows[rowIndex].Cells[9].FindControl("txtDamage");
                        TextBox box10 = (TextBox)GridView1.Rows[rowIndex].Cells[10].FindControl("txtMileage");

                        drCurrentRow = dtCurrentTable.NewRow();

                        drCurrentRow["Year"] = box1.Text;
                        drCurrentRow["Model"] = box2.Text;
                        drCurrentRow["Engine"] = box3.Text;
                        drCurrentRow["Color"] = box4.Text;
                        drCurrentRow["Vin"] = box5.Text;
                        drCurrentRow["LicPlate"] = box6.Text;
                        drCurrentRow["LicState"] = box7.Text;
                        drCurrentRow["LicExpDate"] = box8.Text;
                        drCurrentRow["Damage"] = box9.Text;
                        drCurrentRow["Mileage"] = box10.Text;

                        rowIndex++;
                    }
                    dtCurrentTable.Rows.Add(drCurrentRow);
                    ViewState["CurrentTable"] = dtCurrentTable;

                    GridView1.DataSource = dtCurrentTable;
                    GridView1.DataBind();
                }
            }
            else
            {
                Response.Write("ViewState is null");
            }

            //Set Previous Data on Postbacks
            SetPreviousData();
        }
        private void SetPreviousData()
        {
            int rowIndex = 0;
            if (ViewState["CurrentTable"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTable"];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        TextBox box1 = (TextBox)GridView1.Rows[rowIndex].Cells[1].FindControl("txtYear");
                        TextBox box2 = (TextBox)GridView1.Rows[rowIndex].Cells[2].FindControl("txtModel");
                        TextBox box3 = (TextBox)GridView1.Rows[rowIndex].Cells[3].FindControl("txtEngine");
                        TextBox box4 = (TextBox)GridView1.Rows[rowIndex].Cells[4].FindControl("txtColor");
                        TextBox box5 = (TextBox)GridView1.Rows[rowIndex].Cells[5].FindControl("txtVin");
                        TextBox box6 = (TextBox)GridView1.Rows[rowIndex].Cells[6].FindControl("txtLicPlate");
                        TextBox box7 = (TextBox)GridView1.Rows[rowIndex].Cells[7].FindControl("txtLicState");
                        TextBox box8 = (TextBox)GridView1.Rows[rowIndex].Cells[8].FindControl("txtLicExpDate");
                        TextBox box9 = (TextBox)GridView1.Rows[rowIndex].Cells[9].FindControl("txtDamage");
                        TextBox box10 = (TextBox)GridView1.Rows[rowIndex].Cells[10].FindControl("txtMileage");


                        box1.Text = dt.Rows[i]["Year"].ToString();
                        box2.Text = dt.Rows[i]["Model"].ToString();
                        box3.Text = dt.Rows[i]["Engine"].ToString();
                        box4.Text = dt.Rows[i]["Color"].ToString();
                        box5.Text = dt.Rows[i]["Vin"].ToString();
                        box6.Text = dt.Rows[i]["LicPlate"].ToString();
                        box7.Text = dt.Rows[i]["LicState"].ToString();
                        box8.Text = dt.Rows[i]["LicExpDate"].ToString();
                        box9.Text = dt.Rows[i]["Damage"].ToString();
                        box10.Text = dt.Rows[i]["Mileage"].ToString();

                        rowIndex++;

                    }
                }
                // ViewState["CurrentTable"] = dt;

            }
        }
        private void CleareAllAddClaimcontrols()
        {
            txtClaimNumber.Text = string.Empty;
            txtFname.Text = string.Empty;
            txtLname.Text = string.Empty;
            ddlStatus.SelectedValue = string.Empty;
            lossDatePicker.Text = string.Empty;
            txtAdjusterId.Text = string.Empty;

            ddlLossCause.SelectedValue = string.Empty;
            txtreportedDate.Text = string.Empty;
            txtDescription.Text = string.Empty;

            SetInitialRowVehicle();
        }
        private void CleareAllViewClaimcontrols()
        {
            txtClaimNumberView.Text = string.Empty;
            txtFnameView.Text = string.Empty;
            txtLnameView.Text = string.Empty;
            ddlStatusView.SelectedValue = string.Empty;
            lossDatePickerView.Text = string.Empty;
            txtAdjusterIdView.Text = string.Empty;

            ddlLossCauseView.SelectedValue = string.Empty;
            txtreportedDateView.Text = string.Empty;
            txtDescriptionView.Text = string.Empty;

            GridView3.DataSource = null;
        }
        private void ClaimSelect(string name)
        {
            CleareAllViewClaimcontrols();
            MitchellClaimServiceReference.MitchellClaimServiceClient client = new MitchellClaimServiceReference.MitchellClaimServiceClient();
            DataSet result = client.SearchClaim(name);

            DataTable claimTable = result.Tables[0];
            DataTable LossTable = result.Tables[1];
            DataTable VehicleTable = result.Tables[2];
            if (claimTable.Rows.Count > 0)
            {
                txtClaimNumberView.Text = claimTable.Rows[0]["ClaimNumber"].ToString();
                txtFnameView.Text = claimTable.Rows[0]["ClaimantFirstName"].ToString();
                txtLnameView.Text = claimTable.Rows[0]["ClaimantLastName"].ToString();
                ddlStatusView.SelectedValue = claimTable.Rows[0]["Status"].ToString();
                lossDatePickerView.Text = claimTable.Rows[0]["LossDate"].ToString();
                txtAdjusterIdView.Text = claimTable.Rows[0]["AssignedAdjusterID"].ToString();
            }
            if (LossTable.Rows.Count > 0)
            {
                ddlLossCauseView.SelectedValue = LossTable.Rows[0]["LossCause"].ToString();
                txtreportedDateView.Text = LossTable.Rows[0]["ReportedDate"].ToString();
                txtDescriptionView.Text = LossTable.Rows[0]["LossDescription"].ToString();
            }
            if (VehicleTable.Rows.Count > 0)
            {
                GridView3.DataSource = VehicleTable;
                GridView3.DataBind();
            }
            Tab2.CssClass = "Clicked";
            MainView.ActiveViewIndex = 2;
        }
        private void DisplayClaimClick()
        {
            Tab1.CssClass = "Clicked";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Initial";
            MainView.ActiveViewIndex = 0;
        }
        #endregion

        #region Protected Methods - Events
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddNewRowToGrid();
        }
        // Hide the Remove Button at the last row of the GridView
        protected void Gridview1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataTable dt = (DataTable)ViewState["CurrentTable"];
                LinkButton lb = (LinkButton)e.Row.FindControl("LinkButton1");
                if (lb != null)
                {
                    if (dt.Rows.Count > 1)
                    {
                        if (e.Row.RowIndex == dt.Rows.Count - 1)
                        {
                            lb.Visible = false;
                        }
                    }
                    else
                    {
                        lb.Visible = false;
                    }
                }
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            GridViewRow gvRow = (GridViewRow)lb.NamingContainer;
            int rowID = gvRow.RowIndex + 1;
            if (ViewState["CurrentTable"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTable"];
                if (dt.Rows.Count > 1)
                {
                    if (gvRow.RowIndex < dt.Rows.Count - 1)
                    {
                        //Remove the Selected Row data
                        dt.Rows.Remove(dt.Rows[rowID]);
                    }
                }
                //Store the current data in ViewState for future reference
                ViewState["CurrentTable"] = dt;
                //Re bind the GridView for the updated data
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

            //Set Previous Data on Postbacks
            SetPreviousData();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            MitchellClaimServiceReference.ClaimInfo claim = new MitchellClaimServiceReference.ClaimInfo();
            MitchellClaimServiceReference.VehicleInfo vehicle;
            List<MitchellClaimServiceReference.VehicleInfo> vehicleList = new List<MitchellClaimServiceReference.VehicleInfo>();
            claim.lossInfo = new MitchellClaimServiceReference.LossInfo();

            claim.ClaimNumber = txtClaimNumber.Text;
            claim.Firstname = txtFname.Text;
            claim.LastName = txtLname.Text;
            claim.Status = string.IsNullOrEmpty(ddlStatus.SelectedValue) ? null : ddlStatus.SelectedValue;
            claim.LossDate = (string.IsNullOrEmpty(lossDatePicker.Text)) ? (DateTime?)null : DateTime.Parse(lossDatePicker.Text);
            claim.AdjusterId = string.IsNullOrEmpty(txtAdjusterId.Text) ? (Int64?)null : Convert.ToInt64(txtAdjusterId.Text);

            claim.lossInfo.LossCause = string.IsNullOrEmpty(ddlLossCause.SelectedValue) ? null : ddlLossCause.SelectedValue;
            claim.lossInfo.ReportedDate = (string.IsNullOrEmpty(txtreportedDate.Text)) ? (DateTime?)null : DateTime.Parse(txtreportedDate.Text);
            claim.lossInfo.Description = txtDescription.Text;

            DataTable dt = (DataTable)ViewState["CurrentTable"];


            if (dt.Rows.Count > 0)
            {
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    vehicle = new MitchellClaimServiceReference.VehicleInfo();
                    vehicle.ModelYear = string.IsNullOrEmpty(dt.Rows[i]["Year"].ToString()) ? (int?)null : Convert.ToInt16(dt.Rows[i]["Year"]);
                    vehicle.Model = dt.Rows[i]["Model"].ToString();
                    vehicle.Engine = dt.Rows[i]["Engine"].ToString();
                    vehicle.color = dt.Rows[i]["Color"].ToString();
                    vehicle.Vin = dt.Rows[i]["Vin"].ToString();
                    vehicle.LicPlate = dt.Rows[i]["LicPlate"].ToString();
                    vehicle.State = dt.Rows[i]["LicState"].ToString();
                    vehicle.ExpDate = (string.IsNullOrEmpty(dt.Rows[i]["LicExpDate"].ToString())) ? (DateTime?)null : DateTime.Parse(dt.Rows[i]["LicExpDate"].ToString());
                    vehicle.Damage = dt.Rows[i]["Damage"].ToString();
                    vehicle.Mileage = string.IsNullOrEmpty(dt.Rows[i]["Mileage"].ToString()) ? (int?)null : Convert.ToInt16(dt.Rows[i]["Mileage"]);
                    vehicleList.Add(vehicle);
                }
            }

            claim.vehicleInfoList = vehicleList.ToArray();

            MitchellClaimServiceReference.MitchellClaimServiceClient client = new MitchellClaimServiceReference.MitchellClaimServiceClient();
            string result = client.CreateClaim(claim);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + result + "');", true);
            CleareAllAddClaimcontrols();
            DisplayClaimClick();


            //string baseAddress = "http://localhost:57108/MitchellClaimService.svc";
            //ServiceHost host = new ServiceHost(typeof(Service), new Uri(baseAddress));
            //host.AddServiceEndpoint(typeof(MitchellClaimServiceReference.IMitchellClaimService), new WebHttpBinding(), "").Behaviors.Add(new WebHttpBehavior());
            //host.Open();

            // ASCIIEncoding encoding = new ASCIIEncoding();
            //string SampleXml = "<ClaimInfo>" +
            //                       "<ClaimNumber>" +
            //                        txtClaimNumber.Text +
            //                       "</ClaimNumber>" +
            //                   "</ClaimInfo>";

            // string SampleXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\"><s:Header></s:Header><s:Body><CreateClaim xmlns=\"http://tempuri.org/\"><ClaimNumber>WCFPOSTString</ClaimNumber></CreateClaim></s:Body></s:Envelope>";

            // //string postData = SampleXml.ToString();
            // //byte[] data = encoding.GetBytes(postData);

            // HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:57108/MitchellClaimService.svc");
            // // Set the Method property of the request to POST.
            // XmlDocument doc = new XmlDocument();
            // doc.LoadXml(SampleXml);
            //// doc.Load(@"C:\Users\HP-Coconut\Documents\Visual Studio 2015\Projects\MitchellClaim\MitchellClaimClient\createClaim.xml");

            // request.Method = "POST";
            // request.ContentType = "text/xml";
            // request.Headers.Add("SOAPAction", "http://tempuri.org/IMitchellClaimService/CreateClaim");
            // // set content length
            //// request.ContentLength = data.Length;
            // // get stream data out of webrequest object
            // Stream newStream = request.GetRequestStream();
            // doc.Save(newStream);
            //// newStream.Write(data, 0, data.Length);
            // newStream.Close();


            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:57108/MitchellClaimService.svc");
            //string data = "<?xml version=\"1.0\" encoding=\"utf-8\"?><s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\"><s:Header></s:Header><s:Body><CreateClaim xmlns=\"http://tempuri.org/\"><ClaimNumber>WCFPOSTString</ClaimNumber></CreateClaim></s:Body></s:Envelope>";
            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(data);
            //request.Method = "POST";
            //request.ContentType = "text/xml;charset=utf-8";
            //request.KeepAlive = false;
            ////request.ProtocolVersion = HttpVersion.Version11;
            //request.Headers.Add("SOAPAction", "http://tempuri.org/IMitchellClaimService/CreateClaim");
            //Stream stream = request.GetRequestStream();
            //doc.Save(stream);
            //stream.Close();
            //try
            //{
            //    //Gets the response
            //    HttpWebResponse myHttpWebResponse = (HttpWebResponse)request.GetResponse();
            //    //Writes the Response
            //    Stream responseStream = myHttpWebResponse.GetResponseStream();

            //    StreamReader sr = new StreamReader(responseStream);
            //    string s = sr.ReadToEnd();
            //}
            //catch (WebException webex)
            //{
            //    WebResponse errResp = webex.Response;
            //    using (Stream respStream = errResp.GetResponseStream())
            //    {
            //        StreamReader reader = new StreamReader(respStream);
            //        string text = reader.ReadToEnd();
            //    }
            //}


        }
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            MitchellClaimServiceReference.MitchellClaimServiceClient client = new MitchellClaimServiceReference.MitchellClaimServiceClient();
            DateTime fromDate = Convert.ToDateTime(txtFromDate.Text);
            DateTime toDate = Convert.ToDateTime(txtToDate.Text);
            DataSet result = client.GetClaim(fromDate, toDate);

            GridView2.DataSource = result.Tables[0];
            GridView2.DataBind();
        }
        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var firstCell = e.Row.Cells[0];
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(GridView2, "Select$" + e.Row.RowIndex.ToString()));
                e.Row.Attributes["style"] = "cursor:pointer";
                firstCell.ForeColor = Color.Blue;
            }
        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GridView2.SelectedRow.RowIndex;
            string name = GridView2.SelectedRow.Cells[0].Text;

            ClaimSelect(name);
        }
        protected void Tab2_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Clicked";
            Tab3.CssClass = "Initial";
            MainView.ActiveViewIndex = 1;
        }
        protected void Tab1_Click(object sender, EventArgs e)
        {
            DisplayClaimClick();
        }
        protected void Tab3_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Clicked";
            MainView.ActiveViewIndex = 2;
        }
        #endregion
    }
}