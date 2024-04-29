using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7A775C0A924D5AD3, NameHash = 0xE09F11724D654285)]
    public class TkLSystemRule : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<TkLSystemInnerRule> Rules;
        // size: 0x2
        public enum RuleTypeEnum : uint {
            Default,
            BaseRule,
        }
        [NMS(Index = 3)]
        /* 0x10 */ public RuleTypeEnum RuleType;
        [NMS(Index = 1)]
        /* 0x14 */ public NMSString0x80 Model;
        [NMS(Index = 0)]
        /* 0x94 */ public NMSString0x20 Name;
    }
}
