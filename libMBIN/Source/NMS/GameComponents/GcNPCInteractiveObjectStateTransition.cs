using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB1964577B6115829, NameHash = 0x5CE318610D9BD8D9)]
    public class GcNPCInteractiveObjectStateTransition : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NewState;
        /* 0x10 */ public float Probability;
        /* 0x18 */ public NMSString0x10 RequireEvent;
        /* 0x28 */ public NMSString0x10 RequireLocator;
        public enum RequireModeEnum { Seated, Standing, None }
        /* 0x38 */ public RequireModeEnum RequireMode;
        /* 0x40 */ public List<NMSString0x10> ExcludeTags;
    }
}
