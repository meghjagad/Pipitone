﻿#pragma checksum "..\..\CompanyFounderProfiles.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0894847C7A9E7975AD2CF9B382F175A3BD10334C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Kinect.Wpf.Controls;
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


namespace WpfApplication2 {
    
    
    /// <summary>
    /// CompanyFounderProfiles
    /// </summary>
    public partial class CompanyFounderProfiles : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\CompanyFounderProfiles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Wpf.Controls.KinectRegion kinectRegion;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CompanyFounderProfiles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Technologist;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CompanyFounderProfiles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Idealist;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\CompanyFounderProfiles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RiskTaker;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\CompanyFounderProfiles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rect;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication2;component/companyfounderprofiles.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CompanyFounderProfiles.xaml"
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
            this.kinectRegion = ((Microsoft.Kinect.Wpf.Controls.KinectRegion)(target));
            return;
            case 2:
            this.Technologist = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\CompanyFounderProfiles.xaml"
            this.Technologist.Click += new System.Windows.RoutedEventHandler(this.Technologist_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Idealist = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\CompanyFounderProfiles.xaml"
            this.Idealist.Click += new System.Windows.RoutedEventHandler(this.Idealist_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RiskTaker = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\CompanyFounderProfiles.xaml"
            this.RiskTaker.Click += new System.Windows.RoutedEventHandler(this.RiskTaker_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

