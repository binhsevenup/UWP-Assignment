using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace XP_Assignment.Views.UserInteraction
{
    public sealed partial class MemberInfoPage : Page
    {
        private IMemberService _memberService;
        private IFileService _fileService;
        private StorageFile photo;

        public MemberInfoPage()
        {
            this.InitializeComponent();
            this._memberService = new MemberService();
            this._fileService = new LocalFileService();
            this.Loaded += LoadUserInformation;
        }

        private async void LoadUserInformation(object sender, RoutedEventArgs e)
        {
            var memberCredential = await this._fileService.ReadMemberCredentialFromFile();
            if (memberCredential == null)
            {
                this.Frame.Navigate(typeof(LoginPage));
            }

            if (memberCredential != null)
            {
                var member = this._memberService.GetInformation(memberCredential.token);
                FirstName.Text = member.firstName;
                LastName.Text = member.lastName;
                Email.Text = member.email;
                Phone.Text = member.phone;
                Address.Text = member.address;
                Introduction.Text = member.introduction;
                Gender.Text = member.gender == 1 ? "Male" : (member.gender == 0 ? "Female" : "Other");
                Birthday.Text = member.birthday;
            }
        }

       
    }
}
