using ASM_UWP_NguyenThao.Entity;
using ASM_UWP_NguyenThao.Service;
//using ASM_UWP_NguyenThao.Util;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ASM_UWP_NguyenThao.Pages
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
                this.Frame.Navigate(typeof(AllMusicPage));

                //// tao bang trong SQLite
                //SQLiteUtil sqLiteUtil = new SQLiteUtil();
                //sqLiteUtil.LoadDatabase();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Email.Text = "";
                this.Password.Password = "";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
