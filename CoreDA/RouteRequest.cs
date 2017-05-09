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
    
    public partial class RouteRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RouteRequest()
        {
            this.RRTimings = new HashSet<RRTiming>();
        }
    
        public long RouteRequestId { get; set; }
        public int RouteRequestType { get; set; }
        public int RouteRequestUserId { get; set; }
        public short RRIsConfirmed { get; set; }
        public bool RRIsDeleted { get; set; }
        public System.DateTime RequestCreateTime { get; set; }
        public System.DateTime RequestLastModifyTime { get; set; }
        public string SrcGAddress { get; set; }
        public string SrcDetailAddress { get; set; }
        public decimal SrcLatitude { get; set; }
        public decimal SrcLongitude { get; set; }
        public System.Data.Entity.Spatial.DbGeography SrcGeo { get; set; }
        public string DstGAddress { get; set; }
        public string DstDetailAddress { get; set; }
        public decimal DstLatitude { get; set; }
        public decimal DstLongitude { get; set; }
        public System.Data.Entity.Spatial.DbGeography DstGeo { get; set; }
        public int AccompanyCount { get; set; }
        public bool IsDrive { get; set; }
        public int CarInfoId { get; set; }
        public string ConfirmatedText { get; set; }
        public Nullable<double> SrcDstDistance { get; set; }
        public Nullable<long> RecommendPathId { get; set; }
        public Nullable<short> RouteRequestState { get; set; }
        public Nullable<System.Guid> RouteRequestUId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RRTiming> RRTimings { get; set; }
    }
}