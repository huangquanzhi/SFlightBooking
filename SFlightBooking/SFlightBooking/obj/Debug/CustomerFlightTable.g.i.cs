﻿#pragma checksum "..\..\CustomerFlightTable.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C0DD8973229F8628F707254B7106B77A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SFlightBooking;
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


namespace SFlightBooking {
    
    
    /// <summary>
    /// CustomerFlightTable
    /// </summary>
    public partial class CustomerFlightTable : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CustomerFlightTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_customerFlight;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CustomerFlightTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_removeFlight;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CustomerFlightTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CustomerFlightTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_viewFlight;
        
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
            System.Uri resourceLocater = new System.Uri("/SFlightBooking;component/customerflighttable.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomerFlightTable.xaml"
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
            this.lv_customerFlight = ((System.Windows.Controls.ListView)(target));
            
            #line 10 "..\..\CustomerFlightTable.xaml"
            this.lv_customerFlight.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lv_customerFlight_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_removeFlight = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\CustomerFlightTable.xaml"
            this.btn_removeFlight.Click += new System.Windows.RoutedEventHandler(this.btn_removeFlight_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_close = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\CustomerFlightTable.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.btn_close_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_viewFlight = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\CustomerFlightTable.xaml"
            this.btn_viewFlight.Click += new System.Windows.RoutedEventHandler(this.btn_viewFlight_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

