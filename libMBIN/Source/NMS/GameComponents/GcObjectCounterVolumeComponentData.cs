using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8E863DE83E583C6, NameHash = 0xC3B19E13)]
    public class GcObjectCounterVolumeComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcObjectCounterVolumeType CounterVolumeType;
    }
}
