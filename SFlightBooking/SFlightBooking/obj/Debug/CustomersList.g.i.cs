﻿#pragma checksum "..\..\CustomersList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E16801429721FD8CC8588A2CF081F6CE"
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
    /// CustomersList
    /// </summary>
    public partial class CustomersList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\CustomersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_customerList;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CustomersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_update;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CustomersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delete;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CustomersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_viewRecord;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CustomersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;
        
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
            System.Uri resourceLocater = new System.Uri("/SFlightBooking;component/customerslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomersList.xaml"
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
            this.lv_customerList = ((System.Windows.Controls.ListView)(target));
            
            #line 12 "..\..\CustomersList.xaml"
            this.lv_customerList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lv_customerList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_update = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\CustomersList.xaml"
            this.btn_update.Click += new System.Windows.RoutedEventHandler(this.btn_update_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_delete = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\CustomersList.xaml"
            this.btn_delete.Click += new System.Windows.RoutedEventHandler(this.btn_delete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_viewRecord = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\CustomersList.xaml"
            this.btn_viewRecord.Click += new System.Windows.RoutedEventHandler(this.btn_viewRecord_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_close = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\CustomersList.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.btn_close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

