﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmsPanel
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SmsPanel.ISMSWebService")]
    public interface ISMSWebService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMSWebService/SendSMSAuth", ReplyAction="http://tempuri.org/ISMSWebService/SendSMSAuthResponse")]
        System.Threading.Tasks.Task<string> SendSMSAuthAsync(string Username, string Password, string Number, string Text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMSWebService/SendSMS", ReplyAction="http://tempuri.org/ISMSWebService/SendSMSResponse")]
        System.Threading.Tasks.Task<string> SendSMSAsync(string Number, string Text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMSWebService/CheckSMS", ReplyAction="http://tempuri.org/ISMSWebService/CheckSMSResponse")]
        System.Threading.Tasks.Task<int> CheckSMSAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface ISMSWebServiceChannel : SmsPanel.ISMSWebService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SMSWebServiceClient : System.ServiceModel.ClientBase<SmsPanel.ISMSWebService>, SmsPanel.ISMSWebService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SMSWebServiceClient() : 
                base(SMSWebServiceClient.GetDefaultBinding(), SMSWebServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISMSWebService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SMSWebServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SMSWebServiceClient.GetBindingForEndpoint(endpointConfiguration), SMSWebServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SMSWebServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SMSWebServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SMSWebServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SMSWebServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SMSWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> SendSMSAuthAsync(string Username, string Password, string Number, string Text)
        {
            return base.Channel.SendSMSAuthAsync(Username, Password, Number, Text);
        }
        
        public System.Threading.Tasks.Task<string> SendSMSAsync(string Number, string Text)
        {
            return base.Channel.SendSMSAsync(Number, Text);
        }
        
        public System.Threading.Tasks.Task<int> CheckSMSAsync()
        {
            return base.Channel.CheckSMSAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISMSWebService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISMSWebService))
            {
                return new System.ServiceModel.EndpointAddress("http://s33.nri.niroo/SendSMS.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SMSWebServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISMSWebService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SMSWebServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISMSWebService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISMSWebService,
        }
    }
}