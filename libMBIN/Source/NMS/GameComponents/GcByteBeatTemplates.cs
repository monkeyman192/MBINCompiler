using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34F44B119AE0F661, NameHash = 0xBBB68492659143C4)]
    public class GcByteBeatTemplates : NMSTemplate
    {
        /* 0x00 */ public List<GcByteBeatDrum> HiHats;
        /* 0x10 */ public List<NMSString0x40> InitialTrees;
        /* 0x20 */ public List<GcByteBeatDrum> KickDrums;
        /* 0x30 */ public List<GcByteBeatDrum> SnareDrums;
        /* 0x40 */ public List<GcByteBeatSong> Songs;
        /* 0x50 */ public List<GcByteBeatTemplate> Templates;
        [NMS(Size = 0x12, EnumType = typeof(GcByteBeatToken.ByteBeatTokenEnum))]
        /* 0x60 */ public float[] CombinerWeights;
        /* 0xA8 */ public float OperatorPermuteChance;
        /* 0xAC */ public float TemplateCombineChance;
        /* 0xB0 */ public float TemplateCombineChanceAtRoot;
    }
}
