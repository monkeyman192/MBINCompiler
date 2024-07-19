using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8C7B600EEAD3D23, NameHash = 0x6EA48115)]
    public class GcPhotoFlora : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 2)]
        /* 0x8 */ public GcPhotoPlant PlantType;
    }
}
