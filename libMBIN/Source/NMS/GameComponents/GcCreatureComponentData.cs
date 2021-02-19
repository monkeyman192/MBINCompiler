using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x50, Alignment = 0x10, GUID = 0xCF20BAC0F40D296B, NameHash = 0x28E8DAB19EC55198)]
    public class GcCreatureComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public GcPrimaryAxis Axis;
        /* 0x14 */ public float Scaler;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string DeathEffect;
        /* 0x28 */ public List<GcReplacementEffectData> ReplacementImpacts;
        /* 0x38 */ public float AccessoryPitchOffset;
        /* 0x3C */ public float DiscoveryUIScaler;
        /* 0x40 */ public Vector3f DiscoveryUIOffset;
    }
}
