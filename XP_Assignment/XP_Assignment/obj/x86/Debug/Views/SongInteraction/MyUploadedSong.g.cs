﻿#pragma checksum "C:\Users\Windows 10 Gamer\source\repos\XP_Assignment\XP_Assignment\Views\SongInteraction\MyUploadedSong.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F09A8AB7B60862162AE97DDB95EB531E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XP_Assignment.Views.SongInteraction
{
    partial class MyUploadedSong : 
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
            case 2: // Views\SongInteraction\MyUploadedSong.xaml line 47
                {
                    this.MyMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // Views\SongInteraction\MyUploadedSong.xaml line 36
                {
                    this.btnSignOut = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnSignOut).Click += this.BtnSignOut_Click;
                }
                break;
            case 4: // Views\SongInteraction\MyUploadedSong.xaml line 38
                {
                    this.btnCreateMusic = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnCreateMusic).Click += this.BtnCreateMusic_Click;
                }
                break;
            case 5: // Views\SongInteraction\MyUploadedSong.xaml line 40
                {
                    this.Previous = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Previous).Click += this.Previous_Click;
                }
                break;
            case 6: // Views\SongInteraction\MyUploadedSong.xaml line 41
                {
                    this.PlayAndPause = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PlayAndPause).Click += this.PlayAndPause_Click;
                }
                break;
            case 7: // Views\SongInteraction\MyUploadedSong.xaml line 42
                {
                    this.Next = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Next).Click += this.Next_Click;
                }
                break;
            case 8: // Views\SongInteraction\MyUploadedSong.xaml line 44
                {
                    this.txtNowPlaying = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Views\SongInteraction\MyUploadedSong.xaml line 19
                {
                    this.ListViewSong = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 11: // Views\SongInteraction\MyUploadedSong.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element11 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element11).DoubleTapped += this.SpSong_DoubleTapped;
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

