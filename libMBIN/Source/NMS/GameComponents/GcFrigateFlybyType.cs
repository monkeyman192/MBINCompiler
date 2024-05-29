namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x521EA079410C9677, NameHash = 0x20BC4D823F8443DB)]
    public class GcFrigateFlybyType : NMSTemplate
    {
        // size: 0x6
        public enum FrigateFlybyTypeEnum : uint {
            SingleShip,
            AmbientGroup,
            ScriptedGroup,
            DeepSpace,
            DeepSpaceCommon,
            GhostShip,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FrigateFlybyTypeEnum FrigateFlybyType;
    }
}
