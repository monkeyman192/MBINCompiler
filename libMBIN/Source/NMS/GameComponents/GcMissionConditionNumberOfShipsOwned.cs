using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CB84BF30484F58A, NameHash = 0xF8A18AA2)]
    public class GcMissionConditionNumberOfShipsOwned : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int NumShips;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
