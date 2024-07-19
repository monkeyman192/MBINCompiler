using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFD3FDCA529B205CA, NameHash = 0x5A2C01C8)]
    public class GcMissionSequenceWaitForPhoto : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcBiomeType> Biomes;
        [NMS(Index = 6)]
        /* 0x10 */ public List<GcPhotoBuildings> Buildings;
        [NMS(Index = 8)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 4)]
        /* 0x30 */ public List<GcPhotoFauna> Fauna;
        [NMS(Index = 5)]
        /* 0x40 */ public List<GcPhotoFlora> Flora;
        [NMS(Index = 0)]
        /* 0x50 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x60 */ public VariableSizeString MessageSecondary;
        [NMS(Index = 2)]
        /* 0x70 */ public VariableSizeString MessageSuccess;
        [NMS(Index = 7)]
        /* 0x80 */ public bool TakeAmountFromSeasonData;
    }
}
