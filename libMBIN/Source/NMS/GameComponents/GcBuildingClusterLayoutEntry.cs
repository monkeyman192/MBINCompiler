using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65B33E7FC1ABF073, NameHash = 0x3C79A95C7D8D0B89)]
    public class GcBuildingClusterLayoutEntry : NMSTemplate
    {
        /* 0x00 */ public GcBuildingClassification Building;
        /* 0x04 */ public float Probability;
        /* 0x08 */ public int Min;
        /* 0x0C */ public int Max;
        /* 0x10 */ public bool FacesCentre;
    }
}
