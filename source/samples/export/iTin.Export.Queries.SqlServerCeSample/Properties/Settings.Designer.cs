﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iTin.Export.Queries.SqlServerCe.Sample.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=|DataDirectory|\\Resources\\Database\\ChinookDatabase.sdf")]
        public string ChinookDatabaseConnectionString {
            get {
                return ((string)(this["ChinookDatabaseConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\resources\\configuration\\InvoiceConfigurationFile.xml")]
        public string InvoiceExportConfigurationFile {
            get {
                return ((string)(this["InvoiceExportConfigurationFile"]));
            }
            set {
                this["InvoiceExportConfigurationFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\resources\\input\\InvoiceXmlInput.xml")]
        public string InvoiceXmlImput {
            get {
                return ((string)(this["InvoiceXmlImput"]));
            }
            set {
                this["InvoiceXmlImput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\resources\\input\\ProductXmlInput.xml")]
        public string ProductXmlInput {
            get {
                return ((string)(this["ProductXmlInput"]));
            }
            set {
                this["ProductXmlInput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\resources\\configuration\\ProductConfigurationFile.xml")]
        public string ProductExportConfigurationFile {
            get {
                return ((string)(this["ProductExportConfigurationFile"]));
            }
            set {
                this["ProductExportConfigurationFile"] = value;
            }
        }
    }
}
