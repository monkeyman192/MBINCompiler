namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8FAE58FEC81D927, NameHash = 0xCFF86E7B)]
    public class GcGalaxyStarTypes : NMSTemplate
    {
        // size: 0x5
        public enum GalaxyStarTypeEnum : uint {
            Yellow,
            Green,
            Blue,
            Red,
            Purple,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalaxyStarTypeEnum GalaxyStarType;
    }
}
