namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x60E7D2D27320F6E, NameHash = 0xE7B1F031)]
    public class TkAnimLayerBlendMode : NMSTemplate
    {
        // size: 0x2
        public enum AnimLayerBlendModeEnum : uint {
            Replace,
            Additive,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AnimLayerBlendModeEnum AnimLayerBlendMode;
    }
}
