﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MitchellClaimClient.MitchellClaimServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClaimInfo", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimService")]
    [System.SerializableAttribute()]
    public partial class ClaimInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> AdjusterIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaimNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> LossDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimClient.MitchellClaimServiceReference.LossInfo lossInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimClient.MitchellClaimServiceReference.VehicleInfo[] vehicleInfoListField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> AdjusterId {
            get {
                return this.AdjusterIdField;
            }
            set {
                if ((this.AdjusterIdField.Equals(value) != true)) {
                    this.AdjusterIdField = value;
                    this.RaisePropertyChanged("AdjusterId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClaimNumber {
            get {
                return this.ClaimNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaimNumberField, value) != true)) {
                    this.ClaimNumberField = value;
                    this.RaisePropertyChanged("ClaimNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LossDate {
            get {
                return this.LossDateField;
            }
            set {
                if ((this.LossDateField.Equals(value) != true)) {
                    this.LossDateField = value;
                    this.RaisePropertyChanged("LossDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MitchellClaimClient.MitchellClaimServiceReference.LossInfo lossInfo {
            get {
                return this.lossInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.lossInfoField, value) != true)) {
                    this.lossInfoField = value;
                    this.RaisePropertyChanged("lossInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MitchellClaimClient.MitchellClaimServiceReference.VehicleInfo[] vehicleInfoList {
            get {
                return this.vehicleInfoListField;
            }
            set {
                if ((object.ReferenceEquals(this.vehicleInfoListField, value) != true)) {
                    this.vehicleInfoListField = value;
                    this.RaisePropertyChanged("vehicleInfoList");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LossInfo", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimService")]
    [System.SerializableAttribute()]
    public partial class LossInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LossCauseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ReportedDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LossCause {
            get {
                return this.LossCauseField;
            }
            set {
                if ((object.ReferenceEquals(this.LossCauseField, value) != true)) {
                    this.LossCauseField = value;
                    this.RaisePropertyChanged("LossCause");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReportedDate {
            get {
                return this.ReportedDateField;
            }
            set {
                if ((this.ReportedDateField.Equals(value) != true)) {
                    this.ReportedDateField = value;
                    this.RaisePropertyChanged("ReportedDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleInfo", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimService")]
    [System.SerializableAttribute()]
    public partial class VehicleInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DamageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EngineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ExpDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicPlateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MileageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ModelYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string colorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Damage {
            get {
                return this.DamageField;
            }
            set {
                if ((object.ReferenceEquals(this.DamageField, value) != true)) {
                    this.DamageField = value;
                    this.RaisePropertyChanged("Damage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Engine {
            get {
                return this.EngineField;
            }
            set {
                if ((object.ReferenceEquals(this.EngineField, value) != true)) {
                    this.EngineField = value;
                    this.RaisePropertyChanged("Engine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ExpDate {
            get {
                return this.ExpDateField;
            }
            set {
                if ((this.ExpDateField.Equals(value) != true)) {
                    this.ExpDateField = value;
                    this.RaisePropertyChanged("ExpDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LicPlate {
            get {
                return this.LicPlateField;
            }
            set {
                if ((object.ReferenceEquals(this.LicPlateField, value) != true)) {
                    this.LicPlateField = value;
                    this.RaisePropertyChanged("LicPlate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Make {
            get {
                return this.MakeField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeField, value) != true)) {
                    this.MakeField = value;
                    this.RaisePropertyChanged("Make");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Mileage {
            get {
                return this.MileageField;
            }
            set {
                if ((this.MileageField.Equals(value) != true)) {
                    this.MileageField = value;
                    this.RaisePropertyChanged("Mileage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ModelYear {
            get {
                return this.ModelYearField;
            }
            set {
                if ((this.ModelYearField.Equals(value) != true)) {
                    this.ModelYearField = value;
                    this.RaisePropertyChanged("ModelYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vin {
            get {
                return this.VinField;
            }
            set {
                if ((object.ReferenceEquals(this.VinField, value) != true)) {
                    this.VinField = value;
                    this.RaisePropertyChanged("Vin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string color {
            get {
                return this.colorField;
            }
            set {
                if ((object.ReferenceEquals(this.colorField, value) != true)) {
                    this.colorField = value;
                    this.RaisePropertyChanged("color");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MitchellClaimServiceReference.IMitchellClaimService")]
    public interface IMitchellClaimService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/CreateClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/CreateClaimResponse")]
        string CreateClaim(MitchellClaimClient.MitchellClaimServiceReference.ClaimInfo claim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/CreateClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/CreateClaimResponse")]
        System.Threading.Tasks.Task<string> CreateClaimAsync(MitchellClaimClient.MitchellClaimServiceReference.ClaimInfo claim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/SearchClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/SearchClaimResponse")]
        System.Data.DataSet SearchClaim(string claimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/SearchClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/SearchClaimResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchClaimAsync(string claimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/GetClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/GetClaimResponse")]
        System.Data.DataSet GetClaim(System.DateTime lossFromDate, System.DateTime lossToDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/GetClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/GetClaimResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetClaimAsync(System.DateTime lossFromDate, System.DateTime lossToDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/DeleteClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/DeleteClaimResponse")]
        string DeleteClaim(string claimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/DeleteClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/DeleteClaimResponse")]
        System.Threading.Tasks.Task<string> DeleteClaimAsync(string claimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/GetVehicleClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/GetVehicleClaimResponse")]
        System.Data.DataSet GetVehicleClaim(string claimNumber, int modelYear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMitchellClaimService/GetVehicleClaim", ReplyAction="http://tempuri.org/IMitchellClaimService/GetVehicleClaimResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetVehicleClaimAsync(string claimNumber, int modelYear);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMitchellClaimServiceChannel : MitchellClaimClient.MitchellClaimServiceReference.IMitchellClaimService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MitchellClaimServiceClient : System.ServiceModel.ClientBase<MitchellClaimClient.MitchellClaimServiceReference.IMitchellClaimService>, MitchellClaimClient.MitchellClaimServiceReference.IMitchellClaimService {
        
        public MitchellClaimServiceClient() {
        }
        
        public MitchellClaimServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MitchellClaimServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MitchellClaimServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MitchellClaimServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CreateClaim(MitchellClaimClient.MitchellClaimServiceReference.ClaimInfo claim) {
            return base.Channel.CreateClaim(claim);
        }
        
        public System.Threading.Tasks.Task<string> CreateClaimAsync(MitchellClaimClient.MitchellClaimServiceReference.ClaimInfo claim) {
            return base.Channel.CreateClaimAsync(claim);
        }
        
        public System.Data.DataSet SearchClaim(string claimNumber) {
            return base.Channel.SearchClaim(claimNumber);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchClaimAsync(string claimNumber) {
            return base.Channel.SearchClaimAsync(claimNumber);
        }
        
        public System.Data.DataSet GetClaim(System.DateTime lossFromDate, System.DateTime lossToDate) {
            return base.Channel.GetClaim(lossFromDate, lossToDate);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetClaimAsync(System.DateTime lossFromDate, System.DateTime lossToDate) {
            return base.Channel.GetClaimAsync(lossFromDate, lossToDate);
        }
        
        public string DeleteClaim(string claimNumber) {
            return base.Channel.DeleteClaim(claimNumber);
        }
        
        public System.Threading.Tasks.Task<string> DeleteClaimAsync(string claimNumber) {
            return base.Channel.DeleteClaimAsync(claimNumber);
        }
        
        public System.Data.DataSet GetVehicleClaim(string claimNumber, int modelYear) {
            return base.Channel.GetVehicleClaim(claimNumber, modelYear);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetVehicleClaimAsync(string claimNumber, int modelYear) {
            return base.Channel.GetVehicleClaimAsync(claimNumber, modelYear);
        }
    }
}