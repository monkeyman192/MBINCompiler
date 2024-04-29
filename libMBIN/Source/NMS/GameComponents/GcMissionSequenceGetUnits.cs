namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF04754C03A6EB1C, NameHash = 0x785DA5C6069D4C12)]
    public class GcMissionSequenceGetUnits : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x04 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x84 */ public NMSString0x80 Message;
    }
}
