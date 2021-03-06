﻿#pragma checksum "..\..\GenerateBill.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "429884D57B1C312BBCFE4BA428D71716"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HospitalManagementSystemWPF;
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


namespace HospitalManagementSystemWPF {
    
    
    /// <summary>
    /// GenerateBill
    /// </summary>
    public partial class GenerateBill : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\GenerateBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchid;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\GenerateBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bill_id_show;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\GenerateBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox patient_id_show;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\GenerateBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox doctor_assigned;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\GenerateBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox room_charge;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\GenerateBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lab_charge;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\GenerateBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox days_admitted;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\GenerateBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox total_cost;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\GenerateBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox patient_name;
        
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
            System.Uri resourceLocater = new System.Uri("/HospitalManagementSystemWPF;component/generatebill.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GenerateBill.xaml"
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
            this.searchid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 30 "..\..\GenerateBill.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateBillData);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 37 "..\..\GenerateBill.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GotoDashboard);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bill_id_show = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.patient_id_show = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.doctor_assigned = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.room_charge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.lab_charge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.days_admitted = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.total_cost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.patient_name = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

