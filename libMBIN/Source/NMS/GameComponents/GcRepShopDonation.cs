using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F7DF3031B4F2429, NameHash = 0x6CDCC5ED743D58A1)]
    public class GcRepShopDonation : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> AltIDs;
        /* 0x10 */ public NMSString0x10 ProductID;
        /* 0x20 */ public int DonationValue;
        /* 0x24 */ public int MaxDonations;
        [NMS(Size = 0x1A, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        /* 0x28 */ public bool[] ValidProcProdCategories;
    }
}
