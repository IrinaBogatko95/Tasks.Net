﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrameworkTestJournals.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class SettingsNameBrowser : global::System.Configuration.ApplicationSettingsBase {
        
        private static SettingsNameBrowser defaultInstance = ((SettingsNameBrowser)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SettingsNameBrowser())));
        
        public static SettingsNameBrowser Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"chrome\"")]
        public string CHROME {
            get {
                return ((string)(this["CHROME"]));
            }
            set {
                this["CHROME"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"firefox\"")]
        public string FIREFOX {
            get {
                return ((string)(this["FIREFOX"]));
            }
            set {
                this["FIREFOX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"IE\"")]
        public string IE {
            get {
                return ((string)(this["IE"]));
            }
            set {
                this["IE"] = value;
            }
        }
    }
}