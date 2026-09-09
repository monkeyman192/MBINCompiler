namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74248C0718AAA9F7, NameHash = 0x8B1E4D94)]
    public class GcSwatchColour : NMSTemplate
    {
        // size: 0x5
        public enum SwatchColourEnum : uint {
            None,
            Primary,
            Secondary,
            Tertiary,
            Quaternary,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SwatchColourEnum SwatchColour;
    }
}
