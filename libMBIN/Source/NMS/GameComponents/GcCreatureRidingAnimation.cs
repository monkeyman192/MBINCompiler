namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA70B833DAC54C69B, NameHash = 0x30D2507B)]
    public class GcCreatureRidingAnimation : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MovementAnim;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 RidingAnim;
    }
}
