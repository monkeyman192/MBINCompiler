using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xB1964577B6115829, NameHash = 0x5CE318610D9BD8D9)]
    public class GcNPCInteractiveObjectStateTransition : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string NewState;
        /* 0x10 */ public float Probability;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string RequireEvent;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string RequireLocator;
        public enum RequireModeEnum { Seated, Standing, None }
        /* 0x38 */ public RequireModeEnum RequireMode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3C */ public byte[] Padding3C;
        /* 0x40 */ public List<NMSString0x10> ExcludeTags;
    }
}
