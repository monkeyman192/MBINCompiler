using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A017C47CF69898E, NameHash = 0x5CA711BA)]
    public class GcMissionSequenceWaitForWonderValue : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x20 */ public GcWonderCreatureCategory CreatureWonderType;
        [NMS(Index = 7)]
        /* 0x24 */ public int Decimals;
        [NMS(Index = 4)]
        /* 0x28 */ public GcWonderFloraCategory FloraWonderType;
        [NMS(Index = 5)]
        /* 0x2C */ public GcWonderMineralCategory MineralWonderType;
        [NMS(Index = 2)]
        /* 0x30 */ public GcWonderPlanetCategory PlanetWonderType;
        [NMS(Index = 9)]
        /* 0x34 */ public TkEqualityEnum Test;
        [NMS(Index = 6)]
        /* 0x38 */ public float Value;
        [NMS(Index = 1)]
        /* 0x3C */ public GcWonderType WonderTypeToUse;
        [NMS(Index = 8)]
        /* 0x40 */ public bool TakeAmountFromSeasonalData;
    }
}
