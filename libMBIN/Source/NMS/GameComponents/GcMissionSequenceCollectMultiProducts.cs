using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27754599FDD0D58D, NameHash = 0x114C4232C254BE54)]
    public class GcMissionSequenceCollectMultiProducts : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public List<GcProductToCollect> Products;
        /* 0x90 */ public bool WaitForSelected;
        /* 0x91 */ public bool SearchCookingIngredients;
        /* 0x92 */ public NMSString0x80 DebugText;
    }
}
