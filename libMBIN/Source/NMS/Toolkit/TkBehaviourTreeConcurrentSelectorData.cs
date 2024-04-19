using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x27BAAF4A069EC62C, NameHash = 0x5A80A9FE39381A77)]
    public class TkBehaviourTreeConcurrentSelectorData : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Children;
        /* 0x10 */ public NMSString0x10 Name;
        // size: 0x2
        public enum FailWhenEnum : uint {
            AnyChildFails,
            AllChildrenFail,
        }
        /* 0x20 */ public FailWhenEnum FailWhen;
        // size: 0x2
        public enum SucceedWhenEnum : uint {
            AllChildrenSucceed,
            AnyChildSucceeds,
        }
        /* 0x24 */ public SucceedWhenEnum SucceedWhen;
    }
}
