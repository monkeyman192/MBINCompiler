using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x83F8EF11C161AA7C, NameHash = 0x4F8B68FB20F9A030)]
    public class TkLSystemInnerRule : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<TkLSystemLocatorEntry> Entries;
        // size: 0x3
        public enum MergeProbabilityOptionsEnum : uint {
            Balance,
            Prioritize,
            Replace,
        }
        [NMS(Index = 1)]
        /* 0x10 */ public MergeProbabilityOptionsEnum MergeProbabilityOptions;
        [NMS(Index = 0)]
        /* 0x14 */ public NMSString0x20 LocatorType;
    }
}
