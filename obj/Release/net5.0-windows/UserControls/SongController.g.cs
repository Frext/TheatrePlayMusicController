#pragma checksum "..\..\..\..\UserControls\SongController.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07F0E98765AADDB836C4CA3D23689CEABB1D1397"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TheatrePlayMusicController.UserControls;


namespace TheatrePlayMusicController.UserControls {
    
    
    /// <summary>
    /// SongController
    /// </summary>
    public partial class SongController : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement meSongPlayer;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border myBorder;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sldVolumeValue;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbVolumeValue;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbSongName;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTimePassed;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPauseSong;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStartSong;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnResetSong;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TheatrePlayMusicController;component/usercontrols/songcontroller.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\SongController.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.meSongPlayer = ((System.Windows.Controls.MediaElement)(target));
            
            #line 33 "..\..\..\..\UserControls\SongController.xaml"
            this.meSongPlayer.MediaEnded += new System.Windows.RoutedEventHandler(this.meSongPlayer_MediaEnded);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\UserControls\SongController.xaml"
            this.meSongPlayer.MediaFailed += new System.EventHandler<System.Windows.ExceptionRoutedEventArgs>(this.meSongPlayer_MediaFailed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.sldVolumeValue = ((System.Windows.Controls.Slider)(target));
            
            #line 52 "..\..\..\..\UserControls\SongController.xaml"
            this.sldVolumeValue.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sldVolumeValue_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbVolumeValue = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tbSongName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tbTimePassed = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btnPauseSong = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\UserControls\SongController.xaml"
            this.btnPauseSong.Click += new System.Windows.RoutedEventHandler(this.btnPauseSong_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnStartSong = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\UserControls\SongController.xaml"
            this.btnStartSong.Click += new System.Windows.RoutedEventHandler(this.btnStartSong_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnResetSong = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\UserControls\SongController.xaml"
            this.btnResetSong.Click += new System.Windows.RoutedEventHandler(this.btnResetSong_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

