using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2930EA627BCB5046, NameHash = 0x5A80A9FE39381A77)]
    public class TkBehaviourTreeConcurrentSelectorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        public enum SucceedWhenEnum { AllChildrenSucceed, AnyChildSucceeds }
        /* 0x10 */ public SucceedWhenEnum SucceedWhen;
        public enum FailWhenEnum { AnyChildFails, AllChildrenFail }
        /* 0x10 */ public FailWhenEnum FailWhen;
        /* 0x18 */ public List<NMSTemplate> Children;
    }
}
