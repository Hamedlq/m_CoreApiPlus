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
    
    public partial class Filter
    {
        public long FilterId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public long FilterUserId { get; set; }
        public long SrcMStationId { get; set; }
        public long DstMStationId { get; set; }
        public long StationRouteId { get; set; }
        public bool IsDelete { get; set; }
    }
}
