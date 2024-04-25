namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x931FF264F649885B, NameHash = 0x7BCF7FA8AF0C694F)]
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
