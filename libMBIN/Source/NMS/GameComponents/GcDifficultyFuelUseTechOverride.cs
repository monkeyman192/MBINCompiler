namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2EEAF1C185BF493D, NameHash = 0x33AA0EBF)]
    public class GcDifficultyFuelUseTechOverride : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 TechID;
        [NMS(Index = 1)]
        /* 0x10 */ public float Multiplier;
    }
}
