﻿#pragma checksum "..\..\..\..\UserControls\SongController.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B2F47F50E680BBC292956AC35D14BFD0B0230F91"
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
        
        
        #line 10 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement myMusic;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border myBorder;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSlider;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock volumeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock songNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pauseSongButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playSongButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\UserControls\SongController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button restartSongButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
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
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.myMusic = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 2:
            this.myBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.volumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 28 "..\..\..\..\UserControls\SongController.xaml"
            this.volumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.volumeSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.volumeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.songNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.pauseSongButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\UserControls\SongController.xaml"
            this.pauseSongButton.Click += new System.Windows.RoutedEventHandler(this.pauseSongButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.playSongButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\UserControls\SongController.xaml"
            this.playSongButton.Click += new System.Windows.RoutedEventHandler(this.playSongButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.restartSongButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\UserControls\SongController.xaml"
            this.restartSongButton.Click += new System.Windows.RoutedEventHandler(this.restartSongButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

