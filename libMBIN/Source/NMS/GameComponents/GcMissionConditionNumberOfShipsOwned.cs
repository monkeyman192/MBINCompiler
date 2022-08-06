using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x205C7D76D67412C2, NameHash = 0xF3DE406AE480E3E0)]
    public class GcMissionConditionNumberOfShipsOwned : NMSTemplate
    {
        public int NumShips;
        public TkEqualityEnum Test;
    }
}
