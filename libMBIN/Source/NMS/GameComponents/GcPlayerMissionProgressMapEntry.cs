namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51F4BBD44DDA02AA, NameHash = 0xF1CD5357)]
    public class GcPlayerMissionProgressMapEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Mission;
        [NMS(Index = 2)]
        /* 0x10 */ public int MaxProgress;
        [NMS(Index = 1)]
        /* 0x14 */ public int MinProgress;
        [NMS(Index = 3)]
        /* 0x18 */ public int NewProgress;
    }
}
