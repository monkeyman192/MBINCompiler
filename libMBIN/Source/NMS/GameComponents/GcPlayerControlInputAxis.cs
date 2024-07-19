using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A07E55AE1CEF010, NameHash = 0x6FB4A893)]
    public class GcPlayerControlInputAxis : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x10 Output;
        [NMS(Index = 5)]
        /* 0x10 */ public NMSString0x10 OutputLength;
        [NMS(Index = 1)]
        /* 0x20 */ public GcInputActions InputX;
        [NMS(Index = 2)]
        /* 0x24 */ public GcInputActions InputY;
        [NMS(Index = 3)]
        /* 0x28 */ public GcCharacterControlOutputSpace OutputSpace;
        [NMS(Index = 0)]
        /* 0x2C */ public GcCharacterControlInputValidity Validity;
    }
}
