﻿#pragma checksum "C:\Users\Windows 10 Gamer\source\repos\XP_Assignment\XP_Assignment\Views\UserInteraction\RegisterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D19621B18AE106D00CF8F27C6B7978C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XP_Assignment.Views.UserInteraction
{
    partial class RegisterPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\UserInteraction\RegisterPage.xaml line 61
                {
                    this.FirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Views\UserInteraction\RegisterPage.xaml line 63
                {
                    this.LastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Views\UserInteraction\RegisterPage.xaml line 65
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Views\UserInteraction\RegisterPage.xaml line 73
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Views\UserInteraction\RegisterPage.xaml line 75
                {
                    this.Address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Views\UserInteraction\RegisterPage.xaml line 77
                {
                    this.Introduction = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Views\UserInteraction\RegisterPage.xaml line 85
                {
                    this.Birthday = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 9: // Views\UserInteraction\RegisterPage.xaml line 87
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 10: // Views\UserInteraction\RegisterPage.xaml line 89
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.ButtonBase_OnClick;
                }
                break;
            case 11: // Views\UserInteraction\RegisterPage.xaml line 91
                {
                    this.btnOrLogin = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.btnOrLogin).Click += this.BtnOrLogin_Click;
                }
                break;
            case 12: // Views\UserInteraction\RegisterPage.xaml line 80
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element12 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element12).Checked += this.RadionButton_OnChecked;
                }
                break;
            case 13: // Views\UserInteraction\RegisterPage.xaml line 81
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element13 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element13).Checked += this.RadionButton_OnChecked;
                }
                break;
            case 14: // Views\UserInteraction\RegisterPage.xaml line 82
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element14 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element14).Checked += this.RadionButton_OnChecked;
                }
                break;
            case 15: // Views\UserInteraction\RegisterPage.xaml line 68
                {
                    this.Avatar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 16: // Views\UserInteraction\RegisterPage.xaml line 69
                {
                    this.AvatarUrl = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\UserInteraction\RegisterPage.xaml line 70
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.CapturePhoto;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

