using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5C1A259C0CEB5E2C, NameHash = 0xE4A9F22B5EB5CBF8)]
    public class GcDroneComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcPrimaryAxis Axis;
        /* 0x14 */ public float Scaler;
        /* 0x18 */ public GcCreatureHealthData Health;
        /* 0x80 */ public List<NMSString0x10> ProjectileChoices;
        /* 0x90 */ public List<GcDroneGun> Guns;
    }
}
