using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2301F3A104CD97B9, NameHash = 0x5DBD3B5170282610)]
    public class TkControllerSpecification : NMSTemplate
    {
        /* 0x00 */ public TkAxisImageLookup AxisImageLookup;
        /* 0x10 */ public TkButtonImageLookup ButtonImageLookup;
        /* 0x20 */ public TkChordsImageLookup ChordsImageLookup;
        /* 0x30 */ public NMSString0x10 Id;
    }
}
