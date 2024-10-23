namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF2184CC3EF216124, NameHash = 0x7B36FAC2)]
    public class GcHazardModifiers : NMSTemplate
    {
        // size: 0x6
        public enum HazardModifierEnum : uint {
            Temperature,
            Toxicity,
            Radiation,
            LifeSupportDrain,
            Gravity,
            SpookLevel,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HazardModifierEnum HazardModifier;
    }
}
