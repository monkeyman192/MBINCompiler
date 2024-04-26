using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F7DF3031B4F2429, NameHash = 0x6CDCC5ED743D58A1)]
    public class GcRepShopDonation : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<NMSString0x10> AltIDs;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ProductID;
        [NMS(Index = 1)]
        /* 0x20 */ public int DonationValue;
        [NMS(Index = 2)]
        /* 0x24 */ public int MaxDonations;
        [NMS(Index = 3, Size = 0x1A, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        /* 0x28 */ public bool[] ValidProcProdCategories;
    }
}
