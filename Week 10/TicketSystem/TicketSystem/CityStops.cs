//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class CityStops
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int ScheduleId { get; set; }
    
        public virtual Schedule Schedule { get; set; }
        public virtual Schedule ScheduleSet { get; set; }
    }
}