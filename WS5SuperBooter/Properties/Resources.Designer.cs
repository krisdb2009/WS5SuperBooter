﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS5SuperBooter.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WS5SuperBooter.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to POST /10.2.66.1 HTTP/1.1 
        ///Connection: Keep-Alive 
        ///Content-Type: text/xml 
        ///User-Agent: MDS POS Client 
        ///Machine-Name-Src: BA-MI1 
        ///Machine-IP-Src: 10.0.1.8 
        ///Content-Length: 362 
        ///Host: 10.2.66.1:50123 
        ///
        ///&lt;SOAP-ENV:Envelope xmlns:SOAP-ENV=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot;&gt;&lt;SOAP-ENV:Body xmlns:MCRS-ENV=&quot;MCRS-URI&quot;&gt;
        ///   &lt;MCRS-ENV:Service&gt;MDSSYSUTILS&lt;/MCRS-ENV:Service&gt;
        ///   &lt;MCRS-ENV:Method&gt;Reboot&lt;/MCRS-ENV:Method&gt;
        ///&lt;MCRS-ENV:SessionKey&gt;Session&lt;/MCRS-ENV:SessionKey&gt;
        ///   &lt;MCRS-ENV:InputParameters&gt;&lt;/M [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RebootMessage {
            get {
                return ResourceManager.GetString("RebootMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon shut_down_cool_5 {
            get {
                object obj = ResourceManager.GetObject("shut_down_cool_5", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
