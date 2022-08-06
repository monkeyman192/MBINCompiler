using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35EECEB5C135BA81, NameHash = 0x10FCB49CBC61F8AA)]
    public class GcWeatherHazardTornadoData : NMSTemplate
    {
        /* 0x00 */ public float SuckInRadius;
        /* 0x04 */ public float SuckInStrength;
        /* 0x08 */ public float SuckUpRadius;
        /* 0x0C */ public float SuckUpStrength;
        /* 0x10 */ public float SuckUpHeight;
        /* 0x14 */ public float SuckUpHeightCutoff;
    }
}
