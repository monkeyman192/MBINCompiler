using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x58)]
    public class GcCustomisationPreset : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        /* 0x10 */ public GcCharacterCustomisationData Data;
    }
}
