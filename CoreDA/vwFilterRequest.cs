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
    
    public partial class vwFilterRequest
    {
        public long FilterRequestId { get; set; }
        public long FilterId { get; set; }
        public System.DateTime RCreateTime { get; set; }
        public System.DateTime RStartTime { get; set; }
        public Nullable<long> TripId { get; set; }
        public bool IsActive { get; set; }
        public short RState { get; set; }
        public long FilterUserId { get; set; }
        public long SrcMStationId { get; set; }
        public long DstMStationId { get; set; }
        public long StationRouteId { get; set; }
        public bool IsDelete { get; set; }
        public string SrcStName { get; set; }
        public decimal SrcStLat { get; set; }
        public decimal SrcStLng { get; set; }
        public string DstStName { get; set; }
        public decimal DstStLat { get; set; }
        public decimal DstStLng { get; set; }
        public bool IsCarpool { get; set; }
    }
}
