namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x17F28D0AC13F281E, NameHash = 0x7B36FAC2)]
    public class GcHazardModifiers : NMSTemplate
    {
        // size: 0x5
        public enum HazardModifierEnum : uint {
            Temperature,
            Toxicity,
            Radiation,
            LifeSupportDrain,
            Gravity,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HazardModifierEnum HazardModifier;
    }
}
