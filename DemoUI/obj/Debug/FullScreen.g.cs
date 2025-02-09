﻿#pragma checksum "..\..\FullScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D554DB739FB94FA98515A1457151CAE8E8E9816626DE3F74206C447DAA3BADE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DemoUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace DemoUI {
    
    
    /// <summary>
    /// FullScreen
    /// </summary>
    public partial class FullScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\FullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button preButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\FullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\FullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\FullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\FullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock currentPosition;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\FullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider progressSlider;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\FullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalPosition;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DemoUI;component/fullscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FullScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.preButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\FullScreen.xaml"
            this.preButton.Click += new System.Windows.RoutedEventHandler(this.nextButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.playButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\FullScreen.xaml"
            this.playButton.Click += new System.Windows.RoutedEventHandler(this.playButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.stopButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\FullScreen.xaml"
            this.stopButton.Click += new System.Windows.RoutedEventHandler(this.stopButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.nextButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\FullScreen.xaml"
            this.nextButton.Click += new System.Windows.RoutedEventHandler(this.nextButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.currentPosition = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.progressSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 47 "..\..\FullScreen.xaml"
            this.progressSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.progressSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.totalPosition = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

