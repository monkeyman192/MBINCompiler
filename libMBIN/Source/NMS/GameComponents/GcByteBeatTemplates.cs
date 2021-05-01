using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xA8, GUID = 0xBC8B1A3D2F8ADF9F, NameHash = 0xBBB68492659143C4)]
    public class GcByteBeatTemplates : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x40> InitialTrees;
        /* 0x10 */ public List<GcByteBeatTemplate> Templates;
        [NMS(Size = 0x12, EnumType = typeof(GcByteBeatToken.ByteBeatTokenEnum))]
        /* 0x20 */ public float[] CombinerWeights;
        /* 0x68 */ public List<GcByteBeatDrum> KickDrums;
        /* 0x78 */ public List<GcByteBeatDrum> SnareDrums;
        /* 0x88 */ public List<GcByteBeatDrum> HiHats;
        /* 0x98 */ public float OperatorPermuteChance;
        /* 0x9C */ public float TemplateCombineChanceAtRoot;
        /* 0xA0 */ public float TemplateCombineChance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xA4 */ public byte[] EndPadding;
    }
}
