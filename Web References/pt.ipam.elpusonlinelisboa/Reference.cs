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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WpfExcelLPAIPAMLx_V2.pt.ipam.elpusonlinelisboa {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebSapiSoap", Namespace="http://tempuri.org/WebServiceSAPI/Service1")]
    public partial class WebSapi : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ExecuteOperationCompleted;
        
        private System.Threading.SendOrPostCallback StreamExecuteOperationCompleted;
        
        private System.Threading.SendOrPostCallback StreamPutOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFunctionDetailOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFunctionsListOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebSapi() {
            this.Url = global::WpfExcelLPAIPAMLx_V2.Properties.Settings.Default.WpfExcelLPAIPAMLx_V2_pt_ipam_elpusonlinelisboa_WebSapi;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ExecuteCompletedEventHandler ExecuteCompleted;
        
        /// <remarks/>
        public event StreamExecuteCompletedEventHandler StreamExecuteCompleted;
        
        /// <remarks/>
        public event StreamPutCompletedEventHandler StreamPutCompleted;
        
        /// <remarks/>
        public event GetFunctionDetailCompletedEventHandler GetFunctionDetailCompleted;
        
        /// <remarks/>
        public event GetFunctionsListCompletedEventHandler GetFunctionsListCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebServiceSAPI/Service1/Execute", RequestNamespace="http://tempuri.org/WebServiceSAPI/Service1", ResponseNamespace="http://tempuri.org/WebServiceSAPI/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Execute(string Funcao, int NivelComp, string Certificado, string FormatoOutput, string PEntrada, string PSaida) {
            object[] results = this.Invoke("Execute", new object[] {
                        Funcao,
                        NivelComp,
                        Certificado,
                        FormatoOutput,
                        PEntrada,
                        PSaida});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ExecuteAsync(string Funcao, int NivelComp, string Certificado, string FormatoOutput, string PEntrada, string PSaida) {
            this.ExecuteAsync(Funcao, NivelComp, Certificado, FormatoOutput, PEntrada, PSaida, null);
        }
        
        /// <remarks/>
        public void ExecuteAsync(string Funcao, int NivelComp, string Certificado, string FormatoOutput, string PEntrada, string PSaida, object userState) {
            if ((this.ExecuteOperationCompleted == null)) {
                this.ExecuteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteOperationCompleted);
            }
            this.InvokeAsync("Execute", new object[] {
                        Funcao,
                        NivelComp,
                        Certificado,
                        FormatoOutput,
                        PEntrada,
                        PSaida}, this.ExecuteOperationCompleted, userState);
        }
        
        private void OnExecuteOperationCompleted(object arg) {
            if ((this.ExecuteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExecuteCompleted(this, new ExecuteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebServiceSAPI/Service1/StreamExecute", RequestNamespace="http://tempuri.org/WebServiceSAPI/Service1", ResponseNamespace="http://tempuri.org/WebServiceSAPI/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string StreamExecute(string Funcao, int NivelComp, string Certificado, string FormatoOutput, string PEntrada, string PSaida, ref object BytesSaida) {
            object[] results = this.Invoke("StreamExecute", new object[] {
                        Funcao,
                        NivelComp,
                        Certificado,
                        FormatoOutput,
                        PEntrada,
                        PSaida,
                        BytesSaida});
            BytesSaida = ((object)(results[1]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void StreamExecuteAsync(string Funcao, int NivelComp, string Certificado, string FormatoOutput, string PEntrada, string PSaida, object BytesSaida) {
            this.StreamExecuteAsync(Funcao, NivelComp, Certificado, FormatoOutput, PEntrada, PSaida, BytesSaida, null);
        }
        
        /// <remarks/>
        public void StreamExecuteAsync(string Funcao, int NivelComp, string Certificado, string FormatoOutput, string PEntrada, string PSaida, object BytesSaida, object userState) {
            if ((this.StreamExecuteOperationCompleted == null)) {
                this.StreamExecuteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStreamExecuteOperationCompleted);
            }
            this.InvokeAsync("StreamExecute", new object[] {
                        Funcao,
                        NivelComp,
                        Certificado,
                        FormatoOutput,
                        PEntrada,
                        PSaida,
                        BytesSaida}, this.StreamExecuteOperationCompleted, userState);
        }
        
        private void OnStreamExecuteOperationCompleted(object arg) {
            if ((this.StreamExecuteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StreamExecuteCompleted(this, new StreamExecuteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebServiceSAPI/Service1/StreamPut", RequestNamespace="http://tempuri.org/WebServiceSAPI/Service1", ResponseNamespace="http://tempuri.org/WebServiceSAPI/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string StreamPut(string Funcao, int NivelComp, string Certificado, string FormatoOutput, string PEntrada, string PSaida, object BytesEntrada) {
            object[] results = this.Invoke("StreamPut", new object[] {
                        Funcao,
                        NivelComp,
                        Certificado,
                        FormatoOutput,
                        PEntrada,
                        PSaida,
                        BytesEntrada});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void StreamPutAsync(string Funcao, int NivelComp, string Certificado, string FormatoOutput, string PEntrada, string PSaida, object BytesEntrada) {
            this.StreamPutAsync(Funcao, NivelComp, Certificado, FormatoOutput, PEntrada, PSaida, BytesEntrada, null);
        }
        
        /// <remarks/>
        public void StreamPutAsync(string Funcao, int NivelComp, string Certificado, string FormatoOutput, string PEntrada, string PSaida, object BytesEntrada, object userState) {
            if ((this.StreamPutOperationCompleted == null)) {
                this.StreamPutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStreamPutOperationCompleted);
            }
            this.InvokeAsync("StreamPut", new object[] {
                        Funcao,
                        NivelComp,
                        Certificado,
                        FormatoOutput,
                        PEntrada,
                        PSaida,
                        BytesEntrada}, this.StreamPutOperationCompleted, userState);
        }
        
        private void OnStreamPutOperationCompleted(object arg) {
            if ((this.StreamPutCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StreamPutCompleted(this, new StreamPutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebServiceSAPI/Service1/GetFunctionDetail", RequestNamespace="http://tempuri.org/WebServiceSAPI/Service1", ResponseNamespace="http://tempuri.org/WebServiceSAPI/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFunctionDetail(string NomeFunc, string FormatoInput, string FormatoOutput) {
            object[] results = this.Invoke("GetFunctionDetail", new object[] {
                        NomeFunc,
                        FormatoInput,
                        FormatoOutput});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetFunctionDetailAsync(string NomeFunc, string FormatoInput, string FormatoOutput) {
            this.GetFunctionDetailAsync(NomeFunc, FormatoInput, FormatoOutput, null);
        }
        
        /// <remarks/>
        public void GetFunctionDetailAsync(string NomeFunc, string FormatoInput, string FormatoOutput, object userState) {
            if ((this.GetFunctionDetailOperationCompleted == null)) {
                this.GetFunctionDetailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFunctionDetailOperationCompleted);
            }
            this.InvokeAsync("GetFunctionDetail", new object[] {
                        NomeFunc,
                        FormatoInput,
                        FormatoOutput}, this.GetFunctionDetailOperationCompleted, userState);
        }
        
        private void OnGetFunctionDetailOperationCompleted(object arg) {
            if ((this.GetFunctionDetailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFunctionDetailCompleted(this, new GetFunctionDetailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebServiceSAPI/Service1/GetFunctionsList", RequestNamespace="http://tempuri.org/WebServiceSAPI/Service1", ResponseNamespace="http://tempuri.org/WebServiceSAPI/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFunctionsList(string FormatoInput, string FormatoOutput) {
            object[] results = this.Invoke("GetFunctionsList", new object[] {
                        FormatoInput,
                        FormatoOutput});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetFunctionsListAsync(string FormatoInput, string FormatoOutput) {
            this.GetFunctionsListAsync(FormatoInput, FormatoOutput, null);
        }
        
        /// <remarks/>
        public void GetFunctionsListAsync(string FormatoInput, string FormatoOutput, object userState) {
            if ((this.GetFunctionsListOperationCompleted == null)) {
                this.GetFunctionsListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFunctionsListOperationCompleted);
            }
            this.InvokeAsync("GetFunctionsList", new object[] {
                        FormatoInput,
                        FormatoOutput}, this.GetFunctionsListOperationCompleted, userState);
        }
        
        private void OnGetFunctionsListOperationCompleted(object arg) {
            if ((this.GetFunctionsListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFunctionsListCompleted(this, new GetFunctionsListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ExecuteCompletedEventHandler(object sender, ExecuteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExecuteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExecuteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void StreamExecuteCompletedEventHandler(object sender, StreamExecuteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StreamExecuteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal StreamExecuteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public object BytesSaida {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void StreamPutCompletedEventHandler(object sender, StreamPutCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StreamPutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal StreamPutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetFunctionDetailCompletedEventHandler(object sender, GetFunctionDetailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFunctionDetailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFunctionDetailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetFunctionsListCompletedEventHandler(object sender, GetFunctionsListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFunctionsListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFunctionsListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591