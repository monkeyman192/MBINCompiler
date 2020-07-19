using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x128, GUID = 0x337A1C3341B718EE, NameHash = 0x2862D9C79079A037)]
    public class GcCreatureHoverMovementDataParams : NMSTemplate
    {
        /* 0x000 */ public List<NMSString0x20> ValidDescriptors;
        [NMS(Size = 0x100)]
        /* 0x010 */ public string GroundEffect;
        /* 0x110 */ public float GroundEffectHeightForMaxAlpha;
        /* 0x114 */ public float GroundEffectHeightForMinAlpha;
        /* 0x118 */ public bool GroundAlign;
        /* 0x11C */ public float HeightForMaxGroundAlign;
        /* 0x120 */ public float HeightForMinGroundAlign;
        /* 0x124 */ public float GroundAlignTimeModifier;
    }
}