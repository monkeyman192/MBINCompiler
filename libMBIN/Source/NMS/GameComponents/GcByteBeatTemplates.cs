using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EA98CC7A0D0E400, NameHash = 0x24D3BF50)]
    public class GcByteBeatTemplates : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<GcByteBeatDrum> HiHats;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x40> InitialTrees;
        [NMS(Index = 3)]
        /* 0x20 */ public List<GcByteBeatDrum> KickDrums;
        [NMS(Index = 4)]
        /* 0x30 */ public List<GcByteBeatDrum> SnareDrums;
        [NMS(Index = 9)]
        /* 0x40 */ public List<GcByteBeatSong> Songs;
        [NMS(Index = 1)]
        /* 0x50 */ public List<GcByteBeatTemplate> Templates;
        [NMS(Index = 2, Size = 0x12, EnumType = typeof(GcByteBeatToken.ByteBeatTokenEnum))]
        /* 0x60 */ public float[] CombinerWeights;
        [NMS(Index = 6)]
        /* 0xA8 */ public float OperatorPermuteChance;
        [NMS(Index = 8)]
        /* 0xAC */ public float TemplateCombineChance;
        [NMS(Index = 7)]
        /* 0xB0 */ public float TemplateCombineChanceAtRoot;
    }
}
