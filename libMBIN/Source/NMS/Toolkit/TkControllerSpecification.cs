using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1C35718EC5E44EC4, NameHash = 0x274F6568)]
    public class TkControllerSpecification : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkAxisImageLookup AxisImageLookup;
        [NMS(Index = 1)]
        /* 0x10 */ public TkButtonImageLookup ButtonImageLookup;
        [NMS(Index = 3)]
        /* 0x20 */ public TkChordsImageLookup ChordsImageLookup;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 Id;
    }
}
