﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace VegasScriptRemoveJimakuPrefix.Properties
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Vegas : global::System.Configuration.ApplicationSettingsBase
    {

        private static Vegas defaultInstance = ((Vegas)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Vegas())));

        public static Vegas Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public float audioInsertInterval
        {
            get
            {
                return ((float)(this["audioInsertInterval"]));
            }
            set
            {
                this["audioInsertInterval"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string openDirectory
        {
            get
            {
                return ((string)(this["openDirectory"]));
            }
            set
            {
                this["openDirectory"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool isRecursive
        {
            get
            {
                return ((bool)(this["isRecursive"]));
            }
            set
            {
                this["isRecursive"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool startFrom
        {
            get
            {
                return ((bool)(this["startFrom"]));
            }
            set
            {
                this["startFrom"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public double assignEventMargin
        {
            get
            {
                return ((double)(this["assignEventMargin"]));
            }
            set
            {
                this["assignEventMargin"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Subtitles")]
        public string targetAssignTrackName
        {
            get
            {
                return ((string)(this["targetAssignTrackName"]));
            }
            set
            {
                this["targetAssignTrackName"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double jimakuOutlineWidth
        {
            get
            {
                return ((double)(this["jimakuOutlineWidth"]));
            }
            set
            {
                this["jimakuOutlineWidth"] = value;
            }
        }
    }
}
