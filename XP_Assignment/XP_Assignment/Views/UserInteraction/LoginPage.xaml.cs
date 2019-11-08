using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XP_Assignment.Entities;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace XP_Assignment.Views.UserInteraction
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        private IMemberService _memberService;
        private IFileService _fileService;

        public LoginPage()
        {
            Debug.WriteLine("Init Login");
            this.InitializeComponent();
            this._memberService = new MemberService();
            this._fileService = new LocalFileService();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var memberLogin = new MemberLogin
                {
                    email = this.Email.Text,
                    password = this.Password.Password
                };

                var memberCredential = this._memberService.Login(memberLogin);
                ProjectConfiguration.CurrentMemberCredential = memberCredential;
                this._fileService.SaveMemberCredentialToFile(memberCredential);
                this.Frame.Navigate(typeof(Views.SongInteraction.AllSongPage));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnOrRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Frame.Navigate(typeof(RegisterPage));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
