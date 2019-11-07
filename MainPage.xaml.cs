using ASM_UWP_NguyenThao.Entity;
using ASM_UWP_NguyenThao.Pages;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ASM_UWP_NguyenThao
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += CheckAndLoad;
        }
        private void CheckAndLoad(object sender, RoutedEventArgs e)
        {
            if (ProjectConfiguration.CurrentMemberCredential != null)
            {
                this.Frame.Navigate(typeof(Pages.AllMusicPage));
            }
        }

        private void hypRegister_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
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
        
        private void hypLogin_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
            try
            {
                this.Frame.Navigate(typeof(LoginPage));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
