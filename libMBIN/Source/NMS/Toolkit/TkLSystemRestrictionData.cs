namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF3991C126F82FBD, NameHash = 0x2CE937F1C349DD12)]
    public class TkLSystemRestrictionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Amount;
        // size: 0x3
        public enum RestrictionEnum : uint {
            NoMoreThan,
            AtLeast,
            AtLeastIfICan,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public RestrictionEnum Restriction;
    }
}
