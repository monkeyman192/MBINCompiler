namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4499ADCE00A38AC7, NameHash = 0x9723C08A)]
    public class GcMovementDirection : NMSTemplate
    {
        // size: 0x4
        public enum MovementDirectionEnum : uint {
            WorldRelative,
            BodyRelative,
            HeadRelative,
            NotSet,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MovementDirectionEnum MovementDirection;
    }
}
