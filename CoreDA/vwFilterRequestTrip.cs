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
    
    public partial class vwFilterRequestTrip
    {
        public bool IsActive { get; set; }
        public bool IsCarpool { get; set; }
        public long TripId { get; set; }
        public long DriverRouteId { get; set; }
        public System.DateTime TStartTime { get; set; }
        public System.DateTime TCreateTime { get; set; }
        public short TEmptySeat { get; set; }
        public short TState { get; set; }
        public short RState { get; set; }
        public System.DateTime RStartTime { get; set; }
        public System.DateTime RCreateTime { get; set; }
        public long FilterId { get; set; }
        public long FilterRequestId { get; set; }
        public long FilterUserId { get; set; }
        public long SrcMStationId { get; set; }
        public long DstMStationId { get; set; }
        public long StationRouteId { get; set; }
        public bool IsDelete { get; set; }
    }
}
