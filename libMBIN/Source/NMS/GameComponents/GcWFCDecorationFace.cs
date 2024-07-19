namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x716FA65505FAE342, NameHash = 0x97F38AF7)]
    public class GcWFCDecorationFace : NMSTemplate
    {
        // size: 0x3
        public enum CanWalkEnum : uint {
            None,
            RequireCanWalk,
            RequireCanNotWalk,
        }
        [NMS(Index = 1)]
        /* 0x0 */ public CanWalkEnum CanWalk;
        [NMS(Index = 0)]
        /* 0x4 */ public NMSString0x80 RequiredFace;
    }
}
