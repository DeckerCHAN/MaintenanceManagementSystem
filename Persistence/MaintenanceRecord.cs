//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MMS.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaintenanceRecord
    {
        public System.Guid MaintenanceRecordId { get; set; }
        public System.Guid MaintenanceManId { get; set; }
        public System.Guid ClientId { get; set; }
        public System.Guid DeviceId { get; set; }
        public System.DateTime MaintenanceTime { get; set; }
    }
}