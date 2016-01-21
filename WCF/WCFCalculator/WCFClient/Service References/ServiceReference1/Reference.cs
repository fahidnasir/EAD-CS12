﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBasicCalculator")]
    public interface IBasicCalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicCalculator/Add", ReplyAction="http://tempuri.org/IBasicCalculator/AddResponse")]
        double Add(double first, double second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicCalculator/Add", ReplyAction="http://tempuri.org/IBasicCalculator/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double first, double second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicCalculator/Subtract", ReplyAction="http://tempuri.org/IBasicCalculator/SubtractResponse")]
        double Subtract(double first, double second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicCalculator/Subtract", ReplyAction="http://tempuri.org/IBasicCalculator/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double first, double second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicCalculator/Multiply", ReplyAction="http://tempuri.org/IBasicCalculator/MultiplyResponse")]
        double Multiply(double first, double second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicCalculator/Multiply", ReplyAction="http://tempuri.org/IBasicCalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double first, double second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicCalculator/Divide", ReplyAction="http://tempuri.org/IBasicCalculator/DivideResponse")]
        double Divide(double first, double second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicCalculator/Divide", ReplyAction="http://tempuri.org/IBasicCalculator/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double first, double second);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBasicCalculatorChannel : WCFClient.ServiceReference1.IBasicCalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BasicCalculatorClient : System.ServiceModel.ClientBase<WCFClient.ServiceReference1.IBasicCalculator>, WCFClient.ServiceReference1.IBasicCalculator {
        
        public BasicCalculatorClient() {
        }
        
        public BasicCalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BasicCalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasicCalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasicCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double first, double second) {
            return base.Channel.Add(first, second);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double first, double second) {
            return base.Channel.AddAsync(first, second);
        }
        
        public double Subtract(double first, double second) {
            return base.Channel.Subtract(first, second);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double first, double second) {
            return base.Channel.SubtractAsync(first, second);
        }
        
        public double Multiply(double first, double second) {
            return base.Channel.Multiply(first, second);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double first, double second) {
            return base.Channel.MultiplyAsync(first, second);
        }
        
        public double Divide(double first, double second) {
            return base.Channel.Divide(first, second);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double first, double second) {
            return base.Channel.DivideAsync(first, second);
        }
    }
}