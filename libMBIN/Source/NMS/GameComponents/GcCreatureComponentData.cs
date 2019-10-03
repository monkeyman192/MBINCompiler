using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x5184B44469E17BE1, NameHash = 0x28E8DAB19EC55198)]
    public class GcCreatureComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public GcPrimaryAxis Axis;
        /* 0x14 */ public float Scaler;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string DeathEffect;
        /* 0x28 */ public List<GcReplacementEffectData> ReplacementImpacts;
        /* 0x38 */ public float DiscoveryUIScaler;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3C */ public byte[] Padding3C;
        /* 0x40 */ public Vector3f DiscoveryUIOffset;
    }
}
