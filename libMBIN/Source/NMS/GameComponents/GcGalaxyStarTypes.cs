namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3336B93F6817965, NameHash = 0x737DC36BC0894840)]
    public class GcGalaxyStarTypes : NMSTemplate
    {
        // size: 0x4
        public enum GalaxyStarTypeEnum : uint {
            Yellow,
            Green,
            Blue,
            Red,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalaxyStarTypeEnum GalaxyStarType;
    }
}
