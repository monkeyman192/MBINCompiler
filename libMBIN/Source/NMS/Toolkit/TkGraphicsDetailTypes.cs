namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4EF1F56CF5CA5B73, NameHash = 0x98C0D964)]
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
    }
}
