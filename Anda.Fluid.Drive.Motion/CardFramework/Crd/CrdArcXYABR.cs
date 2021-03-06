﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anda.Fluid.Drive.Motion.CardFramework.Crd
{
    public class CrdArcXYABR : ICrdable
    {
        public double EndPosX { get; set; }
        public double EndPosY { get; set; }
        public double EndPosA { get; set; }
        public double EndPosB { get; set; }
        public double R { get; set; }
        public short Clockwise { get; set; }
        public double Vel { get; set; }
        public double Acc { get; set; }
        public double VelEnd { get; set; }

        public CrdType Type { get { return CrdType.ArcXYABR; } }
    }
}
