using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87A7D49A988122DE, NameHash = 0x114C4232C254BE54)]
    public class GcMissionSequenceCollectMultiProducts : NMSTemplate
    {
        /* 0x000 */ public List<GcProductToCollect> Products;
        /* 0x010 */ public NMSString0x80 DebugText;
        /* 0x090 */ public NMSString0x80 Message;
        /* 0x110 */ public bool SearchCookingIngredients;
        /* 0x111 */ public bool WaitForSelected;
    }
}
