﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreManager.Models.TrafficAddress;

namespace CoreManager.Models
{
    public class PassRouteModel
    {
        public long TripId { set; get; }
        public string Name { set; get; }
        public string Family { set; get; }
        public Guid? UserImageId { set; get; }
        public string  TimingString{ set; get; }
        public string  PricingString{ set; get; }
        public string  CarString{ set; get; }
        public string SrcAddress { set; get; }
        public string SrcDistance { set; get; }
        public string SrcLatitude { set; get; }
        public string SrcLongitude { set; get; }
        public string DstAddress { set; get; }
        public string DstDistance { set; get; }
        public string DstLatitude { set; get; }
        public string DstLongitude { set; get; }
        public int EmptySeats { set; get; }
        public int CarSeats { set; get; }
        public bool IsVerified { set; get; }
        public bool IsBooked { set; get; }

    }
}