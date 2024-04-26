using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61693F94A8C79D7C, NameHash = 0xCD3C7F9BB940D9EF)]
    public class GcMissionSequenceWaitForWonderValue : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcWonderCreatureCategory CreatureWonderType;
        [NMS(Index = 7)]
        /* 0x004 */ public int Decimals;
        [NMS(Index = 4)]
        /* 0x008 */ public GcWonderFloraCategory FloraWonderType;
        [NMS(Index = 5)]
        /* 0x00C */ public GcWonderMineralCategory MineralWonderType;
        [NMS(Index = 2)]
        /* 0x010 */ public GcWonderPlanetCategory PlanetWonderType;
        [NMS(Index = 9)]
        /* 0x014 */ public TkEqualityEnum Test;
        [NMS(Index = 6)]
        /* 0x018 */ public float Value;
        [NMS(Index = 1)]
        /* 0x01C */ public GcWonderType WonderTypeToUse;
        [NMS(Index = 10)]
        /* 0x020 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0A0 */ public NMSString0x80 Message;
        [NMS(Index = 8)]
        /* 0x120 */ public bool TakeAmountFromSeasonalData;
    }
}
