using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC34477E2A2EDC37, NameHash = 0x75A4AF2BCC689FD2)]
    public class GcMissionConditionBasePartBuilt : NMSTemplate
    {
        /* 0x00 */ public GcBuildingPartSearchType Type;
        /* 0x18 */ public NMSString0x10 PartID;
        /* 0x28 */ public int Count;
        // size: 0x2
        public enum PartInCurrentBaseEnum : uint {
            DontCare,
            YesAllPlayerOwned,
        }
        /* 0x2C */ public PartInCurrentBaseEnum PartInCurrentBase;
        /* 0x30 */ public bool TakeIDFromSeasonData;
    }
}
