﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.UtilitiesWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfDouble", Namespace="http://tempuri.org/", ItemName="double")]
    [System.SerializableAttribute()]
    public class ArrayOfDouble : System.Collections.Generic.List<double> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UtilitiesWS.UtilitiesWSSoap")]
    public interface UtilitiesWSSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WpfApp1.UtilitiesWS.HelloWorldResponse HelloWorld(WpfApp1.UtilitiesWS.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WpfApp1.UtilitiesWS.HelloWorldResponse> HelloWorldAsync(WpfApp1.UtilitiesWS.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name CalculatePercentageResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculatePercentage", ReplyAction="*")]
        WpfApp1.UtilitiesWS.CalculatePercentageResponse CalculatePercentage(WpfApp1.UtilitiesWS.CalculatePercentageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculatePercentage", ReplyAction="*")]
        System.Threading.Tasks.Task<WpfApp1.UtilitiesWS.CalculatePercentageResponse> CalculatePercentageAsync(WpfApp1.UtilitiesWS.CalculatePercentageRequest request);
        
        // CODEGEN: Generating message contract since element name Amount from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAmount", ReplyAction="*")]
        WpfApp1.UtilitiesWS.GetAmountResponse GetAmount(WpfApp1.UtilitiesWS.GetAmountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAmount", ReplyAction="*")]
        System.Threading.Tasks.Task<WpfApp1.UtilitiesWS.GetAmountResponse> GetAmountAsync(WpfApp1.UtilitiesWS.GetAmountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDistanceCovered", ReplyAction="*")]
        double GetDistanceCovered(double FuelBought_Litres, double FuelConsumtion_MilesPerGallon, double LitresInGallon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDistanceCovered", ReplyAction="*")]
        System.Threading.Tasks.Task<double> GetDistanceCoveredAsync(double FuelBought_Litres, double FuelConsumtion_MilesPerGallon, double LitresInGallon);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WpfApp1.UtilitiesWS.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WpfApp1.UtilitiesWS.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WpfApp1.UtilitiesWS.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WpfApp1.UtilitiesWS.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculatePercentageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculatePercentage", Namespace="http://tempuri.org/", Order=0)]
        public WpfApp1.UtilitiesWS.CalculatePercentageRequestBody Body;
        
        public CalculatePercentageRequest() {
        }
        
        public CalculatePercentageRequest(WpfApp1.UtilitiesWS.CalculatePercentageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculatePercentageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double GrossAmount;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public double percentage;
        
        public CalculatePercentageRequestBody() {
        }
        
        public CalculatePercentageRequestBody(double GrossAmount, double percentage) {
            this.GrossAmount = GrossAmount;
            this.percentage = percentage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculatePercentageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculatePercentageResponse", Namespace="http://tempuri.org/", Order=0)]
        public WpfApp1.UtilitiesWS.CalculatePercentageResponseBody Body;
        
        public CalculatePercentageResponse() {
        }
        
        public CalculatePercentageResponse(WpfApp1.UtilitiesWS.CalculatePercentageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculatePercentageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WpfApp1.UtilitiesWS.ArrayOfDouble CalculatePercentageResult;
        
        public CalculatePercentageResponseBody() {
        }
        
        public CalculatePercentageResponseBody(WpfApp1.UtilitiesWS.ArrayOfDouble CalculatePercentageResult) {
            this.CalculatePercentageResult = CalculatePercentageResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAmountRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAmount", Namespace="http://tempuri.org/", Order=0)]
        public WpfApp1.UtilitiesWS.GetAmountRequestBody Body;
        
        public GetAmountRequest() {
        }
        
        public GetAmountRequest(WpfApp1.UtilitiesWS.GetAmountRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAmountRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Amount;
        
        public GetAmountRequestBody() {
        }
        
        public GetAmountRequestBody(string Amount) {
            this.Amount = Amount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAmountResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAmountResponse", Namespace="http://tempuri.org/", Order=0)]
        public WpfApp1.UtilitiesWS.GetAmountResponseBody Body;
        
        public GetAmountResponse() {
        }
        
        public GetAmountResponse(WpfApp1.UtilitiesWS.GetAmountResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAmountResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public decimal GetAmountResult;
        
        public GetAmountResponseBody() {
        }
        
        public GetAmountResponseBody(decimal GetAmountResult) {
            this.GetAmountResult = GetAmountResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UtilitiesWSSoapChannel : WpfApp1.UtilitiesWS.UtilitiesWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UtilitiesWSSoapClient : System.ServiceModel.ClientBase<WpfApp1.UtilitiesWS.UtilitiesWSSoap>, WpfApp1.UtilitiesWS.UtilitiesWSSoap {
        
        public UtilitiesWSSoapClient() {
        }
        
        public UtilitiesWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UtilitiesWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UtilitiesWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UtilitiesWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WpfApp1.UtilitiesWS.HelloWorldResponse WpfApp1.UtilitiesWS.UtilitiesWSSoap.HelloWorld(WpfApp1.UtilitiesWS.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WpfApp1.UtilitiesWS.HelloWorldRequest inValue = new WpfApp1.UtilitiesWS.HelloWorldRequest();
            inValue.Body = new WpfApp1.UtilitiesWS.HelloWorldRequestBody();
            WpfApp1.UtilitiesWS.HelloWorldResponse retVal = ((WpfApp1.UtilitiesWS.UtilitiesWSSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WpfApp1.UtilitiesWS.HelloWorldResponse> WpfApp1.UtilitiesWS.UtilitiesWSSoap.HelloWorldAsync(WpfApp1.UtilitiesWS.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WpfApp1.UtilitiesWS.HelloWorldResponse> HelloWorldAsync() {
            WpfApp1.UtilitiesWS.HelloWorldRequest inValue = new WpfApp1.UtilitiesWS.HelloWorldRequest();
            inValue.Body = new WpfApp1.UtilitiesWS.HelloWorldRequestBody();
            return ((WpfApp1.UtilitiesWS.UtilitiesWSSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WpfApp1.UtilitiesWS.CalculatePercentageResponse WpfApp1.UtilitiesWS.UtilitiesWSSoap.CalculatePercentage(WpfApp1.UtilitiesWS.CalculatePercentageRequest request) {
            return base.Channel.CalculatePercentage(request);
        }
        
        public WpfApp1.UtilitiesWS.ArrayOfDouble CalculatePercentage(double GrossAmount, double percentage) {
            WpfApp1.UtilitiesWS.CalculatePercentageRequest inValue = new WpfApp1.UtilitiesWS.CalculatePercentageRequest();
            inValue.Body = new WpfApp1.UtilitiesWS.CalculatePercentageRequestBody();
            inValue.Body.GrossAmount = GrossAmount;
            inValue.Body.percentage = percentage;
            WpfApp1.UtilitiesWS.CalculatePercentageResponse retVal = ((WpfApp1.UtilitiesWS.UtilitiesWSSoap)(this)).CalculatePercentage(inValue);
            return retVal.Body.CalculatePercentageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WpfApp1.UtilitiesWS.CalculatePercentageResponse> WpfApp1.UtilitiesWS.UtilitiesWSSoap.CalculatePercentageAsync(WpfApp1.UtilitiesWS.CalculatePercentageRequest request) {
            return base.Channel.CalculatePercentageAsync(request);
        }
        
        public System.Threading.Tasks.Task<WpfApp1.UtilitiesWS.CalculatePercentageResponse> CalculatePercentageAsync(double GrossAmount, double percentage) {
            WpfApp1.UtilitiesWS.CalculatePercentageRequest inValue = new WpfApp1.UtilitiesWS.CalculatePercentageRequest();
            inValue.Body = new WpfApp1.UtilitiesWS.CalculatePercentageRequestBody();
            inValue.Body.GrossAmount = GrossAmount;
            inValue.Body.percentage = percentage;
            return ((WpfApp1.UtilitiesWS.UtilitiesWSSoap)(this)).CalculatePercentageAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WpfApp1.UtilitiesWS.GetAmountResponse WpfApp1.UtilitiesWS.UtilitiesWSSoap.GetAmount(WpfApp1.UtilitiesWS.GetAmountRequest request) {
            return base.Channel.GetAmount(request);
        }
        
        public decimal GetAmount(string Amount) {
            WpfApp1.UtilitiesWS.GetAmountRequest inValue = new WpfApp1.UtilitiesWS.GetAmountRequest();
            inValue.Body = new WpfApp1.UtilitiesWS.GetAmountRequestBody();
            inValue.Body.Amount = Amount;
            WpfApp1.UtilitiesWS.GetAmountResponse retVal = ((WpfApp1.UtilitiesWS.UtilitiesWSSoap)(this)).GetAmount(inValue);
            return retVal.Body.GetAmountResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WpfApp1.UtilitiesWS.GetAmountResponse> WpfApp1.UtilitiesWS.UtilitiesWSSoap.GetAmountAsync(WpfApp1.UtilitiesWS.GetAmountRequest request) {
            return base.Channel.GetAmountAsync(request);
        }
        
        public System.Threading.Tasks.Task<WpfApp1.UtilitiesWS.GetAmountResponse> GetAmountAsync(string Amount) {
            WpfApp1.UtilitiesWS.GetAmountRequest inValue = new WpfApp1.UtilitiesWS.GetAmountRequest();
            inValue.Body = new WpfApp1.UtilitiesWS.GetAmountRequestBody();
            inValue.Body.Amount = Amount;
            return ((WpfApp1.UtilitiesWS.UtilitiesWSSoap)(this)).GetAmountAsync(inValue);
        }
        
        public double GetDistanceCovered(double FuelBought_Litres, double FuelConsumtion_MilesPerGallon, double LitresInGallon) {
            return base.Channel.GetDistanceCovered(FuelBought_Litres, FuelConsumtion_MilesPerGallon, LitresInGallon);
        }
        
        public System.Threading.Tasks.Task<double> GetDistanceCoveredAsync(double FuelBought_Litres, double FuelConsumtion_MilesPerGallon, double LitresInGallon) {
            return base.Channel.GetDistanceCoveredAsync(FuelBought_Litres, FuelConsumtion_MilesPerGallon, LitresInGallon);
        }
    }
}
