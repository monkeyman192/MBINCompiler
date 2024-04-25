namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73ED7A3684434697, NameHash = 0x20BC4D823F8443DB)]
    public class GcFrigateFlybyType : NMSTemplate
    {
        // size: 0x5
        public enum FrigateFlybyTypeEnum : uint {
            SingleShip,
            AmbientGroup,
            ScriptedGroup,
            DeepSpace,
            DeepSpaceCommon,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FrigateFlybyTypeEnum FrigateFlybyType;
    }
}
