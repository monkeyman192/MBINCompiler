using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC981D9D1A311269E, NameHash = 0x2BA616233E287BB2)]
    public class GcVehicleMuzzleData : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x0 */ public NMSString0x10[] MuzzleFlashDataID;
    }
}
