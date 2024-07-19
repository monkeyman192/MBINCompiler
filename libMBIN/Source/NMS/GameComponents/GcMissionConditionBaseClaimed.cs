using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x451D17CA7C610FFF, NameHash = 0x1CEB9CB)]
    public class GcMissionConditionBaseClaimed : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcPersistentBaseTypes Base;
        // size: 0x3
        public enum IsOnCurrentSystemEnum : uint {
            DontCare,
            Yes,
            No,
        }
        [NMS(Index = 2)]
        /* 0x4 */ public IsOnCurrentSystemEnum IsOnCurrentSystem;
        [NMS(Index = 4)]
        /* 0x8 */ public int MinParts;
        [NMS(Index = 0)]
        /* 0xC */ public bool Claimed;
        [NMS(Index = 3)]
        /* 0xD */ public bool MustBeInBase;
    }
}
