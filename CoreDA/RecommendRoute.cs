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
    
    public partial class RecommendRoute
    {
        public long RecommendRouteId { get; set; }
        public long RecommendPathId { get; set; }
        public int RecommendPathSeq { get; set; }
        public decimal RecommendLat { get; set; }
        public decimal RecommendLng { get; set; }
        public System.Data.Entity.Spatial.DbGeography RecommendGeo { get; set; }
    }
}
