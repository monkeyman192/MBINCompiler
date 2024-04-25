namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB8EDF2555E5BAA8, NameHash = 0x5D985DDFEB620E01)]
    public class GcHeavyAirColourData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour Colour1;
        [NMS(Index = 1)]
        /* 0x10 */ public Colour Colour2;
    }
}
