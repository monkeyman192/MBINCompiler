namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6B0DFEECC7D83E9F, NameHash = 0xD39E0796)]
    public class TkEmitterBillboardAlignment : NMSTemplate
    {
        // size: 0xA
        public enum BillboardAlignmentEnum : uint {
            Screen,
            XLocal,
            YLocal,
            ZLocal,
            NegativeXLocal,
            NegativeYLocal,
            NegativeZLocal,
            ScreenWorld,
            Wind,
            NegativeWind,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BillboardAlignmentEnum BillboardAlignment;
        // size: 0x3
        public enum FacingEnum : uint {
            Nothing,
            Camera,
            Wind,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public FacingEnum Facing;
    }
}
