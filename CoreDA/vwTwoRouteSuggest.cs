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
    
    public partial class vwTwoRouteSuggest
    {
        public long SelfRouteRequestId { get; set; }
        public long SuggestRouteRequestId { get; set; }
        public int SelfRRUserId { get; set; }
        public int SuggestRRUserId { get; set; }
        public bool IsSuggestSent { get; set; }
        public bool IsSuggestSeen { get; set; }
        public bool IsSuggestAccepted { get; set; }
        public bool IsSuggestRejected { get; set; }
        public int SAccompanyCount { get; set; }
        public Nullable<System.Guid> SuggestRouteRequestUId { get; set; }
        public Nullable<System.Guid> SelfRouteRequestUId { get; set; }
        public long RouteSuggestId { get; set; }
    }
}
