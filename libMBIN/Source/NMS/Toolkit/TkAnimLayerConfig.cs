using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFB2A653204DC6302, NameHash = 0x956D3414)]
    public class TkAnimLayerConfig : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A DefaultMask;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 LayerId;
        [NMS(Index = 3)]
        /* 0x30 */ public TkAnimLayerBlendMode BlendMode;
        [NMS(Index = 4)]
        /* 0x34 */ public TkAnimLayerType LayerType;
        [NMS(Index = 1)]
        /* 0x38 */ public int Priority;
    }
}
