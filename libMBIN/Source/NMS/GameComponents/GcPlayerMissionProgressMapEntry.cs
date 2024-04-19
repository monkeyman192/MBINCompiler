namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5807E42B53C65688, NameHash = 0x7D5B5172D2A5F9E5)]
    public class GcPlayerMissionProgressMapEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public int MaxProgress;
        /* 0x14 */ public int MinProgress;
        /* 0x18 */ public int NewProgress;
    }
}
