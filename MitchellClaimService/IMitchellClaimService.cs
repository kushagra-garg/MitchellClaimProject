using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MitchellClaimService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMitchellClaimService
    {       
        [OperationContract]
        //[WebInvoke(
        //Method = "POST",
        //UriTemplate = "/CreateClaim",
        //RequestFormat = WebMessageFormat.Xml,
        //ResponseFormat = WebMessageFormat.Xml,
        //BodyStyle = WebMessageBodyStyle.Bare)]
        string CreateClaim(ClaimInfo claim);

        [OperationContract]
        DataSet SearchClaim(string claimNumber);

        [OperationContract]
        DataSet GetClaim(DateTime lossFromDate, DateTime lossToDate);

        [OperationContract]
        string DeleteClaim(string claimNumber);

        [OperationContract]
        DataSet GetVehicleClaim (string claimNumber, int modelYear);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class ClaimInfo
    {
        private string _claimNumber;
        private string _firstname;
        private string _lastName;
        private string _status;
        private DateTime? _lossDate;
        private Int64? _adjusterId;

        [DataMember]
        public LossInfo lossInfo
        { get; set; }

        [DataMember]
        public List<VehicleInfo> vehicleInfoList
        { get; set; }

        [DataMember]
        public string ClaimNumber
        {
            get { return _claimNumber; }
            set { _claimNumber = value; }
        }

        [DataMember]
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        [DataMember]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        [DataMember]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        [DataMember]
        public DateTime? LossDate
        {
            get { return _lossDate; }
            set { _lossDate = value; }
        }

        [DataMember]
        public Int64? AdjusterId
        {
            get { return _adjusterId; }
            set { _adjusterId = value; }
        }
    }

    [DataContract]
    public class LossInfo
    {
        private string _lossCause;
        private DateTime? _reportedDate;
        private string _description;

        [DataMember]
        public string LossCause
        {
            get { return _lossCause; }
            set { _lossCause = value; }
        }

        [DataMember]
        public DateTime? ReportedDate
        {
            get { return _reportedDate; }
            set { _reportedDate = value; }
        }

        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }

    [DataContract]
    public class VehicleInfo
    {
        private int? _modelYear;
        private string _make;
        private string _model;
        private string _engine;
        private string _color;
        private string _vin;
        private string _licPlate;
        private string _state;
        private DateTime? _expDate;
        private string _damage;
        private int? _mileage;

        [DataMember]
        public int? ModelYear
        {
            get { return _modelYear; }
            set { _modelYear = value; }
        }

        [DataMember]
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        [DataMember]
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        [DataMember]
        public string Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        [DataMember]
        public string color
        {
            get { return _color; }
            set { _color = value; }
        }

        [DataMember]
        public string Vin
        {
            get { return _vin; }
            set { _vin = value; }
        }

        [DataMember]
        public string LicPlate
        {
            get { return _licPlate; }
            set { _licPlate = value; }
        }

        [DataMember]
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        [DataMember]
        public DateTime? ExpDate
        {
            get { return _expDate; }
            set { _expDate = value; }
        }

        [DataMember]
        public string Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        [DataMember]
        public int? Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }
    }

}
