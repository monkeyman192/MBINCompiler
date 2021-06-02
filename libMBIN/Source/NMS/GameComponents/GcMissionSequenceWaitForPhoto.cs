using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x240, GUID = 0x812B41B01DFCC437, NameHash = 0x2EB82866D685EFBF)]
    public class GcMissionSequenceWaitForPhoto : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageSecondary;
        /* 0x100 */ public NMSString0x80 MessageSuccess;
        /* 0x180 */ public List<GcBiomeType> Biomes;
        /* 0x190 */ public List<GcPhotoFauna> Fauna;
        /* 0x1A0 */ public List<GcPhotoFlora> Flora;
        /* 0x1B0 */ public List<GcPhotoBuildings> Buildings;
        /* 0x1C0 */ public NMSString0x80 DebugText;
    }
}
