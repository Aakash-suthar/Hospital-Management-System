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
    
    public partial class room
    {
        public int room_id { get; set; }
        public string room_name { get; set; }
        public Nullable<int> patient_id { get; set; }
        public Nullable<int> room_charge { get; set; }
    }
}