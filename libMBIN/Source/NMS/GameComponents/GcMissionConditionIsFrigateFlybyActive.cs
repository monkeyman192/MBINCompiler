using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9722ABC485B9624, NameHash = 0xCE9968E4A5D8329B)]
    public class GcMissionConditionIsFrigateFlybyActive : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcFrigateFlybyType FrigateFlybyType;
    }
}
