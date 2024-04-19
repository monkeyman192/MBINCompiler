using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FD10D87A7979DA5, NameHash = 0xE4A9F22B5EB5CBF8)]
    public class GcDroneComponentData : NMSTemplate
    {
        /* 0x00 */ public GcCreatureHealthData Health;
        /* 0x68 */ public List<GcDroneGun> Guns;
        /* 0x78 */ public NMSString0x10 Id;
        /* 0x88 */ public List<NMSString0x10> ProjectileChoices;
        /* 0x98 */ public GcPrimaryAxis Axis;
        /* 0x9C */ public float Scaler;
    }
}
