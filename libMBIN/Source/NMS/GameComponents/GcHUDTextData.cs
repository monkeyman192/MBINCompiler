using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD02F7DA8F0B60DFD, NameHash = 0x68C859D9)]
    public class GcHUDTextData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcTextPreset Preset;
        [NMS(Index = 0)]
        /* 0x30 */ public GcHUDComponent Data;
        [NMS(Index = 1)]
        /* 0x58 */ public NMSString0x80 Text;
    }
}
