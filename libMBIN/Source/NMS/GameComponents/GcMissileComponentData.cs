using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3084C666AE66E619, NameHash = 0x342DA8D8BE5A9CE3)]
    public class GcMissileComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Explosion;
        /* 0x10 */ public float NoTargetLife;
        /* 0x18 */ public NMSString0x10 Trail;
    }
}
