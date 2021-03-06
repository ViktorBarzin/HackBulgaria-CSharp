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
    
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            this.City = new HashSet<City>();
            this.Ticket = new HashSet<Ticket>();
            this.CityStops = new HashSet<CityStops>();
            this.CityStopsSet = new HashSet<CityStops>();
        }
    
        public int Id { get; set; }
        public string StartCity { get; set; }
        public string EndCity { get; set; }
        public int TravelTime { get; set; }
        public int TrainId { get; set; }
        public int TicketPrice { get; set; }
        public int TicketId { get; set; }
        public int Tain_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> City { get; set; }
        public virtual Train Train { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityStops> CityStops { get; set; }
        public virtual Train TrainSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityStops> CityStopsSet { get; set; }
    }
}
