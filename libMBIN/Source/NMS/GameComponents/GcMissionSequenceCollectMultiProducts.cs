using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87A7D49A988122DE, NameHash = 0x114C4232C254BE54)]
    public class GcMissionSequenceCollectMultiProducts : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public List<GcProductToCollect> Products;
        [NMS(Index = 4)]
        /* 0x010 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x090 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x110 */ public bool SearchCookingIngredients;
        [NMS(Index = 2)]
        /* 0x111 */ public bool WaitForSelected;
    }
}
