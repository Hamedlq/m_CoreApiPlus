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
    
    public partial class CarInfo
    {
        public int CarInfoId { get; set; }
        public int UserId { get; set; }
        public System.DateTime CarInfoCreateTime { get; set; }
        public string CarType { get; set; }
        public string CarColor { get; set; }
        public string CarPlateNo { get; set; }
        public bool CarInfoIsDeleted { get; set; }
        public Nullable<System.Guid> CarFrontImageId { get; set; }
        public Nullable<System.Guid> CarBackImageId { get; set; }
    }
}
