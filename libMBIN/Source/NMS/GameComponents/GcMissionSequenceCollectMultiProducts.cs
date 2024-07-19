using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8092A36678DACBA, NameHash = 0x8E5219B2)]
    public class GcMissionSequenceCollectMultiProducts : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcProductToCollect> Products;
        [NMS(Index = 3)]
        /* 0x30 */ public bool SearchCookingIngredients;
        [NMS(Index = 2)]
        /* 0x31 */ public bool WaitForSelected;
    }
}
