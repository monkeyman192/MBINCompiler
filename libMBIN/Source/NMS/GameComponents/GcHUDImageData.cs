using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x897ADD27652BA1C, NameHash = 0x91699059)]
    public class GcHUDImageData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 0)]
        /* 0x10 */ public GcHUDComponent Data;
        [NMS(Index = 1)]
        /* 0x38 */ public VariableSizeString Image;
    }
}
