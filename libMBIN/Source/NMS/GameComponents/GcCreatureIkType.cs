namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42748B3F25F8C43A, NameHash = 0x8EABFDEC)]
    public class GcCreatureIkType : NMSTemplate
    {
        // size: 0x9
        public enum CreatureIkTypeEnum : uint {
            Foot,
            Hinge_X,
            Hinge_Y,
            Hinge_Z,
            Locked,
            Head,
            Toe,
            SpaceshipFoot,
            SpaceshipToe,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureIkTypeEnum CreatureIkType;
    }
}
