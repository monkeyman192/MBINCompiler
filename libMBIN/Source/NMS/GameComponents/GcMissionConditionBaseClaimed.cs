using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66ABFBB0092864D2, NameHash = 0xD0B8CB5F60C6775)]
    public class GcMissionConditionBaseClaimed : NMSTemplate
    {
        /* 0x0 */ public GcPersistentBaseTypes Base;
        // size: 0x3
        public enum IsOnCurrentSystemEnum : uint {
            DontCare,
            Yes,
            No,
        }
        /* 0x4 */ public IsOnCurrentSystemEnum IsOnCurrentSystem;
        /* 0x8 */ public int MinParts;
        /* 0xC */ public bool Claimed;
        /* 0xD */ public bool MustBeInBase;
    }
}
