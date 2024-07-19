using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66EED515E432B4C9, NameHash = 0x9F9E8E0E)]
    public class GcMissionSequenceWaitForShips : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString MessageLowShield;
        [NMS(Index = 3)]
        /* 0x30 */ public int Count;
        [NMS(Index = 2)]
        /* 0x34 */ public GcRealityCommonFactions Type;
    }
}
