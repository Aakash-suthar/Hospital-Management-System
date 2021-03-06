#pragma checksum "..\..\SearchPatientInfo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6D3BEF5052BEF610495A8FC71E97034B"
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


namespace HospitalManagementSystemWPF
{


    /// <summary>
    /// SearchPatientInfo
    /// </summary>
    public partial class SearchPatientInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 25 "..\..\SearchPatientInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox patient_id_combobox;

#line default
#line hidden


#line 48 "..\..\SearchPatientInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox patient_id_textbox;

#line default
#line hidden


#line 50 "..\..\SearchPatientInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox admit_date_textbox;

#line default
#line hidden


#line 52 "..\..\SearchPatientInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox doctor_assigned_textbox;

#line default
#line hidden


#line 54 "..\..\SearchPatientInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox disease_textbox;

#line default
#line hidden


#line 56 "..\..\SearchPatientInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox room_assigned_textbox;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HospitalManagementSystemWPF;component/searchpatientinfo.xaml", System.UriKind.Relative);

#line 1 "..\..\SearchPatientInfo.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.patient_id_combobox = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 2:
                    this.patientid = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:

#line 34 "..\..\SearchPatientInfo.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GetPatientInfo);

#line default
#line hidden
                    return;
                case 4:

#line 41 "..\..\SearchPatientInfo.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GotoDashboard);

#line default
#line hidden
                    return;
                case 5:
                    this.patient_id_textbox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.admit_date_textbox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.doctor_assigned_textbox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.disease_textbox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 9:
                    this.room_assigned_textbox = ((System.Windows.Controls.TextBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

