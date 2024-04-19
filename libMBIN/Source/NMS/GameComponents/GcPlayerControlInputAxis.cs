using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1434290D0729CECA, NameHash = 0x52A4BE1415A68ECA)]
    public class GcPlayerControlInputAxis : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Output;
        /* 0x10 */ public NMSString0x10 OutputLength;
        /* 0x20 */ public GcInputActions InputX;
        /* 0x24 */ public GcInputActions InputY;
        /* 0x28 */ public GcCharacterControlOutputSpace OutputSpace;
        /* 0x2C */ public GcCharacterControlInputValidity Validity;
    }
}
