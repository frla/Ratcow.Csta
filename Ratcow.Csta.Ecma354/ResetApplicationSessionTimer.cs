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
    public partial class ResetApplicationSessionTimer {
        
        private string sessionIDField;
        
        private string requestedSessionDurationField;
        
        private ResetApplicationSessionTimerExtensions extensionsField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string requestedSessionDuration {
            get {
                return this.requestedSessionDurationField;
            }
            set {
                this.requestedSessionDurationField = value;
            }
        }
        
        /// <remarks/>
        public ResetApplicationSessionTimerExtensions extensions {
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
    public partial class ResetApplicationSessionTimerExtensions {
        
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session", IsNullable=false)]
    public partial class ResetApplicationSessionTimerPosResponse {
        
        private string actualSessionDurationField;
        
        private ResetApplicationSessionTimerPosResponseExtensions extensionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string actualSessionDuration {
            get {
                return this.actualSessionDurationField;
            }
            set {
                this.actualSessionDurationField = value;
            }
        }
        
        /// <remarks/>
        public ResetApplicationSessionTimerPosResponseExtensions extensions {
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
    public partial class ResetApplicationSessionTimerPosResponseExtensions {
        
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session", IsNullable=false)]
    public partial class ResetApplicationSessionTimerNegResponse {
        
        private ResetApplicationSessionTimerNegResponseErrorCode errorCodeField;
        
        private ResetApplicationSessionTimerNegResponseExtensions extensionsField;
        
        /// <remarks/>
        public ResetApplicationSessionTimerNegResponseErrorCode errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        public ResetApplicationSessionTimerNegResponseExtensions extensions {
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
    public partial class ResetApplicationSessionTimerNegResponseErrorCode {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("applError", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("definedError", typeof(ResetApplicationSessionTimerNegResponseErrorCodeDefinedError))]
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
    public enum ResetApplicationSessionTimerNegResponseErrorCodeDefinedError {
        
        /// <remarks/>
        invalidSessionID,
        
        /// <remarks/>
        serverCannotResetSessionTimer,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ecma-international.org/standards/ecma-354/appl_session")]
    public partial class ResetApplicationSessionTimerNegResponseExtensions {
        
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
