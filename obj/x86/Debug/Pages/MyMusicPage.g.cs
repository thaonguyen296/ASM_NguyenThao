﻿#pragma checksum "C:\Users\LENOVO\source\repos\ASM_UWP_NguyenThao\ASM_UWP_NguyenThao\Pages\MyMusicPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E5B47249EEEDDFDDED968EBF9C8DD8E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASM_UWP_NguyenThao.Pages
{
    partial class MyMusicPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\MyMusicPage.xaml line 61
                {
                    this.MyMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // Pages\MyMusicPage.xaml line 44
                {
                    this.btnSignOut = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnSignOut).Click += this.BtnSignOut_Click;
                }
                break;
            case 4: // Pages\MyMusicPage.xaml line 46
                {
                    this.btnCreateMusic = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnCreateMusic).Click += this.BtnCreateMusic_Click;
                }
                break;
            case 5: // Pages\MyMusicPage.xaml line 48
                {
                    this.Previous = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Previous).Click += this.Previous_Click;
                }
                break;
            case 6: // Pages\MyMusicPage.xaml line 49
                {
                    this.PlayAndPause = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PlayAndPause).Click += this.PlayAndPause_Click;
                }
                break;
            case 7: // Pages\MyMusicPage.xaml line 50
                {
                    this.Next = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Next).Click += this.Next_Click;
                }
                break;
            case 8: // Pages\MyMusicPage.xaml line 58
                {
                    this.txtNowPlaying = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Pages\MyMusicPage.xaml line 14
                {
                    this.ListViewSong = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 11: // Pages\MyMusicPage.xaml line 24
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element11 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element11).DoubleTapped += this.UIElement_OnDoubleTapped;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

