﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculater.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cong", ReplyAction="*")]
        float Cong(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cong", ReplyAction="*")]
        System.Threading.Tasks.Task<float> CongAsync(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Tru", ReplyAction="*")]
        float Tru(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Tru", ReplyAction="*")]
        System.Threading.Tasks.Task<float> TruAsync(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Nhan", ReplyAction="*")]
        float Nhan(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Nhan", ReplyAction="*")]
        System.Threading.Tasks.Task<float> NhanAsync(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Chia", ReplyAction="*")]
        float Chia(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Chia", ReplyAction="*")]
        System.Threading.Tasks.Task<float> ChiaAsync(float a, float b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Calculater.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Calculater.ServiceReference1.WebService1Soap>, Calculater.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float Cong(float a, float b) {
            return base.Channel.Cong(a, b);
        }
        
        public System.Threading.Tasks.Task<float> CongAsync(float a, float b) {
            return base.Channel.CongAsync(a, b);
        }
        
        public float Tru(float a, float b) {
            return base.Channel.Tru(a, b);
        }
        
        public System.Threading.Tasks.Task<float> TruAsync(float a, float b) {
            return base.Channel.TruAsync(a, b);
        }
        
        public float Nhan(float a, float b) {
            return base.Channel.Nhan(a, b);
        }
        
        public System.Threading.Tasks.Task<float> NhanAsync(float a, float b) {
            return base.Channel.NhanAsync(a, b);
        }
        
        public float Chia(float a, float b) {
            return base.Channel.Chia(a, b);
        }
        
        public System.Threading.Tasks.Task<float> ChiaAsync(float a, float b) {
            return base.Channel.ChiaAsync(a, b);
        }
    }
}
