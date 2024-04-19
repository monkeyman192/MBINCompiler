using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C36D5CDE1F2A7AA, NameHash = 0x5CE318610D9BD8D9)]
    public class GcNPCInteractiveObjectStateTransition : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ExcludeTags;
        /* 0x10 */ public NMSString0x10 NewState;
        /* 0x20 */ public NMSString0x10 RequireEvent;
        /* 0x30 */ public NMSString0x10 RequireLocator;
        /* 0x40 */ public float Probability;
        // size: 0x3
        public enum RequireModeEnum : uint {
            Seated,
            Standing,
            None,
        }
        /* 0x44 */ public RequireModeEnum RequireMode;
    }
}
