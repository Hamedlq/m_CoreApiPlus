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
    
    public partial class StationRoute
    {
        public long StationRouteId { get; set; }
        public long SrcMStationId { get; set; }
        public long DstMStationId { get; set; }
        public Nullable<long> DriverPrice { get; set; }
        public Nullable<long> PassPrice { get; set; }
        public Nullable<long> Duration { get; set; }
        public Nullable<long> DistanceMin { get; set; }
        public Nullable<long> DurationMin { get; set; }
        public Nullable<long> DistanceMid { get; set; }
        public Nullable<long> DurationMid { get; set; }
        public Nullable<long> DistanceMax { get; set; }
        public Nullable<long> DurationMax { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<short> RouteType { get; set; }
    }
}
