using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7CBA50640B2300, NameHash = 0x576E62E8)]
    public class GcMissionConditionBasePartBuilt : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcBuildingPartSearchType Type;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x10 PartID;
        [NMS(Index = 2)]
        /* 0x28 */ public int Count;
        // size: 0x2
        public enum PartInCurrentBaseEnum : uint {
            DontCare,
            YesAllPlayerOwned,
        }
        [NMS(Index = 4)]
        /* 0x2C */ public PartInCurrentBaseEnum PartInCurrentBase;
        [NMS(Index = 1)]
        /* 0x30 */ public bool TakeIDFromSeasonData;
    }
}
