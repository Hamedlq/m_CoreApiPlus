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
    
    public partial class LicenseInfo
    {
        public int UserLicenseId { get; set; }
        public int UserId { get; set; }
        public System.DateTime UserLicenseCreateTime { get; set; }
        public string LicenseNo { get; set; }
        public byte[] LicensePic { get; set; }
        public Nullable<System.Guid> LicenseImageId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
