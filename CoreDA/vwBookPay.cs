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
    
    public partial class vwBookPay
    {
        public long BookRequestId { get; set; }
        public long TripId { get; set; }
        public Nullable<long> PayReqId { get; set; }
        public string PayReqRefID { get; set; }
        public int PayReqUserId { get; set; }
        public System.DateTime BrCreateTime { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<bool> IsBooked { get; set; }
        public Nullable<long> DuId { get; set; }
        public Nullable<short> BookingType { get; set; }
        public Nullable<double> Credit { get; set; }
        public double PayReqValue { get; set; }
    }
}
