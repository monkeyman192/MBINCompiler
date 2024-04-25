using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF25C35AE0519CFB, NameHash = 0x88DEFBD52206A298)]
    public class GcMissionSequenceWaitForShips : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public int Count;
        [NMS(Index = 2)]
        /* 0x004 */ public GcRealityCommonFactions Type;
        [NMS(Index = 4)]
        /* 0x008 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x088 */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x108 */ public NMSString0x80 MessageLowShield;
    }
}
