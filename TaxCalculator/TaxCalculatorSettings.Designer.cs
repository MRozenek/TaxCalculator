﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxCalculator {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class TaxCalculatorSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static TaxCalculatorSettings defaultInstance = ((TaxCalculatorSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new TaxCalculatorSettings())));
        
        public static TaxCalculatorSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("85528")]
        public decimal TaxIncomeFirstStageUpToLimit {
            get {
                return ((decimal)(this["TaxIncomeFirstStageUpToLimit"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("19")]
        public decimal TaxIncomeFirstStageUpToValue {
            get {
                return ((decimal)(this["TaxIncomeFirstStageUpToValue"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("32")]
        public decimal TaxIncomeSecondStageUpToValue {
            get {
                return ((decimal)(this["TaxIncomeSecondStageUpToValue"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2147483647")]
        public decimal TaxIncomeSecondStageUpToLimit {
            get {
                return ((decimal)(this["TaxIncomeSecondStageUpToLimit"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("525.12")]
        public decimal TaxIncomeZeroStageUpToLimit {
            get {
                return ((decimal)(this["TaxIncomeZeroStageUpToLimit"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string TaxIncomeZeroStageUpToValue {
            get {
                return ((string)(this["TaxIncomeZeroStageUpToValue"]));
            }
        }
    }
}
