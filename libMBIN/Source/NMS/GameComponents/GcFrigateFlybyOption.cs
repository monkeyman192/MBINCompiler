using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAF4E73C6A138709, NameHash = 0x7219E3FF7006060F)]
    public class GcFrigateFlybyOption : NMSTemplate
    {
        /* 0x0 */ public GcFrigateClass FrigateClass;
        /* 0x4 */ public int MaxCount;
        /* 0x8 */ public int MinCount;
        /* 0xC */ public float Weight;
    }
}
