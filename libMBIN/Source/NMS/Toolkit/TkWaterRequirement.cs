namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC1191F03D50D1D, NameHash = 0x7599DD43)]
    public class TkWaterRequirement : NMSTemplate
    {
        // size: 0x4
        public enum WaterRequirementEnum : uint {
            InWaterNoStorm,
            OutOfWaterNoStorm,
            InWaterInStorm,
            OutOfWaterInStorm,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WaterRequirementEnum WaterRequirement;
    }
}
