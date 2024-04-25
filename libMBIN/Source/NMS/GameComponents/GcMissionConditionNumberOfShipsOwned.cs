using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5196601822D514A3, NameHash = 0xF3DE406AE480E3E0)]
    public class GcMissionConditionNumberOfShipsOwned : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int NumShips;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
