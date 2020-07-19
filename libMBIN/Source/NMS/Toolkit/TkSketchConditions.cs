using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x26B2A6E1D1D0EC94, NameHash = 0x42F1604851DA7F02)]
    public class TkSketchConditions : NMSTemplate
    {
        public enum ConditionEnum { Equal, NotEqual, Greater, Less, GreaterEqual, LessEqual };
        /* 0x0 */ public ConditionEnum Condition;
    }
}