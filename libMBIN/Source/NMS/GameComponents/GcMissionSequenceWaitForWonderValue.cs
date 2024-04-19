using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61693F94A8C79D7C, NameHash = 0xCD3C7F9BB940D9EF)]
    public class GcMissionSequenceWaitForWonderValue : NMSTemplate
    {
        /* 0x000 */ public GcWonderCreatureCategory CreatureWonderType;
        /* 0x004 */ public int Decimals;
        /* 0x008 */ public GcWonderFloraCategory FloraWonderType;
        /* 0x00C */ public GcWonderMineralCategory MineralWonderType;
        /* 0x010 */ public GcWonderPlanetCategory PlanetWonderType;
        /* 0x014 */ public TkEqualityEnum Test;
        /* 0x018 */ public float Value;
        /* 0x01C */ public GcWonderType WonderTypeToUse;
        /* 0x020 */ public NMSString0x80 DebugText;
        /* 0x0A0 */ public NMSString0x80 Message;
        /* 0x120 */ public bool TakeAmountFromSeasonalData;
    }
}
