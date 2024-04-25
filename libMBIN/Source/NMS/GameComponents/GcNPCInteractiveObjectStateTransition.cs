using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C36D5CDE1F2A7AA, NameHash = 0x5CE318610D9BD8D9)]
    public class GcNPCInteractiveObjectStateTransition : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<NMSString0x10> ExcludeTags;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 NewState;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 RequireEvent;
        [NMS(Index = 3)]
        /* 0x30 */ public NMSString0x10 RequireLocator;
        [NMS(Index = 1)]
        /* 0x40 */ public float Probability;
        // size: 0x3
        public enum RequireModeEnum : uint {
            Seated,
            Standing,
            None,
        }
        [NMS(Index = 4)]
        /* 0x44 */ public RequireModeEnum RequireMode;
    }
}
