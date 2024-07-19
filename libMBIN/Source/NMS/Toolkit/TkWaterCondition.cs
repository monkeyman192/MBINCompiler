namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x54D937DCCD775C1D, NameHash = 0x3C58F148)]
    public class TkWaterCondition : NMSTemplate
    {
        // size: 0xD
        public enum WaterConditionEnum : uint {
            Breezy_Lake,
            Wavy_Lake,
            Still_Pond,
            Agitated_Pond,
            Agitated_Lake,
            Surf,
            Big_Surf,
            Chaotic_Sea,
            Huge_Swell,
            Choppy_Sea,
            Very_Choppy_Sea,
            White_Horses,
            Ocean_Planet,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WaterConditionEnum WaterCondition;
    }
}
