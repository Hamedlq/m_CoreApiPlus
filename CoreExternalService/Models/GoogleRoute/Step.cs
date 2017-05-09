﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreExternalService.Models
{
   public  class Step
    {
       public Point Start_location { set; get; }
       public Point End_location { set; get; }
       public Pair Duration { set; get; }
       public Pair Distance { set; get; }
       public String Html_instructions { set; get; }
       public PolyLinePoint Polyline { set; get; }
    }
}
