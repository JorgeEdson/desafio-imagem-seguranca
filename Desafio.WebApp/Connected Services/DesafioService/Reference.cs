﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desafio.WebApp.DesafioService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DesafioService.IDesafioService")]
    public interface IDesafioService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesafioService/AbrirFechar", ReplyAction="http://tempuri.org/IDesafioService/AbrirFecharResponse")]
        string AbrirFechar(int endereco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesafioService/AbrirFechar", ReplyAction="http://tempuri.org/IDesafioService/AbrirFecharResponse")]
        System.Threading.Tasks.Task<string> AbrirFecharAsync(int endereco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesafioService/ManterAberto", ReplyAction="http://tempuri.org/IDesafioService/ManterAbertoResponse")]
        string ManterAberto(int endereco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesafioService/ManterAberto", ReplyAction="http://tempuri.org/IDesafioService/ManterAbertoResponse")]
        System.Threading.Tasks.Task<string> ManterAbertoAsync(int endereco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesafioService/Fechar", ReplyAction="http://tempuri.org/IDesafioService/FecharResponse")]
        string Fechar(int endereco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesafioService/Fechar", ReplyAction="http://tempuri.org/IDesafioService/FecharResponse")]
        System.Threading.Tasks.Task<string> FecharAsync(int endereco);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDesafioServiceChannel : Desafio.WebApp.DesafioService.IDesafioService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DesafioServiceClient : System.ServiceModel.ClientBase<Desafio.WebApp.DesafioService.IDesafioService>, Desafio.WebApp.DesafioService.IDesafioService {
        
        public DesafioServiceClient() {
        }
        
        public DesafioServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DesafioServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DesafioServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DesafioServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AbrirFechar(int endereco) {
            return base.Channel.AbrirFechar(endereco);
        }
        
        public System.Threading.Tasks.Task<string> AbrirFecharAsync(int endereco) {
            return base.Channel.AbrirFecharAsync(endereco);
        }
        
        public string ManterAberto(int endereco) {
            return base.Channel.ManterAberto(endereco);
        }
        
        public System.Threading.Tasks.Task<string> ManterAbertoAsync(int endereco) {
            return base.Channel.ManterAbertoAsync(endereco);
        }
        
        public string Fechar(int endereco) {
            return base.Channel.Fechar(endereco);
        }
        
        public System.Threading.Tasks.Task<string> FecharAsync(int endereco) {
            return base.Channel.FecharAsync(endereco);
        }
    }
}
