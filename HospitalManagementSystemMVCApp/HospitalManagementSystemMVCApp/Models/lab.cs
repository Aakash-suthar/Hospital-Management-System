//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagementSystemMVCApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class lab
    {
        public int lab_id { get; set; }
        public Nullable<int> patient_id { get; set; }
        public string test_name { get; set; }
        public int test_cost { get; set; }
    }
}
