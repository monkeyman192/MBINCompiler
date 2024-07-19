using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD640554FEB2D7B3, NameHash = 0x370CC0E4)]
    public class TkAnimAnimNode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20 DisplayName;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 AnimId;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x40 PhaseIn;
        [NMS(Index = 3)]
        /* 0x70 */ public TkCurveType PhaseCurve;
        [NMS(Index = 4)]
        /* 0x74 */ public float PhaseRangeBegin;
        [NMS(Index = 5)]
        /* 0x78 */ public float PhaseRangeEnd;
        [NMS(Index = 6)]
        /* 0x80 */ public NMSString0x10 SyncGroup;
        // size: 0x3
        public enum SyncGroupRoleEnum : uint {
            CanBeLeader,
            AlwaysLeader,
            NeverLeader,
        }
        [NMS(Index = 7)]
        /* 0x90 */ public SyncGroupRoleEnum SyncGroupRole;
    }
}
