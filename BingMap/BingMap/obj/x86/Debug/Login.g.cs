﻿#pragma checksum "D:\WindowApp\BingMap\BingMap\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E5CF64255E7B033EE58CB3DCD7129F70"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BingMap
{
    partial class Login : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.EmailTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.PassWordPassBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 3:
                {
                    this.Aboutme = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 74 "..\..\..\Login.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Aboutme).Tapped += this.Aboutme_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.SigninButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 61 "..\..\..\Login.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SigninButton).Click += this.Signin_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.SignupButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 64 "..\..\..\Login.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SignupButton).Click += this.SignupButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
