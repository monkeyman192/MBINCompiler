namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC578ECEEBCAAE131, NameHash = 0x2EC0D521)]
    public class GcMissionConditionUsingPortal : NMSTemplate
    {
        // size: 0x3
        public enum PortalTypeEnum : uint {
            Any,
            Story,
            NotStory,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PortalTypeEnum PortalType;
    }
}
