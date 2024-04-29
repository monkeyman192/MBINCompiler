using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x701BA9460A300DD1, NameHash = 0x2EB82866D685EFBF)]
    public class GcMissionSequenceWaitForPhoto : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public List<GcBiomeType> Biomes;
        [NMS(Index = 6)]
        /* 0x010 */ public List<GcPhotoBuildings> Buildings;
        [NMS(Index = 4)]
        /* 0x020 */ public List<GcPhotoFauna> Fauna;
        [NMS(Index = 5)]
        /* 0x030 */ public List<GcPhotoFlora> Flora;
        [NMS(Index = 8)]
        /* 0x040 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0C0 */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x140 */ public NMSString0x80 MessageSecondary;
        [NMS(Index = 2)]
        /* 0x1C0 */ public NMSString0x80 MessageSuccess;
        [NMS(Index = 7)]
        /* 0x240 */ public bool TakeAmountFromSeasonData;
    }
}
