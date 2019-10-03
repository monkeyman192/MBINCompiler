using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xF148E364848F2605, NameHash = 0x6B329F862808895A)]
    public class GcCustomisationPreset : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        /* 0x10 */ public GcCharacterCustomisationData Data;
    }
}
