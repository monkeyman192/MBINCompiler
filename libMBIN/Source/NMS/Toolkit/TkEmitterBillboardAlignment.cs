namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2738B795E1C06C20, NameHash = 0xD39E0796)]
    public class TkEmitterBillboardAlignment : NMSTemplate
    {
        // size: 0x8
        public enum BillboardAlignmentEnum : uint {
            Screen,
            XLocal,
            YLocal,
            ZLocal,
            NegativeXLocal,
            NegativeYLocal,
            NegativeZLocal,
            ScreenWorld,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BillboardAlignmentEnum BillboardAlignment;
        [NMS(Index = 1)]
        /* 0x4 */ public bool CameraFacing;
    }
}
