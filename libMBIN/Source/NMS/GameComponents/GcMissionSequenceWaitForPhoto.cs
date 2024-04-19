using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB0CC38D5B31E41, NameHash = 0x2EB82866D685EFBF)]
    public class GcMissionSequenceWaitForPhoto : NMSTemplate
    {
        /* 0x000 */ public List<GcBiomeType> Biomes;
        /* 0x010 */ public List<GcPhotoBuildings> Buildings;
        /* 0x020 */ public List<GcPhotoFauna> Fauna;
        /* 0x030 */ public List<GcPhotoFlora> Flora;
        /* 0x040 */ public NMSString0x80 DebugText;
        /* 0x0C0 */ public NMSString0x80 Message;
        /* 0x140 */ public NMSString0x80 MessageSecondary;
        /* 0x1C0 */ public NMSString0x80 MessageSuccess;
        /* 0x240 */ public bool TakeAmountFromSeasonData;
    }
}
