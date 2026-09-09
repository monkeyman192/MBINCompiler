namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5E4BD9B1277C6446, NameHash = 0x98C0D964)]
    public class TkGraphicsDetailTypes : NMSTemplate
    {
        // size: 0x4
        public enum GraphicDetailEnum : uint {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GraphicDetailEnum GraphicDetail;
        // size: 0x4
        public enum MaxGraphicDetailEnum : uint {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public MaxGraphicDetailEnum MaxGraphicDetail;
    }
}
