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
    
    public partial class vwDriverRoute
    {
        public long DrSrcStationId { get; set; }
        public string CarColor { get; set; }
        public string CarPlateNo { get; set; }
        public string CarType { get; set; }
        public string SrcStAdd { get; set; }
        public decimal SrcStLat { get; set; }
        public decimal SrcStlng { get; set; }
        public string SrcMainStName { get; set; }
        public long DriverRouteId { get; set; }
        public long UserId { get; set; }
        public string DstMainStName { get; set; }
        public decimal DstMainStLat { get; set; }
        public decimal DstMainStLng { get; set; }
        public Nullable<long> DriverPrice { get; set; }
        public Nullable<long> PassPrice { get; set; }
    }
}
