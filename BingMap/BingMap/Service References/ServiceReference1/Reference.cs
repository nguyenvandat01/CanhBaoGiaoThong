﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace BingMap.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WarningTrafficService")]
    public partial class User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string emailField;
        
        private string passwordField;
        
        private string nameField;
        
        private string phoneField;
        
        private string addressField;
        
        private System.Collections.ObjectModel.ObservableCollection<BingMap.ServiceReference1.Warning> WarningsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public System.Collections.ObjectModel.ObservableCollection<BingMap.ServiceReference1.Warning> Warnings {
            get {
                return this.WarningsField;
            }
            set {
                if ((object.ReferenceEquals(this.WarningsField, value) != true)) {
                    this.WarningsField = value;
                    this.RaisePropertyChanged("Warnings");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Warning", Namespace="http://schemas.datacontract.org/2004/07/WarningTrafficService")]
    public partial class Warning : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idWarningField;
        
        private string addressField;
        
        private string contentWarningField;
        
        private string timeField;
        
        private string policeField;
        
        private string hotlineField;
        
        private string emailField;
        
        private System.Nullable<double> lonField;
        
        private System.Nullable<double> latField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idWarning {
            get {
                return this.idWarningField;
            }
            set {
                if ((this.idWarningField.Equals(value) != true)) {
                    this.idWarningField = value;
                    this.RaisePropertyChanged("idWarning");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string contentWarning {
            get {
                return this.contentWarningField;
            }
            set {
                if ((object.ReferenceEquals(this.contentWarningField, value) != true)) {
                    this.contentWarningField = value;
                    this.RaisePropertyChanged("contentWarning");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string time {
            get {
                return this.timeField;
            }
            set {
                if ((object.ReferenceEquals(this.timeField, value) != true)) {
                    this.timeField = value;
                    this.RaisePropertyChanged("time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string police {
            get {
                return this.policeField;
            }
            set {
                if ((object.ReferenceEquals(this.policeField, value) != true)) {
                    this.policeField = value;
                    this.RaisePropertyChanged("police");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string hotline {
            get {
                return this.hotlineField;
            }
            set {
                if ((object.ReferenceEquals(this.hotlineField, value) != true)) {
                    this.hotlineField = value;
                    this.RaisePropertyChanged("hotline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public System.Nullable<double> lon {
            get {
                return this.lonField;
            }
            set {
                if ((this.lonField.Equals(value) != true)) {
                    this.lonField = value;
                    this.RaisePropertyChanged("lon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public System.Nullable<double> lat {
            get {
                return this.latField;
            }
            set {
                if ((this.latField.Equals(value) != true)) {
                    this.latField = value;
                    this.RaisePropertyChanged("lat");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Law", Namespace="http://schemas.datacontract.org/2004/07/WarningTrafficService")]
    public partial class Law : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idLawField;
        
        private string nameLawField;
        
        private string contentLawField;
        
        private string condemnField;
        
        private string descriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idLaw {
            get {
                return this.idLawField;
            }
            set {
                if ((this.idLawField.Equals(value) != true)) {
                    this.idLawField = value;
                    this.RaisePropertyChanged("idLaw");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nameLaw {
            get {
                return this.nameLawField;
            }
            set {
                if ((object.ReferenceEquals(this.nameLawField, value) != true)) {
                    this.nameLawField = value;
                    this.RaisePropertyChanged("nameLaw");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string contentLaw {
            get {
                return this.contentLawField;
            }
            set {
                if ((object.ReferenceEquals(this.contentLawField, value) != true)) {
                    this.contentLawField = value;
                    this.RaisePropertyChanged("contentLaw");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string condemn {
            get {
                return this.condemnField;
            }
            set {
                if ((object.ReferenceEquals(this.condemnField, value) != true)) {
                    this.condemnField = value;
                    this.RaisePropertyChanged("condemn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWarningTrafficService")]
    public interface IWarningTrafficService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/Login", ReplyAction="http://tempuri.org/IWarningTrafficService/LoginResponse")]
        System.Threading.Tasks.Task<BingMap.ServiceReference1.User> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/Register", ReplyAction="http://tempuri.org/IWarningTrafficService/RegisterResponse")]
        System.Threading.Tasks.Task RegisterAsync(BingMap.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/CheckEmail", ReplyAction="http://tempuri.org/IWarningTrafficService/CheckEmailResponse")]
        System.Threading.Tasks.Task<bool> CheckEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/GetAllLaw", ReplyAction="http://tempuri.org/IWarningTrafficService/GetAllLawResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<BingMap.ServiceReference1.Law>> GetAllLawAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/GetLawByID", ReplyAction="http://tempuri.org/IWarningTrafficService/GetLawByIDResponse")]
        System.Threading.Tasks.Task<BingMap.ServiceReference1.Law> GetLawByIDAsync(int lawID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/SuggestLaw", ReplyAction="http://tempuri.org/IWarningTrafficService/SuggestLawResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<string>> SuggestLawAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/SearchLawByName", ReplyAction="http://tempuri.org/IWarningTrafficService/SearchLawByNameResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<BingMap.ServiceReference1.Law>> SearchLawByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/GetAllWarning", ReplyAction="http://tempuri.org/IWarningTrafficService/GetAllWarningResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<BingMap.ServiceReference1.Warning>> GetAllWarningAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/GetWarningByID", ReplyAction="http://tempuri.org/IWarningTrafficService/GetWarningByIDResponse")]
        System.Threading.Tasks.Task<BingMap.ServiceReference1.Warning> GetWarningByIDAsync(int idWarning);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/AddWarning", ReplyAction="http://tempuri.org/IWarningTrafficService/AddWarningResponse")]
        System.Threading.Tasks.Task AddWarningAsync(BingMap.ServiceReference1.Warning wn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarningTrafficService/DeleteWarning", ReplyAction="http://tempuri.org/IWarningTrafficService/DeleteWarningResponse")]
        System.Threading.Tasks.Task DeleteWarningAsync(int idWn);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWarningTrafficServiceChannel : BingMap.ServiceReference1.IWarningTrafficService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WarningTrafficServiceClient : System.ServiceModel.ClientBase<BingMap.ServiceReference1.IWarningTrafficService>, BingMap.ServiceReference1.IWarningTrafficService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WarningTrafficServiceClient() : 
                base(WarningTrafficServiceClient.GetDefaultBinding(), WarningTrafficServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWarningTrafficService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WarningTrafficServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WarningTrafficServiceClient.GetBindingForEndpoint(endpointConfiguration), WarningTrafficServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WarningTrafficServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WarningTrafficServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WarningTrafficServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WarningTrafficServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WarningTrafficServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<BingMap.ServiceReference1.User> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
        
        public System.Threading.Tasks.Task RegisterAsync(BingMap.ServiceReference1.User user) {
            return base.Channel.RegisterAsync(user);
        }
        
        public System.Threading.Tasks.Task<bool> CheckEmailAsync(string email) {
            return base.Channel.CheckEmailAsync(email);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<BingMap.ServiceReference1.Law>> GetAllLawAsync() {
            return base.Channel.GetAllLawAsync();
        }
        
        public System.Threading.Tasks.Task<BingMap.ServiceReference1.Law> GetLawByIDAsync(int lawID) {
            return base.Channel.GetLawByIDAsync(lawID);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<string>> SuggestLawAsync(string text) {
            return base.Channel.SuggestLawAsync(text);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<BingMap.ServiceReference1.Law>> SearchLawByNameAsync(string name) {
            return base.Channel.SearchLawByNameAsync(name);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<BingMap.ServiceReference1.Warning>> GetAllWarningAsync() {
            return base.Channel.GetAllWarningAsync();
        }
        
        public System.Threading.Tasks.Task<BingMap.ServiceReference1.Warning> GetWarningByIDAsync(int idWarning) {
            return base.Channel.GetWarningByIDAsync(idWarning);
        }
        
        public System.Threading.Tasks.Task AddWarningAsync(BingMap.ServiceReference1.Warning wn) {
            return base.Channel.AddWarningAsync(wn);
        }
        
        public System.Threading.Tasks.Task DeleteWarningAsync(int idWn) {
            return base.Channel.DeleteWarningAsync(idWn);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWarningTrafficService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWarningTrafficService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:53429/WarningTrafficService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return WarningTrafficServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWarningTrafficService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return WarningTrafficServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWarningTrafficService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IWarningTrafficService,
        }
    }
}
