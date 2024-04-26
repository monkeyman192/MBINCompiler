namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18D4335A77D190EA, NameHash = 0x1C08FB02D59766DB)]
    public class GcBaseSnapState : NMSTemplate
    {
        // size: 0x2
        public enum SnapStateEnum : uint {
            IsSnapped,
            NotSnapped,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SnapStateEnum SnapState;
    }
}
