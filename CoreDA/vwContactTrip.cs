//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwContactTrip
    {
        public long RouteRequestId { get; set; }
        public Nullable<int> UserId { get; set; }
        public long ContactId { get; set; }
        public bool IsDrive { get; set; }
        public Nullable<long> TripId { get; set; }
        public Nullable<bool> IsPassengerAccepted { get; set; }
        public Nullable<bool> ContactIsRideAccepted { get; set; }
        public int ContactPassengerUserId { get; set; }
        public int ContactDriverUserId { get; set; }
    }
}
