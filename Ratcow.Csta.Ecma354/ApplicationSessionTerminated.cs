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
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Ratcow.Csta.Ecma354 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session", IsNullable=false)]
    public partial class ApplicationSessionTerminated {
        
        private string sessionIDField;
        
        private ApplicationSessionTerminatedSessionTermReason sessionTermReasonField;
        
        private ApplicationSessionTerminatedExtensions extensionsField;
        
        /// <remarks/>
        public string sessionID {
            get {
                return this.sessionIDField;
            }
            set {
                this.sessionIDField = value;
            }
        }
        
        /// <remarks/>
        public ApplicationSessionTerminatedSessionTermReason sessionTermReason {
            get {
                return this.sessionTermReasonField;
            }
            set {
                this.sessionTermReasonField = value;
            }
        }
        
        /// <remarks/>
        public ApplicationSessionTerminatedExtensions extensions {
            get {
                return this.extensionsField;
            }
            set {
                this.extensionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session")]
    public partial class ApplicationSessionTerminatedSessionTermReason {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("definedTermReason", typeof(ApplicationSessionTerminatedSessionTermReasonDefinedTermReason))]
        [System.Xml.Serialization.XmlElementAttribute("serverTermReason", typeof(string))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session")]
    public enum ApplicationSessionTerminatedSessionTermReasonDefinedTermReason {
        
        /// <remarks/>
        resourceLimitation,
        
        /// <remarks/>
        sessionTimerExpired,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session")]
    public partial class ApplicationSessionTerminatedExtensions {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
}
