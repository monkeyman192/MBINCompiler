namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADA9902A1B950F4D, NameHash = 0xEAABC6B9)]
    public class GcLegality : NMSTemplate
    {
        // size: 0x2
        public enum LegalityEnum : uint {
            Legal,
            Illegal,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LegalityEnum Legality;
    }
}
