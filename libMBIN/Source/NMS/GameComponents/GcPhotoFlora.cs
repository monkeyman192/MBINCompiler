using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB0C1D88F9BA886D, NameHash = 0x2D2DE27512E8C450)]
    public class GcPhotoFlora : NMSTemplate
    {
        /* 0x0 */ public int AmountMax;
        /* 0x4 */ public int AmountMin;
        /* 0x8 */ public GcPhotoPlant PlantType;
    }
}
